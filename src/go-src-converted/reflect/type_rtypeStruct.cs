//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rtype
        {
            // Constructors
            public rtype(NilType _)
            {
                this.size = default;
                this.ptrdata = default;
                this.hash = default;
                this.tflag = default;
                this.align = default;
                this.fieldAlign = default;
                this.kind = default;
                this.alg = default;
                this.gcdata = default;
                this.str = default;
                this.ptrToThis = default;
            }

            public rtype(System.UIntPtr size = default, System.UIntPtr ptrdata = default, uint hash = default, tflag tflag = default, byte align = default, byte fieldAlign = default, byte kind = default, ref ptr<typeAlg> alg = default, ref ptr<byte> gcdata = default, nameOff str = default, typeOff ptrToThis = default)
            {
                this.size = size;
                this.ptrdata = ptrdata;
                this.hash = hash;
                this.tflag = tflag;
                this.align = align;
                this.fieldAlign = fieldAlign;
                this.kind = kind;
                this.alg = alg;
                this.gcdata = gcdata;
                this.str = str;
                this.ptrToThis = ptrToThis;
            }

            // Enable comparisons between nil and rtype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rtype value, NilType nil) => value.Equals(default(rtype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rtype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rtype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rtype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rtype(NilType nil) => default(rtype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rtype rtype_cast(dynamic value)
        {
            return new rtype(value.size, value.ptrdata, value.hash, value.tflag, value.align, value.fieldAlign, value.kind, ref value.alg, ref value.gcdata, value.str, value.ptrToThis);
        }
    }
}