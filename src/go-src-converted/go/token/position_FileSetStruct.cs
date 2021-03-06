//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using sync = go.sync_package;
using go;

namespace go {
namespace go
{
    public static partial class token_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FileSet
        {
            // Constructors
            public FileSet(NilType _)
            {
                this.mutex = default;
                this.@base = default;
                this.files = default;
                this.last = default;
            }

            public FileSet(sync.RWMutex mutex = default, long @base = default, slice<ref File> files = default, ref ptr<File> last = default)
            {
                this.mutex = mutex;
                this.@base = @base;
                this.files = files;
                this.last = last;
            }

            // Enable comparisons between nil and FileSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FileSet value, NilType nil) => value.Equals(default(FileSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FileSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FileSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FileSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FileSet(NilType nil) => default(FileSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FileSet FileSet_cast(dynamic value)
        {
            return new FileSet(value.mutex, value.@base, value.files, ref value.last);
        }
    }
}}