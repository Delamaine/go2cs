//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace encoding
{
    public static partial class binary_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encoder
        {
            // Value of the encoder struct
            private readonly coder m_value;

            public encoder(coder value) => m_value = value;

            // Enable implicit conversions between coder and encoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encoder(coder value) => new encoder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator coder(encoder value) => value.m_value;
            
            // Enable comparisons between nil and encoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encoder value, NilType nil) => value.Equals(default(encoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encoder(NilType nil) => default(encoder);
        }
    }
}}
