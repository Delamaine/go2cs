//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct treapNode
        {
            // Constructors
            public treapNode(NilType _)
            {
                this.right = default;
                this.left = default;
                this.parent = default;
                this.npagesKey = default;
                this.spanKey = default;
                this.priority = default;
            }

            public treapNode(ref ptr<treapNode> right = default, ref ptr<treapNode> left = default, ref ptr<treapNode> parent = default, System.UIntPtr npagesKey = default, ref ptr<mspan> spanKey = default, uint priority = default)
            {
                this.right = right;
                this.left = left;
                this.parent = parent;
                this.npagesKey = npagesKey;
                this.spanKey = spanKey;
                this.priority = priority;
            }

            // Enable comparisons between nil and treapNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(treapNode value, NilType nil) => value.Equals(default(treapNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(treapNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, treapNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, treapNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator treapNode(NilType nil) => default(treapNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static treapNode treapNode_cast(dynamic value)
        {
            return new treapNode(ref value.right, ref value.left, ref value.parent, value.npagesKey, ref value.spanKey, value.priority);
        }
    }
}