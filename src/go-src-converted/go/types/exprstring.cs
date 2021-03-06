// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// This file implements printing of expressions.

// package types -- go2cs converted at 2020 August 29 08:47:37 UTC
// import "go/types" ==> using types = go.go.types_package
// Original source: C:\Go\src\go\types\exprstring.go
using bytes = go.bytes_package;
using ast = go.go.ast_package;
using static go.builtin;

namespace go {
namespace go
{
    public static partial class types_package
    {
        // ExprString returns the (possibly shortened) string representation for x.
        // Shortened representations are suitable for user interfaces but may not
        // necessarily follow Go syntax.
        public static @string ExprString(ast.Expr x)
        {
            bytes.Buffer buf = default;
            WriteExpr(ref buf, x);
            return buf.String();
        }

        // WriteExpr writes the (possibly shortened) string representation for x to buf.
        // Shortened representations are suitable for user interfaces but may not
        // necessarily follow Go syntax.
        public static void WriteExpr(ref bytes.Buffer buf, ast.Expr x)
        { 
            // The AST preserves source-level parentheses so there is
            // no need to introduce them here to correct for different
            // operator precedences. (This assumes that the AST was
            // generated by a Go parser.)

            switch (x.type())
            {
                case ref ast.Ident x:
                    buf.WriteString(x.Name);
                    break;
                case ref ast.Ellipsis x:
                    buf.WriteString("...");
                    if (x.Elt != null)
                    {
                        WriteExpr(buf, x.Elt);
                    }
                    break;
                case ref ast.BasicLit x:
                    buf.WriteString(x.Value);
                    break;
                case ref ast.FuncLit x:
                    buf.WriteByte('(');
                    WriteExpr(buf, x.Type);
                    buf.WriteString(" literal)"); // shortened
                    break;
                case ref ast.CompositeLit x:
                    buf.WriteByte('(');
                    WriteExpr(buf, x.Type);
                    buf.WriteString(" literal)"); // shortened
                    break;
                case ref ast.ParenExpr x:
                    buf.WriteByte('(');
                    WriteExpr(buf, x.X);
                    buf.WriteByte(')');
                    break;
                case ref ast.SelectorExpr x:
                    WriteExpr(buf, x.X);
                    buf.WriteByte('.');
                    buf.WriteString(x.Sel.Name);
                    break;
                case ref ast.IndexExpr x:
                    WriteExpr(buf, x.X);
                    buf.WriteByte('[');
                    WriteExpr(buf, x.Index);
                    buf.WriteByte(']');
                    break;
                case ref ast.SliceExpr x:
                    WriteExpr(buf, x.X);
                    buf.WriteByte('[');
                    if (x.Low != null)
                    {
                        WriteExpr(buf, x.Low);
                    }
                    buf.WriteByte(':');
                    if (x.High != null)
                    {
                        WriteExpr(buf, x.High);
                    }
                    if (x.Slice3)
                    {
                        buf.WriteByte(':');
                        if (x.Max != null)
                        {
                            WriteExpr(buf, x.Max);
                        }
                    }
                    buf.WriteByte(']');
                    break;
                case ref ast.TypeAssertExpr x:
                    WriteExpr(buf, x.X);
                    buf.WriteString(".(");
                    WriteExpr(buf, x.Type);
                    buf.WriteByte(')');
                    break;
                case ref ast.CallExpr x:
                    WriteExpr(buf, x.Fun);
                    buf.WriteByte('(');
                    foreach (var (i, arg) in x.Args)
                    {
                        if (i > 0L)
                        {
                            buf.WriteString(", ");
                        }
                        WriteExpr(buf, arg);
                    }
                    if (x.Ellipsis.IsValid())
                    {
                        buf.WriteString("...");
                    }
                    buf.WriteByte(')');
                    break;
                case ref ast.StarExpr x:
                    buf.WriteByte('*');
                    WriteExpr(buf, x.X);
                    break;
                case ref ast.UnaryExpr x:
                    buf.WriteString(x.Op.String());
                    WriteExpr(buf, x.X);
                    break;
                case ref ast.BinaryExpr x:
                    WriteExpr(buf, x.X);
                    buf.WriteByte(' ');
                    buf.WriteString(x.Op.String());
                    buf.WriteByte(' ');
                    WriteExpr(buf, x.Y);
                    break;
                case ref ast.ArrayType x:
                    buf.WriteByte('[');
                    if (x.Len != null)
                    {
                        WriteExpr(buf, x.Len);
                    }
                    buf.WriteByte(']');
                    WriteExpr(buf, x.Elt);
                    break;
                case ref ast.StructType x:
                    buf.WriteString("struct{");
                    writeFieldList(buf, x.Fields, "; ", false);
                    buf.WriteByte('}');
                    break;
                case ref ast.FuncType x:
                    buf.WriteString("func");
                    writeSigExpr(buf, x);
                    break;
                case ref ast.InterfaceType x:
                    buf.WriteString("interface{");
                    writeFieldList(buf, x.Methods, "; ", true);
                    buf.WriteByte('}');
                    break;
                case ref ast.MapType x:
                    buf.WriteString("map[");
                    WriteExpr(buf, x.Key);
                    buf.WriteByte(']');
                    WriteExpr(buf, x.Value);
                    break;
                case ref ast.ChanType x:
                    @string s = default;

                    if (x.Dir == ast.SEND) 
                        s = "chan<- ";
                    else if (x.Dir == ast.RECV) 
                        s = "<-chan ";
                    else 
                        s = "chan ";
                                        buf.WriteString(s);
                    WriteExpr(buf, x.Value);
                    break;
                default:
                {
                    var x = x.type();
                    buf.WriteString("(bad expr)"); // nil, ast.BadExpr, ast.KeyValueExpr
                    break;
                }
            }
        }

        private static void writeSigExpr(ref bytes.Buffer buf, ref ast.FuncType sig)
        {
            buf.WriteByte('(');
            writeFieldList(buf, sig.Params, ", ", false);
            buf.WriteByte(')');

            var res = sig.Results;
            var n = res.NumFields();
            if (n == 0L)
            { 
                // no result
                return;
            }
            buf.WriteByte(' ');
            if (n == 1L && len(res.List[0L].Names) == 0L)
            { 
                // single unnamed result
                WriteExpr(buf, res.List[0L].Type);
                return;
            } 

            // multiple or named result(s)
            buf.WriteByte('(');
            writeFieldList(buf, res, ", ", false);
            buf.WriteByte(')');
        }

        private static void writeFieldList(ref bytes.Buffer buf, ref ast.FieldList fields, @string sep, bool iface)
        {
            {
                var i__prev1 = i;

                foreach (var (__i, __f) in fields.List)
                {
                    i = __i;
                    f = __f;
                    if (i > 0L)
                    {
                        buf.WriteString(sep);
                    } 

                    // field list names
                    {
                        var i__prev2 = i;

                        foreach (var (__i, __name) in f.Names)
                        {
                            i = __i;
                            name = __name;
                            if (i > 0L)
                            {
                                buf.WriteString(", ");
                            }
                            buf.WriteString(name.Name);
                        } 

                        // types of interface methods consist of signatures only

                        i = i__prev2;
                    }

                    {
                        ref ast.FuncType (sig, _) = f.Type._<ref ast.FuncType>();

                        if (sig != null && iface)
                        {
                            writeSigExpr(buf, sig);
                            continue;
                        } 

                        // named fields are separated with a blank from the field type

                    } 

                    // named fields are separated with a blank from the field type
                    if (len(f.Names) > 0L)
                    {
                        buf.WriteByte(' ');
                    }
                    WriteExpr(buf, f.Type); 

                    // ignore tag
                }

                i = i__prev1;
            }

        }
    }
}}
