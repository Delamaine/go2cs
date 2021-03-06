//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using fmt = go.fmt_package;
using io = go.io_package;
using exec = go.os.exec_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class binutils_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface lineReaderWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static lineReaderWriter As<T>(in T target) => (lineReaderWriter<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static lineReaderWriter As<T>(ptr<T> target_ptr) => (lineReaderWriter<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static lineReaderWriter? As(object target) =>
                typeof(lineReaderWriter<>).CreateInterfaceHandler<lineReaderWriter>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class lineReaderWriter<T> : lineReaderWriter
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public lineReaderWriter(in T target) => m_target = target;

            public lineReaderWriter(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (@string, error) writeByRef(ref T value, @string _p0);
            private delegate (@string, error) writeByVal(T value, @string _p0);

            private static readonly writeByRef s_writeByRef;
            private static readonly writeByVal s_writeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (@string, error) write(@string _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_writeByRef is null)
                    return s_writeByVal!(target, _p0);

                return s_writeByRef(ref target, _p0);
            }

            private delegate (@string, error) readLineByRef(ref T value);
            private delegate (@string, error) readLineByVal(T value);

            private static readonly readLineByRef s_readLineByRef;
            private static readonly readLineByVal s_readLineByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (@string, error) readLine()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_readLineByRef is null)
                    return s_readLineByVal!(target);

                return s_readLineByRef(ref target);
            }

            private delegate (@string, error) closeByRef(ref T value);
            private delegate (@string, error) closeByVal(T value);

            private static readonly closeByRef s_closeByRef;
            private static readonly closeByVal s_closeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (@string, error) close()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_closeByRef is null)
                    return s_closeByVal!(target);

                return s_closeByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static lineReaderWriter()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("write");

                if (!(extensionMethod is null))
                    s_writeByRef = extensionMethod.CreateStaticDelegate(typeof(writeByRef)) as writeByRef;

                if (s_writeByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("write");

                    if (!(extensionMethod is null))
                        s_writeByVal = extensionMethod.CreateStaticDelegate(typeof(writeByVal)) as writeByVal;
                }

                if (s_writeByRef is null && s_writeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement lineReaderWriter.write method", new Exception("write"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("readLine");

                if (!(extensionMethod is null))
                    s_readLineByRef = extensionMethod.CreateStaticDelegate(typeof(readLineByRef)) as readLineByRef;

                if (s_readLineByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("readLine");

                    if (!(extensionMethod is null))
                        s_readLineByVal = extensionMethod.CreateStaticDelegate(typeof(readLineByVal)) as readLineByVal;
                }

                if (s_readLineByRef is null && s_readLineByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement lineReaderWriter.readLine method", new Exception("readLine"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("close");

                if (!(extensionMethod is null))
                    s_closeByRef = extensionMethod.CreateStaticDelegate(typeof(closeByRef)) as closeByRef;

                if (s_closeByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("close");

                    if (!(extensionMethod is null))
                        s_closeByVal = extensionMethod.CreateStaticDelegate(typeof(closeByVal)) as closeByVal;
                }

                if (s_closeByRef is null && s_closeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement lineReaderWriter.close method", new Exception("close"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator lineReaderWriter<T>(in ptr<T> target_ptr) => new lineReaderWriter<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator lineReaderWriter<T>(in T target) => new lineReaderWriter<T>(target);

            // Enable comparisons between nil and lineReaderWriter<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lineReaderWriter<T> value, NilType nil) => Activator.CreateInstance<lineReaderWriter<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lineReaderWriter<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lineReaderWriter<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lineReaderWriter<T> value) => value != nil;
        }
    }
}}}}}}}

namespace go
{
    public static class binutils_lineReaderWriterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.github.com.google.pprof.@internal.binutils_package.lineReaderWriter target)
        {
            try
            {
                return ((go.cmd.vendor.github.com.google.pprof.@internal.binutils_package.lineReaderWriter<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.github.com.google.pprof.@internal.binutils_package.lineReaderWriter target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.cmd.vendor.github.com.google.pprof.@internal.binutils_package.lineReaderWriter target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.github.com.google.pprof.@internal.binutils_package.lineReaderWriter<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.cmd.vendor.github.com.google.pprof.@internal.binutils_package.lineReaderWriter target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}