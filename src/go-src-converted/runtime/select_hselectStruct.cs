//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:19:55 UTC
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
        private partial struct hselect
        {
            // Constructors
            public hselect(NilType _)
            {
                this.tcase = default;
                this.ncase = default;
                this.pollorder = default;
                this.lockorder = default;
                this.scase = default;
            }

            public hselect(ushort tcase = default, ushort ncase = default, ref ptr<ushort> pollorder = default, ref ptr<ushort> lockorder = default, array<scase> scase = default)
            {
                this.tcase = tcase;
                this.ncase = ncase;
                this.pollorder = pollorder;
                this.lockorder = lockorder;
                this.scase = scase;
            }

            // Enable comparisons between nil and hselect struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hselect value, NilType nil) => value.Equals(default(hselect));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hselect value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hselect value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hselect value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hselect(NilType nil) => default(hselect);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static hselect hselect_cast(dynamic value)
        {
            return new hselect(value.tcase, value.ncase, ref value.pollorder, ref value.lockorder, value.scase);
        }
    }
}