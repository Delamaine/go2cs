// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package os -- go2cs converted at 2020 August 29 08:44:33 UTC
// import "os" ==> using os = go.os_package
// Original source: C:\Go\src\os\sys_solaris.go
using syscall = go.syscall_package;
using static go.builtin;

namespace go
{
    public static partial class os_package
    {
        private static (@string, error) hostname()
        {
            return syscall.Gethostname();
        }
    }
}
