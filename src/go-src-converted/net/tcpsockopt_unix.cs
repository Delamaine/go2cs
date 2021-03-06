// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build freebsd linux netbsd

// package net -- go2cs converted at 2020 August 29 08:27:56 UTC
// import "net" ==> using net = go.net_package
// Original source: C:\Go\src\net\tcpsockopt_unix.go
using runtime = go.runtime_package;
using syscall = go.syscall_package;
using time = go.time_package;
using static go.builtin;

namespace go
{
    public static partial class net_package
    {
        private static error setKeepAlivePeriod(ref netFD fd, time.Duration d)
        { 
            // The kernel expects seconds so round to next highest second.
            d += (time.Second - time.Nanosecond);
            var secs = int(d.Seconds());
            {
                var err__prev1 = err;

                var err = fd.pfd.SetsockoptInt(syscall.IPPROTO_TCP, syscall.TCP_KEEPINTVL, secs);

                if (err != null)
                {
                    return error.As(wrapSyscallError("setsockopt", err));
                }
                err = err__prev1;

            }
            err = fd.pfd.SetsockoptInt(syscall.IPPROTO_TCP, syscall.TCP_KEEPIDLE, secs);
            runtime.KeepAlive(fd);
            return error.As(wrapSyscallError("setsockopt", err));
        }
    }
}
