//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:03 UTC
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
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using importer = go.go.importer_package;
using parser = go.go.parser_package;
using printer = go.go.printer_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strconv = go.strconv_package;
using strings = go.strings_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Package
        {
            // Constructors
            public Package(NilType _)
            {
                this.path = default;
                this.defs = default;
                this.uses = default;
                this.selectors = default;
                this.types = default;
                this.spans = default;
                this.files = default;
                this.typesPkg = default;
            }

            public Package(@string path = default, map<ref ast.Ident, types.Object> defs = default, map<ref ast.Ident, types.Object> uses = default, map<ref ast.SelectorExpr, ref types.Selection> selectors = default, map<ast.Expr, types.TypeAndValue> types = default, map<types.Object, Span> spans = default, slice<ref File> files = default, ref ptr<types.Package> typesPkg = default)
            {
                this.path = path;
                this.defs = defs;
                this.uses = uses;
                this.selectors = selectors;
                this.types = types;
                this.spans = spans;
                this.files = files;
                this.typesPkg = typesPkg;
            }

            // Enable comparisons between nil and Package struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Package value, NilType nil) => value.Equals(default(Package));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Package value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Package value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Package value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Package(NilType nil) => default(Package);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Package Package_cast(dynamic value)
        {
            return new Package(value.path, value.defs, value.uses, value.selectors, value.types, value.spans, value.files, ref value.typesPkg);
        }
    }
}