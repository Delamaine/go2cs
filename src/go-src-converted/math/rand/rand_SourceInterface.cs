//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace math
{
    public static partial class rand_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Source
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Source As<T>(in T target) => (Source<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Source As<T>(ptr<T> target_ptr) => (Source<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Source? As(object target) =>
                typeof(Source<>).CreateInterfaceHandler<Source>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Source<T> : Source
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

            public Source(in T target) => m_target = target;

            public Source(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate long Int63ByRef(ref T value);
            private delegate long Int63ByVal(T value);

            private static readonly Int63ByRef s_Int63ByRef;
            private static readonly Int63ByVal s_Int63ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Int63()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_Int63ByRef is null)
                    return s_Int63ByVal!(target);

                return s_Int63ByRef(ref target);
            }

            private delegate long SeedByRef(ref T value, long seed);
            private delegate long SeedByVal(T value, long seed);

            private static readonly SeedByRef s_SeedByRef;
            private static readonly SeedByVal s_SeedByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Seed(long seed)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_SeedByRef is null)
                    return s_SeedByVal!(target, seed);

                return s_SeedByRef(ref target, seed);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Source()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Int63");

                if (!(extensionMethod is null))
                    s_Int63ByRef = extensionMethod.CreateStaticDelegate(typeof(Int63ByRef)) as Int63ByRef;

                if (s_Int63ByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Int63");

                    if (!(extensionMethod is null))
                        s_Int63ByVal = extensionMethod.CreateStaticDelegate(typeof(Int63ByVal)) as Int63ByVal;
                }

                if (s_Int63ByRef is null && s_Int63ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Source.Int63 method", new Exception("Int63"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Seed");

                if (!(extensionMethod is null))
                    s_SeedByRef = extensionMethod.CreateStaticDelegate(typeof(SeedByRef)) as SeedByRef;

                if (s_SeedByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Seed");

                    if (!(extensionMethod is null))
                        s_SeedByVal = extensionMethod.CreateStaticDelegate(typeof(SeedByVal)) as SeedByVal;
                }

                if (s_SeedByRef is null && s_SeedByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Source.Seed method", new Exception("Seed"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Source<T>(in ptr<T> target_ptr) => new Source<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Source<T>(in T target) => new Source<T>(target);

            // Enable comparisons between nil and Source<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Source<T> value, NilType nil) => Activator.CreateInstance<Source<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Source<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Source<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Source<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class rand_SourceExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.math.rand_package.Source target)
        {
            try
            {
                return ((go.math.rand_package.Source<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.math.rand_package.Source target, out T result)
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
        public static object? _(this go.math.rand_package.Source target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.math.rand_package.Source<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.math.rand_package.Source target, Type type, out object? result)
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