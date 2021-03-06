//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:28:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using des = go.crypto.des_package;
using hmac = go.crypto.hmac_package;
using rc4 = go.crypto.rc4_package;
using sha1 = go.crypto.sha1_package;
using sha256 = go.crypto.sha256_package;
using x509 = go.crypto.x509_package;
using hash = go.hash_package;
using chacha20poly1305 = go.golang_org.x.crypto.chacha20poly1305_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ssl30MAC
        {
            // Constructors
            public ssl30MAC(NilType _)
            {
                this.h = default;
                this.key = default;
            }

            public ssl30MAC(hash.Hash h = default, slice<byte> key = default)
            {
                this.h = h;
                this.key = key;
            }

            // Enable comparisons between nil and ssl30MAC struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ssl30MAC value, NilType nil) => value.Equals(default(ssl30MAC));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ssl30MAC value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ssl30MAC value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ssl30MAC value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ssl30MAC(NilType nil) => default(ssl30MAC);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ssl30MAC ssl30MAC_cast(dynamic value)
        {
            return new ssl30MAC(value.h, value.key);
        }
    }
}}