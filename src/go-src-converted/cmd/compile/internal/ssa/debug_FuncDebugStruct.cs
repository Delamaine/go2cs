//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncDebug
        {
            // Constructors
            public FuncDebug(NilType _)
            {
                this.Slots = default;
                this.VarSlots = default;
                this.Blocks = default;
                this.Registers = default;
            }

            public FuncDebug(slice<ref LocalSlot> Slots = default, slice<ref LocalSlot> VarSlots = default, slice<ref BlockDebug> Blocks = default, slice<Register> Registers = default)
            {
                this.Slots = Slots;
                this.VarSlots = VarSlots;
                this.Blocks = Blocks;
                this.Registers = Registers;
            }

            // Enable comparisons between nil and FuncDebug struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncDebug value, NilType nil) => value.Equals(default(FuncDebug));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncDebug value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncDebug value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncDebug value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncDebug(NilType nil) => default(FuncDebug);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FuncDebug FuncDebug_cast(dynamic value)
        {
            return new FuncDebug(value.Slots, value.VarSlots, value.Blocks, value.Registers);
        }
    }
}}}}