//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class strings_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byteStringReplacer
        {
            // Value of the byteStringReplacer struct
            private readonly array<slice<byte>> m_value;

            public byteStringReplacer(array<slice<byte>> value) => m_value = value;

            // Enable implicit conversions between array<slice<byte>> and byteStringReplacer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byteStringReplacer(array<slice<byte>> value) => new byteStringReplacer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<slice<byte>>(byteStringReplacer value) => value.m_value;
            
            // Enable comparisons between nil and byteStringReplacer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byteStringReplacer value, NilType nil) => value.Equals(default(byteStringReplacer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byteStringReplacer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byteStringReplacer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byteStringReplacer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byteStringReplacer(NilType nil) => default(byteStringReplacer);
        }
    }
}
