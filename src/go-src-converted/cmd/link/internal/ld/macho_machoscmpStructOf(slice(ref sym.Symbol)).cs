//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:04:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct machoscmp
        {
            // Value of the machoscmp struct
            private readonly slice<ref sym.Symbol> m_value;

            public machoscmp(slice<ref sym.Symbol> value) => m_value = value;

            // Enable implicit conversions between slice<ref sym.Symbol> and machoscmp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machoscmp(slice<ref sym.Symbol> value) => new machoscmp(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ref sym.Symbol>(machoscmp value) => value.m_value;
            
            // Enable comparisons between nil and machoscmp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(machoscmp value, NilType nil) => value.Equals(default(machoscmp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(machoscmp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, machoscmp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, machoscmp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machoscmp(NilType nil) => default(machoscmp);
        }
    }
}}}}