//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:28 UTC
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
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LitKind
        {
            // Value of the LitKind struct
            private readonly ulong m_value;

            public LitKind(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and LitKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LitKind(ulong value) => new LitKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(LitKind value) => value.m_value;
            
            // Enable comparisons between nil and LitKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LitKind value, NilType nil) => value.Equals(default(LitKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LitKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LitKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LitKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LitKind(NilType nil) => default(LitKind);
        }
    }
}}}}
