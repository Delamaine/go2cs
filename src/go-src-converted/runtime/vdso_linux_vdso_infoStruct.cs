//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:37 UTC
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
        private partial struct vdso_info
        {
            // Constructors
            public vdso_info(NilType _)
            {
                this.valid = default;
                this.load_addr = default;
                this.load_offset = default;
                this.symtab = default;
                this.symstrings = default;
                this.chain = default;
                this.bucket = default;
                this.symOff = default;
                this.isGNUHash = default;
                this.versym = default;
                this.verdef = default;
            }

            public vdso_info(bool valid = default, System.UIntPtr load_addr = default, System.UIntPtr load_offset = default, ref ptr<array<elfSym>> symtab = default, ref ptr<array<byte>> symstrings = default, slice<uint> chain = default, slice<uint> bucket = default, uint symOff = default, bool isGNUHash = default, ref ptr<array<ushort>> versym = default, ref ptr<elfVerdef> verdef = default)
            {
                this.valid = valid;
                this.load_addr = load_addr;
                this.load_offset = load_offset;
                this.symtab = symtab;
                this.symstrings = symstrings;
                this.chain = chain;
                this.bucket = bucket;
                this.symOff = symOff;
                this.isGNUHash = isGNUHash;
                this.versym = versym;
                this.verdef = verdef;
            }

            // Enable comparisons between nil and vdso_info struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vdso_info value, NilType nil) => value.Equals(default(vdso_info));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vdso_info value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vdso_info value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vdso_info value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vdso_info(NilType nil) => default(vdso_info);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vdso_info vdso_info_cast(dynamic value)
        {
            return new vdso_info(value.valid, value.load_addr, value.load_offset, ref value.symtab, ref value.symstrings, value.chain, value.bucket, value.symOff, value.isGNUHash, ref value.versym, ref value.verdef);
        }
    }
}