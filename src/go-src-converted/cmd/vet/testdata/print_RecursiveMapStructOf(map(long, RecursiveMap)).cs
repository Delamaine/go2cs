//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RecursiveMap
        {
            // Value of the RecursiveMap struct
            private readonly map<long, RecursiveMap> m_value;

            public RecursiveMap(map<long, RecursiveMap> value) => m_value = value;

            // Enable implicit conversions between map<long, RecursiveMap> and RecursiveMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecursiveMap(map<long, RecursiveMap> value) => new RecursiveMap(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<long, RecursiveMap>(RecursiveMap value) => value.m_value;
            
            // Enable comparisons between nil and RecursiveMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RecursiveMap value, NilType nil) => value.Equals(default(RecursiveMap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RecursiveMap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RecursiveMap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RecursiveMap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecursiveMap(NilType nil) => default(RecursiveMap);
        }
    }
}}}
