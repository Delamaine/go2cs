// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package importer provides access to export data importers.
// package importer -- go2cs converted at 2020 August 29 10:09:03 UTC
// import "go/importer" ==> using importer = go.go.importer_package
// Original source: C:\Go\src\go\importer\importer.go
using build = go.go.build_package;
using gccgoimporter = go.go.@internal.gccgoimporter_package;
using gcimporter = go.go.@internal.gcimporter_package;
using srcimporter = go.go.@internal.srcimporter_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using runtime = go.runtime_package;
using static go.builtin;

namespace go {
namespace go
{
    public static partial class importer_package
    {
        // A Lookup function returns a reader to access package data for
        // a given import path, or an error if no matching package is found.
        public delegate  error) Lookup(@string,  (io.ReadCloser);

        // For returns an Importer for importing from installed packages
        // for the compilers "gc" and "gccgo", or for importing directly
        // from the source if the compiler argument is "source". In this
        // latter case, importing may fail under circumstances where the
        // exported API is not entirely defined in pure Go source code
        // (if the package API depends on cgo-defined entities, the type
        // checker won't have access to those).
        //
        // If lookup is nil, the default package lookup mechanism for the
        // given compiler is used, and the resulting importer attempts
        // to resolve relative and absolute import paths to canonical
        // import path IDs before finding the imported file.
        //
        // If lookup is non-nil, then the returned importer calls lookup
        // each time it needs to resolve an import path. In this mode
        // the importer can only be invoked with canonical import paths
        // (not relative or absolute ones); it is assumed that the translation
        // to canonical import paths is being done by the client of the
        // importer.
        public static types.Importer For(@string compiler, Lookup lookup) => func((_, panic, __) =>
        {
            switch (compiler)
            {
                case "gc": 
                    return ref new gcimports(packages:make(map[string]*types.Package),lookup:lookup,);
                    break;
                case "gccgo": 
                    gccgoimporter.GccgoInstallation inst = default;
                    {
                        var err = inst.InitFromDriver("gccgo");

                        if (err != null)
                        {
                            return null;
                        }

                    }
                    return ref new gccgoimports(packages:make(map[string]*types.Package),importer:inst.GetImporter(nil,nil),lookup:lookup,);
                    break;
                case "source": 
                    if (lookup != null)
                    {
                        panic("source importer for custom import path lookup not supported (issue #13847).");
                    }
                    return srcimporter.New(ref build.Default, token.NewFileSet(), make_map<@string, ref types.Package>());
                    break;
            } 

            // compiler not supported
            return null;
        });

        // Default returns an Importer for the compiler that built the running binary.
        // If available, the result implements types.ImporterFrom.
        public static types.Importer Default()
        {
            return For(runtime.Compiler, null);
        }

        // gc importer

        private partial struct gcimports
        {
            public map<@string, ref types.Package> packages;
            public Lookup lookup;
        }

        private static (ref types.Package, error) Import(this ref gcimports m, @string path)
        {
            return m.ImportFrom(path, "", 0L);
        }

        private static (ref types.Package, error) ImportFrom(this ref gcimports _m, @string path, @string srcDir, types.ImportMode mode) => func(_m, (ref gcimports m, Defer _, Panic panic, Recover __) =>
        {
            if (mode != 0L)
            {
                panic("mode must be 0");
            }
            return gcimporter.Import(m.packages, path, srcDir, m.lookup);
        });

        // gccgo importer

        private partial struct gccgoimports
        {
            public map<@string, ref types.Package> packages;
            public gccgoimporter.Importer importer;
            public Lookup lookup;
        }

        private static (ref types.Package, error) Import(this ref gccgoimports m, @string path)
        {
            return m.ImportFrom(path, "", 0L);
        }

        private static (ref types.Package, error) ImportFrom(this ref gccgoimports _m, @string path, @string srcDir, types.ImportMode mode) => func(_m, (ref gccgoimports m, Defer _, Panic panic, Recover __) =>
        {
            if (mode != 0L)
            {
                panic("mode must be 0");
            }
            return m.importer(m.packages, path, srcDir, m.lookup);
        });
    }
}}
