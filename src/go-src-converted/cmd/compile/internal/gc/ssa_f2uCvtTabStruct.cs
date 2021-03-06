//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:29:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using html = go.html_package;
using os = go.os_package;
using sort = go.sort_package;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct f2uCvtTab
        {
            // Constructors
            public f2uCvtTab(NilType _)
            {
                this.ltf = default;
                this.cvt2U = default;
                this.subf = default;
                this.or = default;
                this.floatValue = default;
                this.intValue = default;
                this.cutoff = default;
            }

            public f2uCvtTab(ssa.Op ltf = default, ssa.Op cvt2U = default, ssa.Op subf = default, ssa.Op or = default, Func<ref state, ref types.Type, double, ref ssa.Value> floatValue = default, Func<ref state, ref types.Type, long, ref ssa.Value> intValue = default, ulong cutoff = default)
            {
                this.ltf = ltf;
                this.cvt2U = cvt2U;
                this.subf = subf;
                this.or = or;
                this.floatValue = floatValue;
                this.intValue = intValue;
                this.cutoff = cutoff;
            }

            // Enable comparisons between nil and f2uCvtTab struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(f2uCvtTab value, NilType nil) => value.Equals(default(f2uCvtTab));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(f2uCvtTab value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, f2uCvtTab value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, f2uCvtTab value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator f2uCvtTab(NilType nil) => default(f2uCvtTab);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static f2uCvtTab f2uCvtTab_cast(dynamic value)
        {
            return new f2uCvtTab(value.ltf, value.cvt2U, value.subf, value.or, value.floatValue, value.intValue, value.cutoff);
        }
    }
}}}}