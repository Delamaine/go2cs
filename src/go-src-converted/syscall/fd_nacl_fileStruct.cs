//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using sync = go.sync_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct file
        {
            // Constructors
            public file(NilType _)
            {
                this.fdref = default;
                this.impl = default;
            }

            public file(long fdref = default, fileImpl impl = default)
            {
                this.fdref = fdref;
                this.impl = impl;
            }

            // Enable comparisons between nil and file struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(file value, NilType nil) => value.Equals(default(file));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(file value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, file value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, file value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator file(NilType nil) => default(file);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static file file_cast(dynamic value)
        {
            return new file(value.fdref, value.impl);
        }
    }
}