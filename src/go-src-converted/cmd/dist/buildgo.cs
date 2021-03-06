// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package main -- go2cs converted at 2020 August 29 09:59:40 UTC
// Original source: C:\Go\src\cmd\dist\buildgo.go
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        /*
         * Helpers for building cmd/go and cmd/cgo.
         */

        // mkzdefaultcc writes zdefaultcc.go:
        //
        //    package main
        //    const defaultCC = <defaultcc>
        //    const defaultCXX = <defaultcxx>
        //    const defaultPkgConfig = <defaultpkgconfig>
        //
        // It is invoked to write cmd/go/internal/cfg/zdefaultcc.go
        // but we also write cmd/cgo/zdefaultcc.go
        private static void mkzdefaultcc(@string dir, @string file)
        {
            if (strings.Contains(file, filepath.FromSlash("go/internal/cfg")))
            {
                bytes.Buffer buf = default;
                fmt.Fprintf(ref buf, "// Code generated by go tool dist; DO NOT EDIT.\n");
                fmt.Fprintln(ref buf);
                fmt.Fprintf(ref buf, "package cfg\n");
                fmt.Fprintln(ref buf);
                fmt.Fprintf(ref buf, "const DefaultPkgConfig = `%s`\n", defaultpkgconfig);
                buf.WriteString(defaultCCFunc("DefaultCC", defaultcc));
                buf.WriteString(defaultCCFunc("DefaultCXX", defaultcxx));
                writefile(buf.String(), file, writeSkipSame);
                return;
            }
            buf = default;
            fmt.Fprintf(ref buf, "// Code generated by go tool dist; DO NOT EDIT.\n");
            fmt.Fprintln(ref buf);
            fmt.Fprintf(ref buf, "package main\n");
            fmt.Fprintln(ref buf);
            fmt.Fprintf(ref buf, "const defaultPkgConfig = `%s`\n", defaultpkgconfig);
            buf.WriteString(defaultCCFunc("defaultCC", defaultcc));
            buf.WriteString(defaultCCFunc("defaultCXX", defaultcxx));
            writefile(buf.String(), file, writeSkipSame);
        }

        private static @string defaultCCFunc(@string name, map<@string, @string> defaultcc)
        {
            bytes.Buffer buf = default;

            fmt.Fprintf(ref buf, "func %s(goos, goarch string) string {\n", name);
            fmt.Fprintf(ref buf, "\tswitch goos+`/`+goarch {\n");
            slice<@string> keys = default;
            {
                var k__prev1 = k;

                foreach (var (__k) in defaultcc)
                {
                    k = __k;
                    if (k != "")
                    {
                        keys = append(keys, k);
                    }
                }

                k = k__prev1;
            }

            sort.Strings(keys);
            {
                var k__prev1 = k;

                foreach (var (_, __k) in keys)
                {
                    k = __k;
                    fmt.Fprintf(ref buf, "\tcase %q:\n\t\treturn %q\n", k, defaultcc[k]);
                }

                k = k__prev1;
            }

            fmt.Fprintf(ref buf, "\t}\n");
            fmt.Fprintf(ref buf, "\treturn %q\n", defaultcc[""]);
            fmt.Fprintf(ref buf, "}\n");

            return buf.String();
        }

        // mkzcgo writes zosarch.go for cmd/go.
        private static void mkzosarch(@string dir, @string file)
        { 
            // sort for deterministic zosarch.go file
            slice<@string> list = default;
            {
                var plat__prev1 = plat;

                foreach (var (__plat) in cgoEnabled)
                {
                    plat = __plat;
                    list = append(list, plat);
                }

                plat = plat__prev1;
            }

            sort.Strings(list);

            bytes.Buffer buf = default;
            fmt.Fprintf(ref buf, "// Code generated by go tool dist; DO NOT EDIT.\n\n");
            fmt.Fprintf(ref buf, "package cfg\n\n");
            fmt.Fprintf(ref buf, "var OSArchSupportsCgo = map[string]bool{\n");
            {
                var plat__prev1 = plat;

                foreach (var (_, __plat) in list)
                {
                    plat = __plat;
                    fmt.Fprintf(ref buf, "\t%q: %v,\n", plat, cgoEnabled[plat]);
                }

                plat = plat__prev1;
            }

            fmt.Fprintf(ref buf, "}\n");

            writefile(buf.String(), file, writeSkipSame);
        }

        // mkzcgo writes zcgo.go for the go/build package:
        //
        //    package build
        //  var cgoEnabled = map[string]bool{}
        //
        // It is invoked to write go/build/zcgo.go.
        private static void mkzcgo(@string dir, @string file)
        { 
            // sort for deterministic zcgo.go file
            slice<@string> list = default;
            {
                var plat__prev1 = plat;

                foreach (var (__plat, __hasCgo) in cgoEnabled)
                {
                    plat = __plat;
                    hasCgo = __hasCgo;
                    if (hasCgo)
                    {
                        list = append(list, plat);
                    }
                }

                plat = plat__prev1;
            }

            sort.Strings(list);

            bytes.Buffer buf = default;
            fmt.Fprintf(ref buf, "// Code generated by go tool dist; DO NOT EDIT.\n");
            fmt.Fprintln(ref buf);
            fmt.Fprintf(ref buf, "package build\n");
            fmt.Fprintln(ref buf);
            fmt.Fprintf(ref buf, "const defaultCGO_ENABLED = %q\n", os.Getenv("CGO_ENABLED"));
            fmt.Fprintln(ref buf);
            fmt.Fprintf(ref buf, "var cgoEnabled = map[string]bool{\n");
            {
                var plat__prev1 = plat;

                foreach (var (_, __plat) in list)
                {
                    plat = __plat;
                    fmt.Fprintf(ref buf, "\t%q: true,\n", plat);
                }

                plat = plat__prev1;
            }

            fmt.Fprintf(ref buf, "}\n");

            writefile(buf.String(), file, writeSkipSame);
        }
    }
}
