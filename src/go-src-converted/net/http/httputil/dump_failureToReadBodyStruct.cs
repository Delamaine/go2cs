//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using net = go.net_package;
using http = go.net.http_package;
using url = go.net.url_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httputil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct failureToReadBody
        {
            // Constructors
            public failureToReadBody(NilType _)
            {
            }
            // Enable comparisons between nil and failureToReadBody struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(failureToReadBody value, NilType nil) => value.Equals(default(failureToReadBody));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(failureToReadBody value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, failureToReadBody value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, failureToReadBody value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator failureToReadBody(NilType nil) => default(failureToReadBody);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static failureToReadBody failureToReadBody_cast(dynamic value)
        {
            return new failureToReadBody();
        }
    }
}}}