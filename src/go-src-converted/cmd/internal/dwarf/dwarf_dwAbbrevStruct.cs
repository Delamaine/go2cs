//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:51:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class dwarf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dwAbbrev
        {
            // Constructors
            public dwAbbrev(NilType _)
            {
                this.tag = default;
                this.children = default;
                this.attr = default;
            }

            public dwAbbrev(byte tag = default, byte children = default, slice<dwAttrForm> attr = default)
            {
                this.tag = tag;
                this.children = children;
                this.attr = attr;
            }

            // Enable comparisons between nil and dwAbbrev struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dwAbbrev value, NilType nil) => value.Equals(default(dwAbbrev));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dwAbbrev value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dwAbbrev value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dwAbbrev value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dwAbbrev(NilType nil) => default(dwAbbrev);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dwAbbrev dwAbbrev_cast(dynamic value)
        {
            return new dwAbbrev(value.tag, value.children, value.attr);
        }
    }
}}}