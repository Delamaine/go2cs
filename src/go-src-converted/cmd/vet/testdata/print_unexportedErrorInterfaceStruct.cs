//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using math = go.math_package;
using os = go.os_package;
using testing = go.testing_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct unexportedErrorInterface
        {
            // Constructors
            public unexportedErrorInterface(NilType _)
            {
                this.e = default;
            }

            public unexportedErrorInterface(errorInterface e = default)
            {
                this.e = e;
            }

            // Enable comparisons between nil and unexportedErrorInterface struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(unexportedErrorInterface value, NilType nil) => value.Equals(default(unexportedErrorInterface));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(unexportedErrorInterface value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, unexportedErrorInterface value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, unexportedErrorInterface value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unexportedErrorInterface(NilType nil) => default(unexportedErrorInterface);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static unexportedErrorInterface unexportedErrorInterface_cast(dynamic value)
        {
            return new unexportedErrorInterface(value.e);
        }
    }
}}}