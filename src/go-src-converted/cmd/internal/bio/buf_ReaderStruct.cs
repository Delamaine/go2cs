//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using log = go.log_package;
using os = go.os_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class bio_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(bufio.Reader))]
        public partial struct Reader
        {
            // Reader structure promotion - sourced from pointer
            private readonly ptr<Reader> m_ReaderRef;

            private ref Reader Reader_ptr => ref m_ReaderRef.Value;

            public ref slice<byte> buf => ref m_ReaderRef.Value.buf;

            public ref io.Reader rd => ref m_ReaderRef.Value.rd;

            public ref long r => ref m_ReaderRef.Value.r;

            public ref long w => ref m_ReaderRef.Value.w;

            public ref error err => ref m_ReaderRef.Value.err;

            public ref long lastByte => ref m_ReaderRef.Value.lastByte;

            public ref long lastRuneSize => ref m_ReaderRef.Value.lastRuneSize;

            // Constructors
            public Reader(NilType _)
            {
                this.f = default;
                this.m_ReaderRef = new ptr<bufio.Reader>(new bufio.Reader(nil));
            }

            public Reader(ref ptr<os.File> f = default, ref bufio.Reader Reader = default)
            {
                this.f = f;
                this.m_ReaderRef = new ptr<bufio.Reader>(ref Reader);
            }

            // Enable comparisons between nil and Reader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reader value, NilType nil) => value.Equals(default(Reader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reader(NilType nil) => default(Reader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Reader Reader_cast(dynamic value)
        {
            return new Reader(ref value.f, ref value.Reader);
        }
    }
}}}