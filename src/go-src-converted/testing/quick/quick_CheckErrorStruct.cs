//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flag = go.flag_package;
using fmt = go.fmt_package;
using math = go.math_package;
using rand = go.math.rand_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace testing
{
    public static partial class quick_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CheckError
        {
            // Constructors
            public CheckError(NilType _)
            {
                this.Count = default;
                this.In = default;
            }

            public CheckError(long Count = default, slice<object> In = default)
            {
                this.Count = Count;
                this.In = In;
            }

            // Enable comparisons between nil and CheckError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CheckError value, NilType nil) => value.Equals(default(CheckError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CheckError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CheckError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CheckError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CheckError(NilType nil) => default(CheckError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CheckError CheckError_cast(dynamic value)
        {
            return new CheckError(value.Count, value.In);
        }
    }
}}