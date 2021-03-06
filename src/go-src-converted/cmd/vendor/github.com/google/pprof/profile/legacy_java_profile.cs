// Copyright 2014 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// This file implements parsers to convert java legacy profiles into
// the profile.proto format.

// package profile -- go2cs converted at 2020 August 29 10:06:22 UTC
// import "cmd/vendor/github.com/google/pprof/profile" ==> using profile = go.cmd.vendor.github.com.google.pprof.profile_package
// Original source: C:\Go\src\cmd\vendor\github.com\google\pprof\profile\legacy_java_profile.go
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using static go.builtin;
using System;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class profile_package
    {
        private static var attributeRx = regexp.MustCompile("([\\w ]+)=([\\w ]+)");        private static var javaSampleRx = regexp.MustCompile(" *(\\d+) +(\\d+) +@ +([ x0-9a-f]*)");        private static var javaLocationRx = regexp.MustCompile("^\\s*0x([[:xdigit:]]+)\\s+(.*)\\s*$");        private static var javaLocationFileLineRx = regexp.MustCompile("^(.*)\\s+\\((.+):(-?[[:digit:]]+)\\)$");        private static var javaLocationPathRx = regexp.MustCompile("^(.*)\\s+\\((.*)\\)$");

        // javaCPUProfile returns a new Profile from profilez data.
        // b is the profile bytes after the header, period is the profiling
        // period, and parse is a function to parse 8-byte chunks from the
        // profile in its native endianness.
        private static (ref Profile, error) javaCPUProfile(slice<byte> b, long period, Func<slice<byte>, (ulong, slice<byte>)> parse)
        {
            Profile p = ref new Profile(Period:period*1000,PeriodType:&ValueType{Type:"cpu",Unit:"nanoseconds"},SampleType:[]*ValueType{{Type:"samples",Unit:"count"},{Type:"cpu",Unit:"nanoseconds"}},);
            error err = default;
            map<ulong, ref Location> locs = default;
            b, locs, err = parseCPUSamples(b, parse, false, p);

            if (err != null)
            {
                return (null, err);
            }
            err = error.As(parseJavaLocations(b, locs, p));

            if (err != null)
            {
                return (null, err);
            } 

            // Strip out addresses for better merge.
            err = error.As(p.Aggregate(true, true, true, true, false));

            if (err != null)
            {
                return (null, err);
            }
            return (p, null);
        }

        // parseJavaProfile returns a new profile from heapz or contentionz
        // data. b is the profile bytes after the header.
        private static (ref Profile, error) parseJavaProfile(slice<byte> b)
        {
            var h = bytes.SplitAfterN(b, (slice<byte>)"\n", 2L);
            if (len(h) < 2L)
            {
                return (null, errUnrecognized);
            }
            Profile p = ref new Profile(PeriodType:&ValueType{},);
            var header = string(bytes.TrimSpace(h[0L]));

            error err = default;
            @string pType = default;
            switch (header)
            {
                case "--- heapz 1 ---": 
                    pType = "heap";
                    break;
                case "--- contentionz 1 ---": 
                    pType = "contention";
                    break;
                default: 
                    return (null, errUnrecognized);
                    break;
            }

            b, err = parseJavaHeader(pType, h[1L], p);

            if (err != null)
            {
                return (null, err);
            }
            map<ulong, ref Location> locs = default;
            b, locs, err = parseJavaSamples(pType, b, p);

            if (err != null)
            {
                return (null, err);
            }
            err = error.As(parseJavaLocations(b, locs, p));

            if (err != null)
            {
                return (null, err);
            } 

            // Strip out addresses for better merge.
            err = error.As(p.Aggregate(true, true, true, true, false));

            if (err != null)
            {
                return (null, err);
            }
            return (p, null);
        }

        // parseJavaHeader parses the attribute section on a java profile and
        // populates a profile. Returns the remainder of the buffer after all
        // attributes.
        private static (slice<byte>, error) parseJavaHeader(@string pType, slice<byte> b, ref Profile p)
        {
            var nextNewLine = bytes.IndexByte(b, byte('\n'));
            while (nextNewLine != -1L)
            {
                var line = string(bytes.TrimSpace(b[0L..nextNewLine]));
                if (line != "")
                {
                    var h = attributeRx.FindStringSubmatch(line);
                    if (h == null)
                    { 
                        // Not a valid attribute, exit.
                        return (b, null);
                    }
                    var attribute = strings.TrimSpace(h[1L]);
                    var value = strings.TrimSpace(h[2L]);
                    error err = default;
                    switch (pType + "/" + attribute)
                    {
                        case "heap/format": 

                        case "cpu/format": 

                        case "contention/format": 
                            if (value != "java")
                            {
                                return (null, errUnrecognized);
                            }
                            break;
                        case "heap/resolution": 
                            p.SampleType = new slice<ref ValueType>(new ref ValueType[] { {Type:"inuse_objects",Unit:"count"}, {Type:"inuse_space",Unit:value} });
                            break;
                        case "contention/resolution": 
                            p.SampleType = new slice<ref ValueType>(new ref ValueType[] { {Type:"contentions",Unit:value}, {Type:"delay",Unit:value} });
                            break;
                        case "contention/sampling period": 
                            p.PeriodType = ref new ValueType(Type:"contentions",Unit:"count",);
                            p.Period, err = strconv.ParseInt(value, 0L, 64L);

                            if (err != null)
                            {
                                return (null, fmt.Errorf("failed to parse attribute %s: %v", line, err));
                            }
                            break;
                        case "contention/ms since reset": 
                            var (millis, err) = strconv.ParseInt(value, 0L, 64L);
                            if (err != null)
                            {
                                return (null, fmt.Errorf("failed to parse attribute %s: %v", line, err));
                            }
                            p.DurationNanos = millis * 1000L * 1000L;
                            break;
                        default: 
                            return (null, errUnrecognized);
                            break;
                    }
                } 
                // Grab next line.
                b = b[nextNewLine + 1L..];
                nextNewLine = bytes.IndexByte(b, byte('\n'));
            }

            return (b, null);
        }

        // parseJavaSamples parses the samples from a java profile and
        // populates the Samples in a profile. Returns the remainder of the
        // buffer after the samples.
        private static (slice<byte>, map<ulong, ref Location>, error) parseJavaSamples(@string pType, slice<byte> b, ref Profile p)
        {
            var nextNewLine = bytes.IndexByte(b, byte('\n'));
            var locs = make_map<ulong, ref Location>();
            while (nextNewLine != -1L)
            {
                var line = string(bytes.TrimSpace(b[0L..nextNewLine]));
                if (line != "")
                {
                    var sample = javaSampleRx.FindStringSubmatch(line);
                    if (sample == null)
                    { 
                        // Not a valid sample, exit.
                        return (b, locs, null);
                    } 

                    // Java profiles have data/fields inverted compared to other
                    // profile types.
                    error err = default;
                    var value1 = sample[2L];
                    var value2 = sample[1L];
                    var value3 = sample[3L];
                    var (addrs, err) = parseHexAddresses(value3);
                    if (err != null)
                    {
                        return (null, null, fmt.Errorf("malformed sample: %s: %v", line, err));
                    }
                    slice<ref Location> sloc = default;
                    foreach (var (_, addr) in addrs)
                    {
                        var loc = locs[addr];
                        if (locs[addr] == null)
                        {
                            loc = ref new Location(Address:addr,);
                            p.Location = append(p.Location, loc);
                            locs[addr] = loc;
                        }
                        sloc = append(sloc, loc);
                    }
                    Sample s = ref new Sample(Value:make([]int64,2),Location:sloc,);

                    s.Value[0L], err = strconv.ParseInt(value1, 0L, 64L);

                    if (err != null)
                    {
                        return (null, null, fmt.Errorf("parsing sample %s: %v", line, err));
                    }
                    s.Value[1L], err = strconv.ParseInt(value2, 0L, 64L);

                    if (err != null)
                    {
                        return (null, null, fmt.Errorf("parsing sample %s: %v", line, err));
                    }
                    switch (pType)
                    {
                        case "heap": 
                                                   const long javaHeapzSamplingRate = 524288L; // 512K
                            // 512K
                                                   if (s.Value[0L] == 0L)
                                                   {
                                                       return (null, null, fmt.Errorf("parsing sample %s: second value must be non-zero", line));
                                                   }
                                                   s.NumLabel = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<@string, slice<long>>{"bytes":{s.Value[1]/s.Value[0]}};
                                                   s.Value[0L], s.Value[1L] = scaleHeapSample(s.Value[0L], s.Value[1L], javaHeapzSamplingRate);
                            break;
                        case "contention": 
                            {
                                var period = p.Period;

                                if (period != 0L)
                                {
                                    s.Value[0L] = s.Value[0L] * p.Period;
                                    s.Value[1L] = s.Value[1L] * p.Period;
                                }

                            }
                            break;
                    }
                    p.Sample = append(p.Sample, s);
                } 
                // Grab next line.
                b = b[nextNewLine + 1L..];
                nextNewLine = bytes.IndexByte(b, byte('\n'));
            }

            return (b, locs, null);
        }

        // parseJavaLocations parses the location information in a java
        // profile and populates the Locations in a profile. It uses the
        // location addresses from the profile as both the ID of each
        // location.
        private static error parseJavaLocations(slice<byte> b, map<ulong, ref Location> locs, ref Profile p)
        {
            var r = bytes.NewBuffer(b);
            var fns = make_map<@string, ref Function>();
            while (true)
            {
                var (line, err) = r.ReadString('\n');
                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return error.As(err);
                    }
                    if (line == "")
                    {
                        break;
                    }
                }
                line = strings.TrimSpace(line);

                if (line == "")
                {
                    continue;
                }
                var jloc = javaLocationRx.FindStringSubmatch(line);
                if (len(jloc) != 3L)
                {
                    continue;
                }
                var (addr, err) = strconv.ParseUint(jloc[1L], 16L, 64L);
                if (err != null)
                {
                    return error.As(fmt.Errorf("parsing sample %s: %v", line, err));
                }
                var loc = locs[addr];
                if (loc == null)
                { 
                    // Unused/unseen
                    continue;
                }
                @string lineFunc = default;                @string lineFile = default;

                long lineNo = default;

                {
                    var fileLine = javaLocationFileLineRx.FindStringSubmatch(jloc[2L]);

                    if (len(fileLine) == 4L)
                    { 
                        // Found a line of the form: "function (file:line)"
                        lineFunc = fileLine[1L];
                        lineFile = fileLine[2L];
                        {
                            var (n, err) = strconv.ParseInt(fileLine[3L], 10L, 64L);

                            if (err == null && n > 0L)
                            {
                                lineNo = n;
                            }

                        }
                    }                    {
                        var filePath = javaLocationPathRx.FindStringSubmatch(jloc[2L]);


                        else if (len(filePath) == 3L)
                        { 
                            // If there's not a file:line, it's a shared library path.
                            // The path isn't interesting, so just give the .so.
                            lineFunc = filePath[1L];
                            lineFile = filepath.Base(filePath[2L]);
                        }
                        else if (strings.Contains(jloc[2L], "generated stub/JIT"))
                        {
                            lineFunc = "STUB";
                        }
                        else
                        { 
                            // Treat whole line as the function name. This is used by the
                            // java agent for internal states such as "GC" or "VM".
                            lineFunc = jloc[2L];
                        }

                    }

                }
                var fn = fns[lineFunc];

                if (fn == null)
                {
                    fn = ref new Function(Name:lineFunc,SystemName:lineFunc,Filename:lineFile,);
                    fns[lineFunc] = fn;
                    p.Function = append(p.Function, fn);
                }
                loc.Line = new slice<Line>(new Line[] { {Function:fn,Line:lineNo,} });
                loc.Address = 0L;
            }


            p.remapLocationIDs();
            p.remapFunctionIDs();
            p.remapMappingIDs();

            return error.As(null);
        }
    }
}}}}}}
