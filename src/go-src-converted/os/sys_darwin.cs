// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package os -- go2cs converted at 2020 August 29 08:44:32 UTC
// import "os" ==> using os = go.os_package
// Original source: C:\Go\src\os\sys_darwin.go

using static go.builtin;

namespace go
{
    public static partial class os_package
    {
        // supportsCloseOnExec reports whether the platform supports the
        // O_CLOEXEC flag.
        // The O_CLOEXEC flag was introduced in OS X 10.7 (Darwin 11.0.0).
        // See http://support.apple.com/kb/HT1633.
        private static readonly var supportsCloseOnExec = true;

    }
}