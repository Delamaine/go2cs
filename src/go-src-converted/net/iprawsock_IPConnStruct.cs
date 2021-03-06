//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:26:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using syscall = go.syscall_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(conn))]
        public partial struct IPConn
        {
            // conn structure promotion - sourced from value copy
            private readonly ptr<conn> m_connRef;

            private ref conn conn_val => ref m_connRef.Value;

            public ref ptr<byteq> rd => ref m_connRef.Value.rd;

            public ref ptr<byteq> wr => ref m_connRef.Value.wr;

            public ref addr local => ref m_connRef.Value.local;

            public ref addr remote => ref m_connRef.Value.remote;

            // Constructors
            public IPConn(NilType _)
            {
                this.m_connRef = new ptr<conn>(new conn(nil));
            }

            public IPConn(conn conn = default)
            {
                this.m_connRef = new ptr<conn>(conn);
            }

            // Enable comparisons between nil and IPConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPConn value, NilType nil) => value.Equals(default(IPConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPConn(NilType nil) => default(IPConn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPConn IPConn_cast(dynamic value)
        {
            return new IPConn(value.conn);
        }
    }
}