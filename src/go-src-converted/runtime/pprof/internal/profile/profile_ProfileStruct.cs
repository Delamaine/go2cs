//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:24:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace runtime {
namespace pprof {
namespace @internal
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Profile
        {
            // Constructors
            public Profile(NilType _)
            {
                this.SampleType = default;
                this.Sample = default;
                this.Mapping = default;
                this.Location = default;
                this.Function = default;
                this.DropFrames = default;
                this.KeepFrames = default;
                this.TimeNanos = default;
                this.DurationNanos = default;
                this.PeriodType = default;
                this.Period = default;
                this.dropFramesX = default;
                this.keepFramesX = default;
                this.stringTable = default;
            }

            public Profile(slice<ref ValueType> SampleType = default, slice<ref Sample> Sample = default, slice<ref Mapping> Mapping = default, slice<ref Location> Location = default, slice<ref Function> Function = default, @string DropFrames = default, @string KeepFrames = default, long TimeNanos = default, long DurationNanos = default, ref ptr<ValueType> PeriodType = default, long Period = default, long dropFramesX = default, long keepFramesX = default, slice<@string> stringTable = default)
            {
                this.SampleType = SampleType;
                this.Sample = Sample;
                this.Mapping = Mapping;
                this.Location = Location;
                this.Function = Function;
                this.DropFrames = DropFrames;
                this.KeepFrames = KeepFrames;
                this.TimeNanos = TimeNanos;
                this.DurationNanos = DurationNanos;
                this.PeriodType = PeriodType;
                this.Period = Period;
                this.dropFramesX = dropFramesX;
                this.keepFramesX = keepFramesX;
                this.stringTable = stringTable;
            }

            // Enable comparisons between nil and Profile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Profile value, NilType nil) => value.Equals(default(Profile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Profile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Profile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Profile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Profile(NilType nil) => default(Profile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Profile Profile_cast(dynamic value)
        {
            return new Profile(value.SampleType, value.Sample, value.Mapping, value.Location, value.Function, value.DropFrames, value.KeepFrames, value.TimeNanos, value.DurationNanos, ref value.PeriodType, value.Period, value.dropFramesX, value.keepFramesX, value.stringTable);
        }
    }
}}}}