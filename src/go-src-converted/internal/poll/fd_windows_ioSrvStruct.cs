//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using race = go.@internal.race_package;
using windows = go.@internal.syscall.windows_package;
using io = go.io_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using utf16 = go.unicode.utf16_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ioSrv
        {
            // Constructors
            public ioSrv(NilType _)
            {
                this.req = default;
            }

            public ioSrv(channel<ioSrvReq> req = default)
            {
                this.req = req;
            }

            // Enable comparisons between nil and ioSrv struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ioSrv value, NilType nil) => value.Equals(default(ioSrv));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ioSrv value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ioSrv value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ioSrv value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ioSrv(NilType nil) => default(ioSrv);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ioSrv ioSrv_cast(dynamic value)
        {
            return new ioSrv(value.req);
        }
    }
}}