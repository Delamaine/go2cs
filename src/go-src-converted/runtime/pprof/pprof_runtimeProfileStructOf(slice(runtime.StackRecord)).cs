//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct runtimeProfile
        {
            // Value of the runtimeProfile struct
            private readonly slice<runtime.StackRecord> m_value;

            public runtimeProfile(slice<runtime.StackRecord> value) => m_value = value;

            // Enable implicit conversions between slice<runtime.StackRecord> and runtimeProfile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator runtimeProfile(slice<runtime.StackRecord> value) => new runtimeProfile(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<runtime.StackRecord>(runtimeProfile value) => value.m_value;
            
            // Enable comparisons between nil and runtimeProfile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(runtimeProfile value, NilType nil) => value.Equals(default(runtimeProfile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(runtimeProfile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, runtimeProfile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, runtimeProfile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator runtimeProfile(NilType nil) => default(runtimeProfile);
        }
    }
}}
