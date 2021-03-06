//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using filepath = go.path.filepath_package;
using sync = go.sync_package;
using template = go.text.template_package;
using parse = go.text.template.parse_package;
using go;

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(nameSpace))]
        public partial struct Template
        {
            // nameSpace structure promotion - sourced from pointer
            private readonly ptr<nameSpace> m_nameSpaceRef;

            private ref nameSpace nameSpace_ptr => ref m_nameSpaceRef.Value;

            public ref sync.Mutex mu => ref m_nameSpaceRef.Value.mu;

            public ref map<@string, ref Template> set => ref m_nameSpaceRef.Value.set;

            public ref bool escaped => ref m_nameSpaceRef.Value.escaped;

            public ref escaper esc => ref m_nameSpaceRef.Value.esc;

            // Constructors
            public Template(NilType _)
            {
                this.escapeErr = default;
                this.text = default;
                this.Tree = default;
                this.m_nameSpaceRef = new ptr<nameSpace>(new nameSpace(nil));
            }

            public Template(error escapeErr = default, ref ptr<template.Template> text = default, ref ptr<parse.Tree> Tree = default, ref nameSpace nameSpace = default)
            {
                this.escapeErr = escapeErr;
                this.text = text;
                this.Tree = Tree;
                this.m_nameSpaceRef = new ptr<nameSpace>(ref nameSpace);
            }

            // Enable comparisons between nil and Template struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Template value, NilType nil) => value.Equals(default(Template));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Template value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Template value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Template value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Template(NilType nil) => default(Template);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Template Template_cast(dynamic value)
        {
            return new Template(value.escapeErr, ref value.text, ref value.Tree, ref value.nameSpace);
        }
    }
}}