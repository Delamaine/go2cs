//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using hash = go.hash_package;
using crc32 = go.hash.crc32_package;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct header
        {
            // Constructors
            public header(NilType _)
            {
                this.FileHeader = default;
                this.offset = default;
            }

            public header(ref FileHeader FileHeader = default, ulong offset = default)
            {
                this.FileHeader = FileHeader;
                this.offset = offset;
            }

            // Enable comparisons between nil and header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(header value, NilType nil) => value.Equals(default(header));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(header value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, header value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, header value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator header(NilType nil) => default(header);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static header header_cast(dynamic value)
        {
            return new header(ref value.FileHeader, value.offset);
        }
    }
}}