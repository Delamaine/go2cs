//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface MethodTestInterface
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static MethodTestInterface As<T>(in T target) => (MethodTestInterface<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static MethodTestInterface As<T>(ptr<T> target_ptr) => (MethodTestInterface<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static MethodTestInterface? As(object target) =>
                typeof(MethodTestInterface<>).CreateInterfaceHandler<MethodTestInterface>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class MethodTestInterface<T> : MethodTestInterface
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

            public MethodTestInterface(in T target) => m_target = target;

            public MethodTestInterface(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate byte ReadByteByRef(ref T value);
            private delegate byte ReadByteByVal(T value);

            private static readonly ReadByteByRef s_ReadByteByRef;
            private static readonly ReadByteByVal s_ReadByteByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public byte ReadByte()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadByteByRef is null)
                    return s_ReadByteByVal!(target);

                return s_ReadByteByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static MethodTestInterface()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ReadByte");

                if (!(extensionMethod is null))
                    s_ReadByteByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByteByRef)) as ReadByteByRef;

                if (s_ReadByteByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ReadByte");

                    if (!(extensionMethod is null))
                        s_ReadByteByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByteByVal)) as ReadByteByVal;
                }

                if (s_ReadByteByRef is null && s_ReadByteByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement MethodTestInterface.ReadByte method", new Exception("ReadByte"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator MethodTestInterface<T>(in ptr<T> target_ptr) => new MethodTestInterface<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator MethodTestInterface<T>(in T target) => new MethodTestInterface<T>(target);

            // Enable comparisons between nil and MethodTestInterface<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MethodTestInterface<T> value, NilType nil) => Activator.CreateInstance<MethodTestInterface<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MethodTestInterface<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MethodTestInterface<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MethodTestInterface<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class testdata_MethodTestInterfaceExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vet.testdata_package.MethodTestInterface target)
        {
            try
            {
                return ((go.cmd.vet.testdata_package.MethodTestInterface<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vet.testdata_package.MethodTestInterface target, out T result)
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
        public static object? _(this go.cmd.vet.testdata_package.MethodTestInterface target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vet.testdata_package.MethodTestInterface<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vet.testdata_package.MethodTestInterface target, Type type, out object? result)
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