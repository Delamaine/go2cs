//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:59:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct f
        {
            // Value of the f struct
            private readonly long m_value;

            public f(long value) => m_value = value;

            // Enable implicit conversions between long and f struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator f(long value) => new f(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(f value) => value.m_value;
            
            // Enable comparisons between nil and f struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(f value, NilType nil) => value.Equals(default(f));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(f value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, f value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, f value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator f(NilType nil) => default(f);
        }
    }
}
