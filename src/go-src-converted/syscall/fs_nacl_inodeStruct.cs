//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct inode
        {
            // Constructors
            public inode(NilType _)
            {
                this.Stat_t = default;
                this.data = default;
                this.dir = default;
            }

            public inode(Stat_t Stat_t = default, slice<byte> data = default, slice<dirent> dir = default)
            {
                this.Stat_t = Stat_t;
                this.data = data;
                this.dir = dir;
            }

            // Enable comparisons between nil and inode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(inode value, NilType nil) => value.Equals(default(inode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(inode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, inode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, inode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator inode(NilType nil) => default(inode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static inode inode_cast(dynamic value)
        {
            return new inode(value.Stat_t, value.data, value.dir);
        }
    }
}