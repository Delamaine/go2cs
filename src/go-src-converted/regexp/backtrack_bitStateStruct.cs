//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:23:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using syntax = go.regexp.syntax_package;

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bitState
        {
            // Constructors
            public bitState(NilType _)
            {
                this.prog = default;
                this.end = default;
                this.cap = default;
                this.jobs = default;
                this.visited = default;
            }

            public bitState(ref ptr<syntax.Prog> prog = default, long end = default, slice<long> cap = default, slice<job> jobs = default, slice<uint> visited = default)
            {
                this.prog = prog;
                this.end = end;
                this.cap = cap;
                this.jobs = jobs;
                this.visited = visited;
            }

            // Enable comparisons between nil and bitState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bitState value, NilType nil) => value.Equals(default(bitState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bitState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bitState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bitState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitState(NilType nil) => default(bitState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bitState bitState_cast(dynamic value)
        {
            return new bitState(ref value.prog, value.end, value.cap, value.jobs, value.visited);
        }
    }
}