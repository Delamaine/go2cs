//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace image
{
    public static partial class png_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CompressionLevel
        {
            // Value of the CompressionLevel struct
            private readonly long m_value;

            public CompressionLevel(long value) => m_value = value;

            // Enable implicit conversions between long and CompressionLevel struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CompressionLevel(long value) => new CompressionLevel(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(CompressionLevel value) => value.m_value;
            
            // Enable comparisons between nil and CompressionLevel struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CompressionLevel value, NilType nil) => value.Equals(default(CompressionLevel));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CompressionLevel value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CompressionLevel value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CompressionLevel value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CompressionLevel(NilType nil) => default(CompressionLevel);
        }
    }
}}
