//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:18 UTC
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
using objabi = go.cmd.@internal.objabi_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NativeReader
        {
            // ReaderAt.ReadAt function promotion
            private delegate (long, error) ReadAtByVal(T value, slice<byte> p, long off);
            private delegate (long, error) ReadAtByRef(ref T value, slice<byte> p, long off);

            private static readonly ReadAtByVal s_ReadAtByVal;
            private static readonly ReadAtByRef s_ReadAtByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) ReadAt(slice<byte> p, long off) => s_ReadAtByRef?.Invoke(ref this, p, off) ?? s_ReadAtByVal?.Invoke(this, p, off) ?? ReaderAt?.ReadAt(p, off) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static NativeReader()
            {
                Type targetType = typeof(NativeReader);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("ReadAt");

                if ((object)extensionMethod != null)
                {
                    s_ReadAtByRef = extensionMethod.CreateStaticDelegate(typeof(ReadAtByRef)) as ReadAtByRef;

                    if ((object)s_ReadAtByRef == null)
                        s_ReadAtByVal = extensionMethod.CreateStaticDelegate(typeof(ReadAtByVal)) as ReadAtByVal;
                }
            }

            // Constructors
            public NativeReader(NilType _)
            {
                this.Name = default;
                this.ReaderAt = default;
            }

            public NativeReader(@string Name = default, io.ReaderAt ReaderAt = default)
            {
                this.Name = Name;
                this.ReaderAt = ReaderAt;
            }

            // Enable comparisons between nil and NativeReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NativeReader value, NilType nil) => value.Equals(default(NativeReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NativeReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NativeReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NativeReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NativeReader(NilType nil) => default(NativeReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NativeReader NativeReader_cast(dynamic value)
        {
            return new NativeReader(value.Name, value.ReaderAt);
        }
    }
}}}