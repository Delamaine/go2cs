//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:26:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dnsHeader
        {
            // Constructors
            public dnsHeader(NilType _)
            {
                this.Id = default;
                this.Bits = default;
                this.Qdcount = default;
                this.Ancount = default;
                this.Nscount = default;
                this.Arcount = default;
            }

            public dnsHeader(ushort Id = default, ushort Bits = default, ushort Qdcount = default, ushort Ancount = default, ushort Nscount = default, ushort Arcount = default)
            {
                this.Id = Id;
                this.Bits = Bits;
                this.Qdcount = Qdcount;
                this.Ancount = Ancount;
                this.Nscount = Nscount;
                this.Arcount = Arcount;
            }

            // Enable comparisons between nil and dnsHeader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dnsHeader value, NilType nil) => value.Equals(default(dnsHeader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dnsHeader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dnsHeader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dnsHeader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dnsHeader(NilType nil) => default(dnsHeader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dnsHeader dnsHeader_cast(dynamic value)
        {
            return new dnsHeader(value.Id, value.Bits, value.Qdcount, value.Ancount, value.Nscount, value.Arcount);
        }
    }
}