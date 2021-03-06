//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ecdsaSignature
        {
            // Value of the ecdsaSignature struct
            private readonly dsaSignature m_value;

            public ecdsaSignature(dsaSignature value) => m_value = value;

            // Enable implicit conversions between dsaSignature and ecdsaSignature struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ecdsaSignature(dsaSignature value) => new ecdsaSignature(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dsaSignature(ecdsaSignature value) => value.m_value;
            
            // Enable comparisons between nil and ecdsaSignature struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ecdsaSignature value, NilType nil) => value.Equals(default(ecdsaSignature));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ecdsaSignature value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ecdsaSignature value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ecdsaSignature value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ecdsaSignature(NilType nil) => default(ecdsaSignature);
        }
    }
}}
