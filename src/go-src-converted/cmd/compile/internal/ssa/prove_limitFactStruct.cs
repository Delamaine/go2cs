//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:54:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using math = go.math_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct limitFact
        {
            // Constructors
            public limitFact(NilType _)
            {
                this.vid = default;
                this.limit = default;
            }

            public limitFact(ID vid = default, limit limit = default)
            {
                this.vid = vid;
                this.limit = limit;
            }

            // Enable comparisons between nil and limitFact struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(limitFact value, NilType nil) => value.Equals(default(limitFact));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(limitFact value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, limitFact value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, limitFact value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator limitFact(NilType nil) => default(limitFact);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static limitFact limitFact_cast(dynamic value)
        {
            return new limitFact(value.vid, value.limit);
        }
    }
}}}}