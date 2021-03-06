// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 August 29 08:20:06 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\signal_darwin_arm64.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private partial struct sigctxt
        {
            public ptr<siginfo> info;
            public unsafe.Pointer ctxt;
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static ref regs64 regs(this ref sigctxt c)
        {
            return ref (ucontext.Value)(c.ctxt).uc_mcontext.ss;
        }

        private static ulong r0(this ref sigctxt c)
        {
            return c.regs().x[0L];
        }
        private static ulong r1(this ref sigctxt c)
        {
            return c.regs().x[1L];
        }
        private static ulong r2(this ref sigctxt c)
        {
            return c.regs().x[2L];
        }
        private static ulong r3(this ref sigctxt c)
        {
            return c.regs().x[3L];
        }
        private static ulong r4(this ref sigctxt c)
        {
            return c.regs().x[4L];
        }
        private static ulong r5(this ref sigctxt c)
        {
            return c.regs().x[5L];
        }
        private static ulong r6(this ref sigctxt c)
        {
            return c.regs().x[6L];
        }
        private static ulong r7(this ref sigctxt c)
        {
            return c.regs().x[7L];
        }
        private static ulong r8(this ref sigctxt c)
        {
            return c.regs().x[8L];
        }
        private static ulong r9(this ref sigctxt c)
        {
            return c.regs().x[9L];
        }
        private static ulong r10(this ref sigctxt c)
        {
            return c.regs().x[10L];
        }
        private static ulong r11(this ref sigctxt c)
        {
            return c.regs().x[11L];
        }
        private static ulong r12(this ref sigctxt c)
        {
            return c.regs().x[12L];
        }
        private static ulong r13(this ref sigctxt c)
        {
            return c.regs().x[13L];
        }
        private static ulong r14(this ref sigctxt c)
        {
            return c.regs().x[14L];
        }
        private static ulong r15(this ref sigctxt c)
        {
            return c.regs().x[15L];
        }
        private static ulong r16(this ref sigctxt c)
        {
            return c.regs().x[16L];
        }
        private static ulong r17(this ref sigctxt c)
        {
            return c.regs().x[17L];
        }
        private static ulong r18(this ref sigctxt c)
        {
            return c.regs().x[18L];
        }
        private static ulong r19(this ref sigctxt c)
        {
            return c.regs().x[19L];
        }
        private static ulong r20(this ref sigctxt c)
        {
            return c.regs().x[20L];
        }
        private static ulong r21(this ref sigctxt c)
        {
            return c.regs().x[21L];
        }
        private static ulong r22(this ref sigctxt c)
        {
            return c.regs().x[22L];
        }
        private static ulong r23(this ref sigctxt c)
        {
            return c.regs().x[23L];
        }
        private static ulong r24(this ref sigctxt c)
        {
            return c.regs().x[24L];
        }
        private static ulong r25(this ref sigctxt c)
        {
            return c.regs().x[25L];
        }
        private static ulong r26(this ref sigctxt c)
        {
            return c.regs().x[26L];
        }
        private static ulong r27(this ref sigctxt c)
        {
            return c.regs().x[27L];
        }
        private static ulong r28(this ref sigctxt c)
        {
            return c.regs().x[28L];
        }
        private static ulong r29(this ref sigctxt c)
        {
            return c.regs().fp;
        }
        private static ulong lr(this ref sigctxt c)
        {
            return c.regs().lr;
        }
        private static ulong sp(this ref sigctxt c)
        {
            return c.regs().sp;
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static ulong pc(this ref sigctxt c)
        {
            return c.regs().pc;
        }

        private static System.UIntPtr fault(this ref sigctxt c)
        {
            return uintptr(@unsafe.Pointer(c.info.si_addr));
        }

        private static ulong sigcode(this ref sigctxt c)
        {
            return uint64(c.info.si_code);
        }
        private static ulong sigaddr(this ref sigctxt c)
        {
            return uint64(uintptr(@unsafe.Pointer(c.info.si_addr)));
        }

        private static void set_pc(this ref sigctxt c, ulong x)
        {
            c.regs().pc = x;

        }
        private static void set_sp(this ref sigctxt c, ulong x)
        {
            c.regs().sp = x;

        }
        private static void set_lr(this ref sigctxt c, ulong x)
        {
            c.regs().lr = x;

        }
        private static void set_r28(this ref sigctxt c, ulong x)
        {
            c.regs().x[28L] = x;

        }

        private static void set_sigcode(this ref sigctxt c, ulong x)
        {
            c.info.si_code = int32(x);

        }
        private static void set_sigaddr(this ref sigctxt c, ulong x)
        {
            c.info.si_addr = (byte.Value)(@unsafe.Pointer(uintptr(x)));
        }

        private static void fixsigcode(this ref sigctxt c, uint sig)
        {

            if (sig == _SIGTRAP) 
                // OS X sets c.sigcode() == TRAP_BRKPT unconditionally for all SIGTRAPs,
                // leaving no way to distinguish a breakpoint-induced SIGTRAP
                // from an asynchronous signal SIGTRAP.
                // They all look breakpoint-induced by default.
                // Try looking at the code to see if it's a breakpoint.
                // The assumption is that we're very unlikely to get an
                // asynchronous SIGTRAP at just the moment that the
                // PC started to point at unmapped memory.
                var pc = uintptr(c.pc()); 
                // OS X will leave the pc just after the instruction.
                var code = (uint32.Value)(@unsafe.Pointer(pc - 4L));
                if (code != 0xd4200000UL.Value)
                { 
                    // SIGTRAP on something other than breakpoint.
                    c.set_sigcode(_SI_USER);
                }
                    }
    }
}
