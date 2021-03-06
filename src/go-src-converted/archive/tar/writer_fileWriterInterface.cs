//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using path = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface fileWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileWriter As<T>(in T target) => (fileWriter<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileWriter As<T>(ptr<T> target_ptr) => (fileWriter<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileWriter? As(object target) =>
                typeof(fileWriter<>).CreateInterfaceHandler<fileWriter>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class fileWriter<T> : fileWriter
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

            public fileWriter(in T target) => m_target = target;

            public fileWriter(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) ReadFromByRef(ref T value, io.Reader _p0);
            private delegate (long, error) ReadFromByVal(T value, io.Reader _p0);

            private static readonly ReadFromByRef s_ReadFromByRef;
            private static readonly ReadFromByVal s_ReadFromByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) ReadFrom(io.Reader _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadFromByRef is null)
                    return s_ReadFromByVal!(target, _p0);

                return s_ReadFromByRef(ref target, _p0);
            }

            private delegate (long, error) WriteByRef(ref T value, slice<byte> p);
            private delegate (long, error) WriteByVal(T value, slice<byte> p);

            private static readonly WriteByRef s_WriteByRef;
            private static readonly WriteByVal s_WriteByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Write(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_WriteByRef is null)
                    return s_WriteByVal!(target, p);

                return s_WriteByRef(ref target, p);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static fileWriter()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ReadFrom");

                if (!(extensionMethod is null))
                    s_ReadFromByRef = extensionMethod.CreateStaticDelegate(typeof(ReadFromByRef)) as ReadFromByRef;

                if (s_ReadFromByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ReadFrom");

                    if (!(extensionMethod is null))
                        s_ReadFromByVal = extensionMethod.CreateStaticDelegate(typeof(ReadFromByVal)) as ReadFromByVal;
                }

                if (s_ReadFromByRef is null && s_ReadFromByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement fileWriter.ReadFrom method", new Exception("ReadFrom"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Write");

                if (!(extensionMethod is null))
                    s_WriteByRef = extensionMethod.CreateStaticDelegate(typeof(WriteByRef)) as WriteByRef;

                if (s_WriteByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Write");

                    if (!(extensionMethod is null))
                        s_WriteByVal = extensionMethod.CreateStaticDelegate(typeof(WriteByVal)) as WriteByVal;
                }

                if (s_WriteByRef is null && s_WriteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement fileWriter.Write method", new Exception("Write"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator fileWriter<T>(in ptr<T> target_ptr) => new fileWriter<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator fileWriter<T>(in T target) => new fileWriter<T>(target);

            // Enable comparisons between nil and fileWriter<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileWriter<T> value, NilType nil) => Activator.CreateInstance<fileWriter<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileWriter<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileWriter<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileWriter<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class tar_fileWriterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.archive.tar_package.fileWriter target)
        {
            try
            {
                return ((go.archive.tar_package.fileWriter<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.archive.tar_package.fileWriter target, out T result)
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
        public static object? _(this go.archive.tar_package.fileWriter target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.archive.tar_package.fileWriter<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.archive.tar_package.fileWriter target, Type type, out object? result)
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