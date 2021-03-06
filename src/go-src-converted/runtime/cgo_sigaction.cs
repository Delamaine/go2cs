// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Support for memory sanitizer. See runtime/cgo/sigaction.go.

// +build linux,amd64

// package runtime -- go2cs converted at 2020 August 29 08:16:35 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\cgo_sigaction.go
using @unsafe = go.@unsafe_package;
using static go.builtin;
using System;

namespace go
{
    public static partial class runtime_package
    {
        // _cgo_sigaction is filled in by runtime/cgo when it is linked into the
        // program, so it is only non-nil when using cgo.
        //go:linkname _cgo_sigaction _cgo_sigaction
        private static unsafe.Pointer _cgo_sigaction = default;

        //go:nosplit
        //go:nowritebarrierrec
        private static int rt_sigaction(System.UIntPtr sig, ref sigactiont @new, ref sigactiont old, System.UIntPtr size)
        { 
            // The runtime package is explicitly blacklisted from sanitizer
            // instrumentation in racewalk.go, but we might be calling into instrumented C
            // functions here — so we need the pointer parameters to be properly marked.
            //
            // Mark the input as having been written before the call and the output as
            // read after.
            if (msanenabled && new != null)
            {
                msanwrite(@unsafe.Pointer(new), @unsafe.Sizeof(new.Value));
            }
            int ret = default;

            if (_cgo_sigaction == null || inForkedChild)
            {
                ret = sysSigaction(sig, new, old, size);
            }
            else
            { 
                // We need to call _cgo_sigaction, which means we need a big enough stack
                // for C.  To complicate matters, we may be in libpreinit (before the
                // runtime has been initialized) or in an asynchronous signal handler (with
                // the current thread in transition between goroutines, or with the g0
                // system stack already in use).

                var g = getg();
                var sp = uintptr(@unsafe.Pointer(ref sig));

                if (g == null) 
                    // No g: we're on a C stack or a signal stack.
                    ret = callCgoSigaction(sig, new, old);
                else if (sp < g.stack.lo || sp >= g.stack.hi) 
                    // We're no longer on g's stack, so we must be handling a signal.  It's
                    // possible that we interrupted the thread during a transition between g
                    // and g0, so we should stay on the current stack to avoid corrupting g0.
                    ret = callCgoSigaction(sig, new, old);
                else 
                    // We're running on g's stack, so either we're not in a signal handler or
                    // the signal handler has set the correct g.  If we're on gsignal or g0,
                    // systemstack will make the call directly; otherwise, it will switch to
                    // g0 to ensure we have enough room to call a libc function.
                    //
                    // The function literal that we pass to systemstack is not nosplit, but
                    // that's ok: we'll be running on a fresh, clean system stack so the stack
                    // check will always succeed anyway.
                    systemstack(() =>
                    {
                        ret = callCgoSigaction(sig, new, old);
                    });
                                const long EINVAL = 22L;

                if (ret == EINVAL)
                { 
                    // libc reserves certain signals — normally 32-33 — for pthreads, and
                    // returns EINVAL for sigaction calls on those signals.  If we get EINVAL,
                    // fall back to making the syscall directly.
                    ret = sysSigaction(sig, new, old, size);
                }
            }
            if (msanenabled && old != null && ret == 0L)
            {
                msanread(@unsafe.Pointer(old), @unsafe.Sizeof(old.Value));
            }
            return ret;
        }

        // sysSigaction calls the rt_sigaction system call. It is implemented in assembly.
        //go:noescape
        private static int sysSigaction(System.UIntPtr sig, ref sigactiont @new, ref sigactiont old, System.UIntPtr size)
;

        // callCgoSigaction calls the sigaction function in the runtime/cgo package
        // using the GCC calling convention. It is implemented in assembly.
        //go:noescape
        private static int callCgoSigaction(System.UIntPtr sig, ref sigactiont @new, ref sigactiont old)
;
    }
}
