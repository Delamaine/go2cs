//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using xml = go.encoding.xml_package;
using go;

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(UnexportedEncodingTagTest))]
        [PromotedStruct(typeof(unexp))]
        public partial struct JSONEmbeddedField
        {
            // UnexportedEncodingTagTest structure promotion - sourced from value copy
            private readonly ptr<UnexportedEncodingTagTest> m_UnexportedEncodingTagTestRef;

            private ref UnexportedEncodingTagTest UnexportedEncodingTagTest_val => ref m_UnexportedEncodingTagTestRef.Value;

            public ref long x => ref m_UnexportedEncodingTagTestRef.Value.x;

            public ref long y => ref m_UnexportedEncodingTagTestRef.Value.y;

            public ref long z => ref m_UnexportedEncodingTagTestRef.Value.z;

            public ref long A => ref m_UnexportedEncodingTagTestRef.Value.A;

            // unexp structure promotion - sourced from value copy
            private readonly ptr<unexp> m_unexpRef;

            private ref unexp unexp_val => ref m_unexpRef.Value;

            // Constructors
            public JSONEmbeddedField(NilType _)
            {
                this.m_UnexportedEncodingTagTestRef = new ptr<UnexportedEncodingTagTest>(new UnexportedEncodingTagTest(nil));
                this.m_unexpRef = new ptr<unexp>(new unexp(nil));
            }

            public JSONEmbeddedField(UnexportedEncodingTagTest UnexportedEncodingTagTest = default, unexp unexp = default)
            {
                this.m_UnexportedEncodingTagTestRef = new ptr<UnexportedEncodingTagTest>(UnexportedEncodingTagTest);
                this.m_unexpRef = new ptr<unexp>(unexp);
            }

            // Enable comparisons between nil and JSONEmbeddedField struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(JSONEmbeddedField value, NilType nil) => value.Equals(default(JSONEmbeddedField));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(JSONEmbeddedField value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, JSONEmbeddedField value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, JSONEmbeddedField value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator JSONEmbeddedField(NilType nil) => default(JSONEmbeddedField);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static JSONEmbeddedField JSONEmbeddedField_cast(dynamic value)
        {
            return new JSONEmbeddedField(value.UnexportedEncodingTagTest, value.unexp);
        }
    }
}}}