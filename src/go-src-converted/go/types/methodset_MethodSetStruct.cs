//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using go;

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MethodSet
        {
            // Constructors
            public MethodSet(NilType _)
            {
                this.list = default;
            }

            public MethodSet(slice<ref Selection> list = default)
            {
                this.list = list;
            }

            // Enable comparisons between nil and MethodSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MethodSet value, NilType nil) => value.Equals(default(MethodSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MethodSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MethodSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MethodSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MethodSet(NilType nil) => default(MethodSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MethodSet MethodSet_cast(dynamic value)
        {
            return new MethodSet(value.list);
        }
    }
}}