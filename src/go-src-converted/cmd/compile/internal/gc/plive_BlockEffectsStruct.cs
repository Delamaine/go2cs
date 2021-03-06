//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:28:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using md5 = go.crypto.md5_package;
using sha1 = go.crypto.sha1_package;
using fmt = go.fmt_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BlockEffects
        {
            // Constructors
            public BlockEffects(NilType _)
            {
                this.lastbitmapindex = default;
                this.uevar = default;
                this.varkill = default;
                this.avarinit = default;
                this.livein = default;
                this.liveout = default;
                this.avarinitany = default;
                this.avarinitall = default;
            }

            public BlockEffects(long lastbitmapindex = default, bvec uevar = default, bvec varkill = default, bvec avarinit = default, bvec livein = default, bvec liveout = default, bvec avarinitany = default, bvec avarinitall = default)
            {
                this.lastbitmapindex = lastbitmapindex;
                this.uevar = uevar;
                this.varkill = varkill;
                this.avarinit = avarinit;
                this.livein = livein;
                this.liveout = liveout;
                this.avarinitany = avarinitany;
                this.avarinitall = avarinitall;
            }

            // Enable comparisons between nil and BlockEffects struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BlockEffects value, NilType nil) => value.Equals(default(BlockEffects));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BlockEffects value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BlockEffects value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BlockEffects value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BlockEffects(NilType nil) => default(BlockEffects);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BlockEffects BlockEffects_cast(dynamic value)
        {
            return new BlockEffects(value.lastbitmapindex, value.uevar, value.varkill, value.avarinit, value.livein, value.liveout, value.avarinitany, value.avarinitall);
        }
    }
}}}}