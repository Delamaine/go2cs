//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:52 UTC
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
using ioutil = go.io.ioutil_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct debugDeprecatedImportcfgPkg
        {
            // Constructors
            public debugDeprecatedImportcfgPkg(NilType _)
            {
                this.Dir = default;
                this.Import = default;
            }

            public debugDeprecatedImportcfgPkg(@string Dir = default, map<@string, @string> Import = default)
            {
                this.Dir = Dir;
                this.Import = Import;
            }

            // Enable comparisons between nil and debugDeprecatedImportcfgPkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugDeprecatedImportcfgPkg value, NilType nil) => value.Equals(default(debugDeprecatedImportcfgPkg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugDeprecatedImportcfgPkg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugDeprecatedImportcfgPkg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugDeprecatedImportcfgPkg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugDeprecatedImportcfgPkg(NilType nil) => default(debugDeprecatedImportcfgPkg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static debugDeprecatedImportcfgPkg debugDeprecatedImportcfgPkg_cast(dynamic value)
        {
            return new debugDeprecatedImportcfgPkg(value.Dir, value.Import);
        }
    }
}}}}