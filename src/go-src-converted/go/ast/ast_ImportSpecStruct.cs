//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ImportSpec
        {
            // Constructors
            public ImportSpec(NilType _)
            {
                this.Doc = default;
                this.Name = default;
                this.Path = default;
                this.Comment = default;
                this.EndPos = default;
            }

            public ImportSpec(ref ptr<CommentGroup> Doc = default, ref ptr<Ident> Name = default, ref ptr<BasicLit> Path = default, ref ptr<CommentGroup> Comment = default, token.Pos EndPos = default)
            {
                this.Doc = Doc;
                this.Name = Name;
                this.Path = Path;
                this.Comment = Comment;
                this.EndPos = EndPos;
            }

            // Enable comparisons between nil and ImportSpec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImportSpec value, NilType nil) => value.Equals(default(ImportSpec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImportSpec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImportSpec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImportSpec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportSpec(NilType nil) => default(ImportSpec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ImportSpec ImportSpec_cast(dynamic value)
        {
            return new ImportSpec(ref value.Doc, ref value.Name, ref value.Path, ref value.Comment, value.EndPos);
        }
    }
}}