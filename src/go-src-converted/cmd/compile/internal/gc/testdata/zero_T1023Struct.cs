//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:58:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T1023
        {
            // Constructors
            public T1023(NilType _)
            {
                this.pre = default;
                this.mid = default;
                this.post = default;
            }

            public T1023(array<byte> pre = default, array<byte> mid = default, array<byte> post = default)
            {
                this.pre = pre;
                this.mid = mid;
                this.post = post;
            }

            // Enable comparisons between nil and T1023 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1023 value, NilType nil) => value.Equals(default(T1023));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1023 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1023 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1023 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1023(NilType nil) => default(T1023);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T1023 T1023_cast(dynamic value)
        {
            return new T1023(value.pre, value.mid, value.post);
        }
    }
}