//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:54:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct auxType
        {
            // Value of the auxType struct
            private readonly sbyte m_value;

            public auxType(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and auxType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator auxType(sbyte value) => new auxType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(auxType value) => value.m_value;
            
            // Enable comparisons between nil and auxType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(auxType value, NilType nil) => value.Equals(default(auxType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(auxType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, auxType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, auxType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator auxType(NilType nil) => default(auxType);
        }
    }
}}}}