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
        private partial struct unexportedErrorOtherFields
        {
            // Constructors
            public unexportedErrorOtherFields(NilType _)
            {
                this.s = default;
                this.e = default;
                this.S = default;
            }

            public unexportedErrorOtherFields(@string s = default, error e = default, @string S = default)
            {
                this.s = s;
                this.e = e;
                this.S = S;
            }

            // Enable comparisons between nil and unexportedErrorOtherFields struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(unexportedErrorOtherFields value, NilType nil) => value.Equals(default(unexportedErrorOtherFields));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(unexportedErrorOtherFields value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, unexportedErrorOtherFields value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, unexportedErrorOtherFields value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unexportedErrorOtherFields(NilType nil) => default(unexportedErrorOtherFields);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static unexportedErrorOtherFields unexportedErrorOtherFields_cast(dynamic value)
        {
            return new unexportedErrorOtherFields(value.s, value.e, value.S);
        }
    }
}}}