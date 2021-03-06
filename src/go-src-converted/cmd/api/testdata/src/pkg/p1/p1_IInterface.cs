//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ptwo = go.p2_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface I
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static I As<T>(in T target) => (I<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static I As<T>(ptr<T> target_ptr) => (I<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static I? As(object target) =>
                typeof(I<>).CreateInterfaceHandler<I>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class I<T> : I
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

            public I(in T target) => m_target = target;

            public I(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate long SetByRef(ref T value, @string name, long balance);
            private delegate long SetByVal(T value, @string name, long balance);

            private static readonly SetByRef s_SetByRef;
            private static readonly SetByVal s_SetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Set(@string name, long balance)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_SetByRef is null)
                    return s_SetByVal!(target, name, balance);

                return s_SetByRef(ref target, name, balance);
            }

            private delegate long GetByRef(ref T value, @string _p0);
            private delegate long GetByVal(T value, @string _p0);

            private static readonly GetByRef s_GetByRef;
            private static readonly GetByVal s_GetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long Get(@string _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_GetByRef is null)
                    return s_GetByVal!(target, _p0);

                return s_GetByRef(ref target, _p0);
            }

            private delegate long GetNamedByRef(ref T value, @string _p0);
            private delegate long GetNamedByVal(T value, @string _p0);

            private static readonly GetNamedByRef s_GetNamedByRef;
            private static readonly GetNamedByVal s_GetNamedByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long GetNamed(@string _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_GetNamedByRef is null)
                    return s_GetNamedByVal!(target, _p0);

                return s_GetNamedByRef(ref target, _p0);
            }

            private delegate long privateByRef(ref T value);
            private delegate long privateByVal(T value);

            private static readonly privateByRef s_privateByRef;
            private static readonly privateByVal s_privateByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public long private()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_privateByRef is null)
                    return s_privateByVal!(target);

                return s_privateByRef(ref target);
            }

            private delegate @string NameByRef(ref T value);
            private delegate @string NameByVal(T value);

            private static readonly NameByRef s_NameByRef;
            private static readonly NameByVal s_NameByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Name()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_NameByRef is null)
                    return s_NameByVal!(target);

                return s_NameByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static I()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Set");

                if (!(extensionMethod is null))
                    s_SetByRef = extensionMethod.CreateStaticDelegate(typeof(SetByRef)) as SetByRef;

                if (s_SetByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Set");

                    if (!(extensionMethod is null))
                        s_SetByVal = extensionMethod.CreateStaticDelegate(typeof(SetByVal)) as SetByVal;
                }

                if (s_SetByRef is null && s_SetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement I.Set method", new Exception("Set"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Get");

                if (!(extensionMethod is null))
                    s_GetByRef = extensionMethod.CreateStaticDelegate(typeof(GetByRef)) as GetByRef;

                if (s_GetByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Get");

                    if (!(extensionMethod is null))
                        s_GetByVal = extensionMethod.CreateStaticDelegate(typeof(GetByVal)) as GetByVal;
                }

                if (s_GetByRef is null && s_GetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement I.Get method", new Exception("Get"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("GetNamed");

                if (!(extensionMethod is null))
                    s_GetNamedByRef = extensionMethod.CreateStaticDelegate(typeof(GetNamedByRef)) as GetNamedByRef;

                if (s_GetNamedByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("GetNamed");

                    if (!(extensionMethod is null))
                        s_GetNamedByVal = extensionMethod.CreateStaticDelegate(typeof(GetNamedByVal)) as GetNamedByVal;
                }

                if (s_GetNamedByRef is null && s_GetNamedByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement I.GetNamed method", new Exception("GetNamed"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("private");

                if (!(extensionMethod is null))
                    s_privateByRef = extensionMethod.CreateStaticDelegate(typeof(privateByRef)) as privateByRef;

                if (s_privateByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("private");

                    if (!(extensionMethod is null))
                        s_privateByVal = extensionMethod.CreateStaticDelegate(typeof(privateByVal)) as privateByVal;
                }

                if (s_privateByRef is null && s_privateByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement I.private method", new Exception("private"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Name");

                if (!(extensionMethod is null))
                    s_NameByRef = extensionMethod.CreateStaticDelegate(typeof(NameByRef)) as NameByRef;

                if (s_NameByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Name");

                    if (!(extensionMethod is null))
                        s_NameByVal = extensionMethod.CreateStaticDelegate(typeof(NameByVal)) as NameByVal;
                }

                if (s_NameByRef is null && s_NameByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement I.Name method", new Exception("Name"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator I<T>(in ptr<T> target_ptr) => new I<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator I<T>(in T target) => new I<T>(target);

            // Enable comparisons between nil and I<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(I<T> value, NilType nil) => Activator.CreateInstance<I<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(I<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, I<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, I<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class p1_IExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.api.testdata.src.pkg.p1_package.I target)
        {
            try
            {
                return ((go.cmd.api.testdata.src.pkg.p1_package.I<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.api.testdata.src.pkg.p1_package.I target, out T result)
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
        public static object? _(this go.cmd.api.testdata.src.pkg.p1_package.I target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.api.testdata.src.pkg.p1_package.I<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.api.testdata.src.pkg.p1_package.I target, Type type, out object? result)
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