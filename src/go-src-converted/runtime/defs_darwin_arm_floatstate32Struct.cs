//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct floatstate32
        {
            // Constructors
            public floatstate32(NilType _)
            {
                this.r = default;
                this.fpscr = default;
            }

            public floatstate32(array<uint> r = default, uint fpscr = default)
            {
                this.r = r;
                this.fpscr = fpscr;
            }

            // Enable comparisons between nil and floatstate32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(floatstate32 value, NilType nil) => value.Equals(default(floatstate32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(floatstate32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, floatstate32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, floatstate32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator floatstate32(NilType nil) => default(floatstate32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static floatstate32 floatstate32_cast(dynamic value)
        {
            return new floatstate32(value.r, value.fpscr);
        }
    }
}