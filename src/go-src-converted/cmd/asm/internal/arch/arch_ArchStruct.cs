//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using arm = go.cmd.@internal.obj.arm_package;
using arm64 = go.cmd.@internal.obj.arm64_package;
using mips = go.cmd.@internal.obj.mips_package;
using ppc64 = go.cmd.@internal.obj.ppc64_package;
using s390x = go.cmd.@internal.obj.s390x_package;
using x86 = go.cmd.@internal.obj.x86_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace asm {
namespace @internal
{
    public static partial class arch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(obj.LinkArch))]
        public partial struct Arch
        {
            // LinkArch structure promotion - sourced from pointer
            private readonly ptr<LinkArch> m_LinkArchRef;

            private ref LinkArch LinkArch_ptr => ref m_LinkArchRef.Value;

            public ref Action<ref Link> Init => ref m_LinkArchRef.Value.Init;

            public ref Action<ref Link, ref LSym, ProgAlloc> Preprocess => ref m_LinkArchRef.Value.Preprocess;

            public ref Action<ref Link, ref LSym, ProgAlloc> Assemble => ref m_LinkArchRef.Value.Assemble;

            public ref Action<ref Link, ref Prog, ProgAlloc> Progedit => ref m_LinkArchRef.Value.Progedit;

            public ref map<As, bool> UnaryDst => ref m_LinkArchRef.Value.UnaryDst;

            public ref map<short, short> DWARFRegisters => ref m_LinkArchRef.Value.DWARFRegisters;

            // Constructors
            public Arch(NilType _)
            {
                this.m_LinkArchRef = new ptr<obj.LinkArch>(new obj.LinkArch(nil));
                this.Instructions = default;
                this.Register = default;
                this.RegisterPrefix = default;
                this.RegisterNumber = default;
                this.IsJump = default;
            }

            public Arch(ref obj.LinkArch LinkArch = default, map<@string, obj.As> Instructions = default, map<@string, short> Register = default, map<@string, bool> RegisterPrefix = default, Func<@string, short, (short, bool)> RegisterNumber = default, Func<@string, bool> IsJump = default)
            {
                this.m_LinkArchRef = new ptr<obj.LinkArch>(ref LinkArch);
                this.Instructions = Instructions;
                this.Register = Register;
                this.RegisterPrefix = RegisterPrefix;
                this.RegisterNumber = RegisterNumber;
                this.IsJump = IsJump;
            }

            // Enable comparisons between nil and Arch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Arch value, NilType nil) => value.Equals(default(Arch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Arch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Arch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Arch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Arch(NilType nil) => default(Arch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Arch Arch_cast(dynamic value)
        {
            return new Arch(ref value.LinkArch, value.Instructions, value.Register, value.RegisterPrefix, value.RegisterNumber, value.IsJump);
        }
    }
}}}}