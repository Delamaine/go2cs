//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class cpu_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct arm64
        {
            // Constructors
            public arm64(NilType _)
            {
                this._ = default;
                this.HasFP = default;
                this.HasASIMD = default;
                this.HasEVTSTRM = default;
                this.HasAES = default;
                this.HasPMULL = default;
                this.HasSHA1 = default;
                this.HasSHA2 = default;
                this.HasCRC32 = default;
                this.HasATOMICS = default;
                this._ = default;
            }

            public arm64(array<byte> _ = default, bool HasFP = default, bool HasASIMD = default, bool HasEVTSTRM = default, bool HasAES = default, bool HasPMULL = default, bool HasSHA1 = default, bool HasSHA2 = default, bool HasCRC32 = default, bool HasATOMICS = default, array<byte> _ = default)
            {
                this._ = _;
                this.HasFP = HasFP;
                this.HasASIMD = HasASIMD;
                this.HasEVTSTRM = HasEVTSTRM;
                this.HasAES = HasAES;
                this.HasPMULL = HasPMULL;
                this.HasSHA1 = HasSHA1;
                this.HasSHA2 = HasSHA2;
                this.HasCRC32 = HasCRC32;
                this.HasATOMICS = HasATOMICS;
                this._ = _;
            }

            // Enable comparisons between nil and arm64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(arm64 value, NilType nil) => value.Equals(default(arm64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(arm64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, arm64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, arm64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator arm64(NilType nil) => default(arm64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static arm64 arm64_cast(dynamic value)
        {
            return new arm64(value._, value.HasFP, value.HasASIMD, value.HasEVTSTRM, value.HasAES, value.HasPMULL, value.HasSHA1, value.HasSHA2, value.HasCRC32, value.HasATOMICS, value._);
        }
    }
}}