//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;

namespace go
{
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct atomicError
        {
            // Constructors
            public atomicError(NilType _)
            {
                this.v = default;
            }

            public atomicError(atomic.Value v = default)
            {
                this.v = v;
            }

            // Enable comparisons between nil and atomicError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(atomicError value, NilType nil) => value.Equals(default(atomicError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(atomicError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, atomicError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, atomicError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator atomicError(NilType nil) => default(atomicError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static atomicError atomicError_cast(dynamic value)
        {
            return new atomicError(value.v);
        }
    }
}