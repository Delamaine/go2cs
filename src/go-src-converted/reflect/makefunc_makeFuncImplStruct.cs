//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:59 UTC
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
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct makeFuncImpl
        {
            // Constructors
            public makeFuncImpl(NilType _)
            {
                this.code = default;
                this.stack = default;
                this.typ = default;
                this.fn = default;
            }

            public makeFuncImpl(System.UIntPtr code = default, ref ptr<bitVector> stack = default, ref ptr<funcType> typ = default, Func<slice<Value>, slice<Value>> fn = default)
            {
                this.code = code;
                this.stack = stack;
                this.typ = typ;
                this.fn = fn;
            }

            // Enable comparisons between nil and makeFuncImpl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(makeFuncImpl value, NilType nil) => value.Equals(default(makeFuncImpl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(makeFuncImpl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, makeFuncImpl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, makeFuncImpl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator makeFuncImpl(NilType nil) => default(makeFuncImpl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static makeFuncImpl makeFuncImpl_cast(dynamic value)
        {
            return new makeFuncImpl(value.code, ref value.stack, ref value.typ, value.fn);
        }
    }
}