//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using go;

namespace go {
namespace go
{
    public static partial class doc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Package
        {
            // Constructors
            public Package(NilType _)
            {
                this.Doc = default;
                this.Name = default;
                this.ImportPath = default;
                this.Imports = default;
                this.Filenames = default;
                this.Notes = default;
                this.Bugs = default;
                this.Consts = default;
                this.Types = default;
                this.Vars = default;
                this.Funcs = default;
            }

            public Package(@string Doc = default, @string Name = default, @string ImportPath = default, slice<@string> Imports = default, slice<@string> Filenames = default, map<@string, slice<ref Note>> Notes = default, slice<@string> Bugs = default, slice<ref Value> Consts = default, slice<ref Type> Types = default, slice<ref Value> Vars = default, slice<ref Func> Funcs = default)
            {
                this.Doc = Doc;
                this.Name = Name;
                this.ImportPath = ImportPath;
                this.Imports = Imports;
                this.Filenames = Filenames;
                this.Notes = Notes;
                this.Bugs = Bugs;
                this.Consts = Consts;
                this.Types = Types;
                this.Vars = Vars;
                this.Funcs = Funcs;
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
            return new Package(value.Doc, value.Name, value.ImportPath, value.Imports, value.Filenames, value.Notes, value.Bugs, value.Consts, value.Types, value.Vars, value.Funcs);
        }
    }
}}