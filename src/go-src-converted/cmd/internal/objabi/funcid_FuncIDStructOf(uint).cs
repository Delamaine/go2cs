//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objabi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncID
        {
            // Value of the FuncID struct
            private readonly uint m_value;

            public FuncID(uint value) => m_value = value;

            // Enable implicit conversions between uint and FuncID struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncID(uint value) => new FuncID(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(FuncID value) => value.m_value;
            
            // Enable comparisons between nil and FuncID struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncID value, NilType nil) => value.Equals(default(FuncID));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncID value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncID value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncID value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncID(NilType nil) => default(FuncID);
        }
    }
}}}
