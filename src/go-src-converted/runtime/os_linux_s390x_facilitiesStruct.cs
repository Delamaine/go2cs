//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct facilities
        {
            // Constructors
            public facilities(NilType _)
            {
                this._ = default;
                this.hasVX = default;
                this._ = default;
            }

            public facilities(array<byte> _ = default, bool hasVX = default, array<byte> _ = default)
            {
                this._ = _;
                this.hasVX = hasVX;
                this._ = _;
            }

            // Enable comparisons between nil and facilities struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(facilities value, NilType nil) => value.Equals(default(facilities));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(facilities value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, facilities value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, facilities value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator facilities(NilType nil) => default(facilities);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static facilities facilities_cast(dynamic value)
        {
            return new facilities(value._, value.hasVX, value._);
        }
    }
}