//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class web_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct HTTPError
        {
            // Constructors
            public HTTPError(NilType _)
            {
                this.StatusCode = default;
            }

            public HTTPError(long StatusCode = default)
            {
                this.StatusCode = StatusCode;
            }

            // Enable comparisons between nil and HTTPError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HTTPError value, NilType nil) => value.Equals(default(HTTPError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HTTPError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HTTPError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HTTPError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HTTPError(NilType nil) => default(HTTPError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static HTTPError HTTPError_cast(dynamic value)
        {
            return new HTTPError(value.StatusCode);
        }
    }
}}}}