//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct traceBufHeader
        {
            // Constructors
            public traceBufHeader(NilType _)
            {
                this.link = default;
                this.lastTicks = default;
                this.pos = default;
                this.stk = default;
            }

            public traceBufHeader(traceBufPtr link = default, ulong lastTicks = default, long pos = default, array<System.UIntPtr> stk = default)
            {
                this.link = link;
                this.lastTicks = lastTicks;
                this.pos = pos;
                this.stk = stk;
            }

            // Enable comparisons between nil and traceBufHeader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(traceBufHeader value, NilType nil) => value.Equals(default(traceBufHeader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(traceBufHeader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, traceBufHeader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, traceBufHeader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator traceBufHeader(NilType nil) => default(traceBufHeader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static traceBufHeader traceBufHeader_cast(dynamic value)
        {
            return new traceBufHeader(value.link, value.lastTicks, value.pos, value.stk);
        }
    }
}