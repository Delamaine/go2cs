//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Func
        {
            // Constructors
            public Func(NilType _)
            {
            }
            // Enable comparisons between nil and Func struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Func value, NilType nil) => value.Equals(default(Func));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Func value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Func value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Func value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Func(NilType nil) => default(Func);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Func Func_cast(dynamic value)
        {
            return new Func();
        }
    }
}