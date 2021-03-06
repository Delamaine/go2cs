//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(queue))]
        private partial struct msgq
        {
            // queue structure promotion - sourced from value copy
            private readonly ptr<queue> m_queueRef;

            private ref queue queue_val => ref m_queueRef.Value;

            public ref sync.Cond canRead => ref m_queueRef.Value.canRead;

            public ref sync.Cond canWrite => ref m_queueRef.Value.canWrite;

            public ref ptr<timer> rtimer => ref m_queueRef.Value.rtimer;

            public ref ptr<timer> wtimer => ref m_queueRef.Value.wtimer;

            public ref long r => ref m_queueRef.Value.r;

            public ref long w => ref m_queueRef.Value.w;

            public ref long m => ref m_queueRef.Value.m;

            public ref bool closed => ref m_queueRef.Value.closed;

            // Constructors
            public msgq(NilType _)
            {
                this.m_queueRef = new ptr<queue>(new queue(nil));
                this.data = default;
            }

            public msgq(queue queue = default, slice<object> data = default)
            {
                this.m_queueRef = new ptr<queue>(queue);
                this.data = data;
            }

            // Enable comparisons between nil and msgq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(msgq value, NilType nil) => value.Equals(default(msgq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(msgq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, msgq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, msgq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator msgq(NilType nil) => default(msgq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static msgq msgq_cast(dynamic value)
        {
            return new msgq(value.queue, value.data);
        }
    }
}