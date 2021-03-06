//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using list = go.container.list_package;
using crypto = go.crypto_package;
using cipherhw = go.crypto.@internal.cipherhw_package;
using rand = go.crypto.rand_package;
using sha512 = go.crypto.sha512_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using big = go.math.big_package;
using net = go.net_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ConnectionState
        {
            // Constructors
            public ConnectionState(NilType _)
            {
                this.Version = default;
                this.HandshakeComplete = default;
                this.DidResume = default;
                this.CipherSuite = default;
                this.NegotiatedProtocol = default;
                this.NegotiatedProtocolIsMutual = default;
                this.ServerName = default;
                this.PeerCertificates = default;
                this.VerifiedChains = default;
                this.SignedCertificateTimestamps = default;
                this.OCSPResponse = default;
                this.TLSUnique = default;
            }

            public ConnectionState(ushort Version = default, bool HandshakeComplete = default, bool DidResume = default, ushort CipherSuite = default, @string NegotiatedProtocol = default, bool NegotiatedProtocolIsMutual = default, @string ServerName = default, slice<ref x509.Certificate> PeerCertificates = default, slice<slice<ref x509.Certificate>> VerifiedChains = default, slice<slice<byte>> SignedCertificateTimestamps = default, slice<byte> OCSPResponse = default, slice<byte> TLSUnique = default)
            {
                this.Version = Version;
                this.HandshakeComplete = HandshakeComplete;
                this.DidResume = DidResume;
                this.CipherSuite = CipherSuite;
                this.NegotiatedProtocol = NegotiatedProtocol;
                this.NegotiatedProtocolIsMutual = NegotiatedProtocolIsMutual;
                this.ServerName = ServerName;
                this.PeerCertificates = PeerCertificates;
                this.VerifiedChains = VerifiedChains;
                this.SignedCertificateTimestamps = SignedCertificateTimestamps;
                this.OCSPResponse = OCSPResponse;
                this.TLSUnique = TLSUnique;
            }

            // Enable comparisons between nil and ConnectionState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ConnectionState value, NilType nil) => value.Equals(default(ConnectionState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ConnectionState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ConnectionState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ConnectionState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ConnectionState(NilType nil) => default(ConnectionState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ConnectionState ConnectionState_cast(dynamic value)
        {
            return new ConnectionState(value.Version, value.HandshakeComplete, value.DidResume, value.CipherSuite, value.NegotiatedProtocol, value.NegotiatedProtocolIsMutual, value.ServerName, value.PeerCertificates, value.VerifiedChains, value.SignedCertificateTimestamps, value.OCSPResponse, value.TLSUnique);
        }
    }
}}