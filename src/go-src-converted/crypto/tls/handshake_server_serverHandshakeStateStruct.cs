//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using crypto = go.crypto_package;
using ecdsa = go.crypto.ecdsa_package;
using rsa = go.crypto.rsa_package;
using subtle = go.crypto.subtle_package;
using x509 = go.crypto.x509_package;
using asn1 = go.encoding.asn1_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct serverHandshakeState
        {
            // Constructors
            public serverHandshakeState(NilType _)
            {
                this.c = default;
                this.clientHello = default;
                this.hello = default;
                this.suite = default;
                this.ellipticOk = default;
                this.ecdsaOk = default;
                this.rsaDecryptOk = default;
                this.rsaSignOk = default;
                this.sessionState = default;
                this.finishedHash = default;
                this.masterSecret = default;
                this.certsFromClient = default;
                this.cert = default;
                this.cachedClientHelloInfo = default;
            }

            public serverHandshakeState(ref ptr<Conn> c = default, ref ptr<clientHelloMsg> clientHello = default, ref ptr<serverHelloMsg> hello = default, ref ptr<cipherSuite> suite = default, bool ellipticOk = default, bool ecdsaOk = default, bool rsaDecryptOk = default, bool rsaSignOk = default, ref ptr<sessionState> sessionState = default, finishedHash finishedHash = default, slice<byte> masterSecret = default, slice<slice<byte>> certsFromClient = default, ref ptr<Certificate> cert = default, ref ptr<ClientHelloInfo> cachedClientHelloInfo = default)
            {
                this.c = c;
                this.clientHello = clientHello;
                this.hello = hello;
                this.suite = suite;
                this.ellipticOk = ellipticOk;
                this.ecdsaOk = ecdsaOk;
                this.rsaDecryptOk = rsaDecryptOk;
                this.rsaSignOk = rsaSignOk;
                this.sessionState = sessionState;
                this.finishedHash = finishedHash;
                this.masterSecret = masterSecret;
                this.certsFromClient = certsFromClient;
                this.cert = cert;
                this.cachedClientHelloInfo = cachedClientHelloInfo;
            }

            // Enable comparisons between nil and serverHandshakeState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(serverHandshakeState value, NilType nil) => value.Equals(default(serverHandshakeState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(serverHandshakeState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, serverHandshakeState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, serverHandshakeState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator serverHandshakeState(NilType nil) => default(serverHandshakeState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static serverHandshakeState serverHandshakeState_cast(dynamic value)
        {
            return new serverHandshakeState(ref value.c, ref value.clientHello, ref value.hello, ref value.suite, value.ellipticOk, value.ecdsaOk, value.rsaDecryptOk, value.rsaSignOk, ref value.sessionState, value.finishedHash, value.masterSecret, value.certsFromClient, ref value.cert, ref value.cachedClientHelloInfo);
        }
    }
}}