//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using @base = go.cmd.go.@internal.@base_package;
using cache = go.cmd.go.@internal.cache_package;
using cfg = go.cmd.go.@internal.cfg_package;
using load = go.cmd.go.@internal.load_package;
using str = go.cmd.go.@internal.str_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class work_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct vetConfig
        {
            // Constructors
            public vetConfig(NilType _)
            {
                this.Compiler = default;
                this.Dir = default;
                this.GoFiles = default;
                this.ImportMap = default;
                this.PackageFile = default;
                this.ImportPath = default;
                this.SucceedOnTypecheckFailure = default;
            }

            public vetConfig(@string Compiler = default, @string Dir = default, slice<@string> GoFiles = default, map<@string, @string> ImportMap = default, map<@string, @string> PackageFile = default, @string ImportPath = default, bool SucceedOnTypecheckFailure = default)
            {
                this.Compiler = Compiler;
                this.Dir = Dir;
                this.GoFiles = GoFiles;
                this.ImportMap = ImportMap;
                this.PackageFile = PackageFile;
                this.ImportPath = ImportPath;
                this.SucceedOnTypecheckFailure = SucceedOnTypecheckFailure;
            }

            // Enable comparisons between nil and vetConfig struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vetConfig value, NilType nil) => value.Equals(default(vetConfig));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vetConfig value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vetConfig value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vetConfig value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vetConfig(NilType nil) => default(vetConfig);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vetConfig vetConfig_cast(dynamic value)
        {
            return new vetConfig(value.Compiler, value.Dir, value.GoFiles, value.ImportMap, value.PackageFile, value.ImportPath, value.SucceedOnTypecheckFailure);
        }
    }
}}}}