//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace go
{
    public static partial class e_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(U2))]
        public partial struct U3
        {
            // U2 structure promotion - sourced from pointer
            private readonly ptr<U2> m_U2Ref;

            private ref U2 U2_ptr => ref m_U2Ref.Value;

            // Constructors
            public U3(NilType _)
            {
                this.m_U2Ref = new ptr<U2>(new U2(nil));
            }

            public U3(ref U2 U2 = default)
            {
                this.m_U2Ref = new ptr<U2>(ref U2);
            }

            // Enable comparisons between nil and U3 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(U3 value, NilType nil) => value.Equals(default(U3));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(U3 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, U3 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, U3 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator U3(NilType nil) => default(U3);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static U3 U3_cast(dynamic value)
        {
            return new U3(ref value.U2);
        }
    }
}}