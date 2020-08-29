//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface RuneReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RuneReader As<T>(in T target) => (RuneReader<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RuneReader As<T>(ptr<T> target_ptr) => (RuneReader<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RuneReader? As(object target) =>
                typeof(RuneReader<>).CreateInterfaceHandler<RuneReader>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class RuneReader<T> : RuneReader
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

            public RuneReader(in T target) => m_target = target;

            public RuneReader(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (int, long, error) ReadRuneByRef(ref T value);
            private delegate (int, long, error) ReadRuneByVal(T value);

            private static readonly ReadRuneByRef s_ReadRuneByRef;
            private static readonly ReadRuneByVal s_ReadRuneByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (int, long, error) ReadRune()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadRuneByRef is null)
                    return s_ReadRuneByVal!(target);

                return s_ReadRuneByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static RuneReader()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ReadRune");

                if (!(extensionMethod is null))
                    s_ReadRuneByRef = extensionMethod.CreateStaticDelegate(typeof(ReadRuneByRef)) as ReadRuneByRef;

                if (s_ReadRuneByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ReadRune");

                    if (!(extensionMethod is null))
                        s_ReadRuneByVal = extensionMethod.CreateStaticDelegate(typeof(ReadRuneByVal)) as ReadRuneByVal;
                }

                if (s_ReadRuneByRef is null && s_ReadRuneByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RuneReader.ReadRune method", new Exception("ReadRune"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RuneReader<T>(in ptr<T> target_ptr) => new RuneReader<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RuneReader<T>(in T target) => new RuneReader<T>(target);

            // Enable comparisons between nil and RuneReader<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RuneReader<T> value, NilType nil) => Activator.CreateInstance<RuneReader<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RuneReader<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RuneReader<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RuneReader<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class io_RuneReaderExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.io_package.RuneReader target)
        {
            try
            {
                return ((go.io_package.RuneReader<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.io_package.RuneReader target, out T result)
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
        public static object? _(this go.io_package.RuneReader target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.io_package.RuneReader<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.io_package.RuneReader target, Type type, out object? result)
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