// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 August 29 08:19:05 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\os_plan9.go
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private partial struct mOS
        {
            public uint waitsemacount;
            public ptr<sbyte> notesig;
            public ptr<byte> errstr;
            public bool ignoreHangup;
        }

        private static int closefd(int fd)
;

        //go:noescape
        private static int open(ref byte name, int mode, int perm)
;

        //go:noescape
        private static int pread(int fd, unsafe.Pointer buf, int nbytes, long offset)
;

        //go:noescape
        private static int pwrite(int fd, unsafe.Pointer buf, int nbytes, long offset)
;

        private static long seek(int fd, long offset, int whence)
;

        //go:noescape
        private static void exits(ref byte msg)
;

        //go:noescape
        private static int brk_(unsafe.Pointer addr)
;

        private static int sleep(int ms)
;

        private static int rfork(int flags)
;

        //go:noescape
        private static int plan9_semacquire(ref uint addr, int block)
;

        //go:noescape
        private static int plan9_tsemacquire(ref uint addr, int ms)
;

        //go:noescape
        private static int plan9_semrelease(ref uint addr, int count)
;

        //go:noescape
        private static int notify(unsafe.Pointer fn)
;

        private static int noted(int mode)
;

        //go:noescape
        private static long nsec(ref long _p0)
;

        //go:noescape
        private static void sigtramp(unsafe.Pointer ureg, unsafe.Pointer note)
;

        private static void setfpmasks()
;

        //go:noescape
        private static void tstart_plan9(ref m newm)
;

        private static @string errstr()
;

        private partial struct _Plink // : System.UIntPtr
        {
        }

        //go:linkname os_sigpipe os.sigpipe
        private static void os_sigpipe()
        {
            throw("too many writes on closed pipe");
        }

        private static void sigpanic() => func((_, panic, __) =>
        {
            var g = getg();
            if (!canpanic(g))
            {>>MARKER:FUNCTION_errstr_BLOCK_PREFIX<<
                throw("unexpected signal during runtime execution");
            }
            var note = gostringnocopy((byte.Value)(@unsafe.Pointer(g.m.notesig)));

            if (g.sig == _SIGRFAULT || g.sig == _SIGWFAULT) 
                var i = index(note, "addr=");
                if (i >= 0L)
                {>>MARKER:FUNCTION_tstart_plan9_BLOCK_PREFIX<<
                    i += 5L;
                }                i = index(note, "va=");


                else if (i >= 0L)
                {>>MARKER:FUNCTION_setfpmasks_BLOCK_PREFIX<<
                    i += 3L;
                }
                else
                {>>MARKER:FUNCTION_sigtramp_BLOCK_PREFIX<<
                    panicmem();
                }
                var addr = note[i..];
                g.sigcode1 = uintptr(atolwhex(addr));
                if (g.sigcode1 < 0x1000UL || g.paniconfault)
                {>>MARKER:FUNCTION_nsec_BLOCK_PREFIX<<
                    panicmem();
                }
                print("unexpected fault address ", hex(g.sigcode1), "\n");
                throw("fault");
            else if (g.sig == _SIGTRAP) 
                if (g.paniconfault)
                {>>MARKER:FUNCTION_noted_BLOCK_PREFIX<<
                    panicmem();
                }
                throw(note);
            else if (g.sig == _SIGINTDIV) 
                panicdivide();
            else if (g.sig == _SIGFLOAT) 
                panicfloat();
            else 
                panic(errorString(note));
                    });

        private static long atolwhex(@string p)
        {
            while (hasprefix(p, " ") || hasprefix(p, "\t"))
            {>>MARKER:FUNCTION_notify_BLOCK_PREFIX<<
                p = p[1L..];
            }

            var neg = false;
            if (hasprefix(p, "-") || hasprefix(p, "+"))
            {>>MARKER:FUNCTION_plan9_semrelease_BLOCK_PREFIX<<
                neg = p[0L] == '-';
                p = p[1L..];
                while (hasprefix(p, " ") || hasprefix(p, "\t"))
                {>>MARKER:FUNCTION_plan9_tsemacquire_BLOCK_PREFIX<<
                    p = p[1L..];
                }

            }
            long n = default;

            if (hasprefix(p, "0x") || hasprefix(p, "0X")) 
                p = p[2L..];
                while (len(p) > 0L)
                {>>MARKER:FUNCTION_plan9_semacquire_BLOCK_PREFIX<<
                    if ('0' <= p[0L] && p[0L] <= '9')
                    {>>MARKER:FUNCTION_rfork_BLOCK_PREFIX<<
                        n = n * 16L + int64(p[0L] - '0');
                    p = p[1L..];
                    }
                    else if ('a' <= p[0L] && p[0L] <= 'f')
                    {>>MARKER:FUNCTION_sleep_BLOCK_PREFIX<<
                        n = n * 16L + int64(p[0L] - 'a' + 10L);
                    }
                    else if ('A' <= p[0L] && p[0L] <= 'F')
                    {>>MARKER:FUNCTION_brk__BLOCK_PREFIX<<
                        n = n * 16L + int64(p[0L] - 'A' + 10L);
                    }
                    else
                    {>>MARKER:FUNCTION_exits_BLOCK_PREFIX<<
                        break;
                    }
                }
            else if (hasprefix(p, "0")) 
                while (len(p) > 0L && '0' <= p[0L] && p[0L] <= '7')
                {>>MARKER:FUNCTION_seek_BLOCK_PREFIX<<
                    n = n * 8L + int64(p[0L] - '0');
                    p = p[1L..];
                }
            else 
                while (len(p) > 0L && '0' <= p[0L] && p[0L] <= '9')
                {>>MARKER:FUNCTION_pwrite_BLOCK_PREFIX<<
                    n = n * 10L + int64(p[0L] - '0');
                    p = p[1L..];
                }
                        if (neg)
            {>>MARKER:FUNCTION_pread_BLOCK_PREFIX<<
                n = -n;
            }
            return n;
        }

        private partial struct sigset
        {
        }

        // Called to initialize a new m (including the bootstrap m).
        // Called on the parent thread (main thread in case of bootstrap), can allocate memory.
        private static void mpreinit(ref m mp)
        { 
            // Initialize stack and goroutine for note handling.
            mp.gsignal = malg(32L * 1024L);
            mp.gsignal.m = mp;
            mp.notesig = (int8.Value)(mallocgc(_ERRMAX, null, true)); 
            // Initialize stack for handling strings from the
            // errstr system call, as used in package syscall.
            mp.errstr = (byte.Value)(mallocgc(_ERRMAX, null, true));
        }

        private static void msigsave(ref m mp)
        {
        }

        private static void msigrestore(sigset sigmask)
        {
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static void clearSignalHandlers()
        {
        }

        private static void sigblock()
        {
        }

        // Called to initialize a new m (including the bootstrap m).
        // Called on the new thread, cannot allocate memory.
        private static void minit()
        {
            if (atomic.Load(ref exiting) != 0L)
            {>>MARKER:FUNCTION_open_BLOCK_PREFIX<<
                exits(ref emptystatus[0L]);
            } 
            // Mask all SSE floating-point exceptions
            // when running on the 64-bit kernel.
            setfpmasks();
        }

        // Called from dropm to undo the effect of an minit.
        private static void unminit()
        {
        }

        private static slice<byte> sysstat = (slice<byte>)"/dev/sysstat\x00";

        private static int getproccount()
        {
            array<byte> buf = new array<byte>(2048L);
            var fd = open(ref sysstat[0L], _OREAD, 0L);
            if (fd < 0L)
            {>>MARKER:FUNCTION_closefd_BLOCK_PREFIX<<
                return 1L;
            }
            var ncpu = int32(0L);
            while (true)
            {
                var n = read(fd, @unsafe.Pointer(ref buf), int32(len(buf)));
                if (n <= 0L)
                {
                    break;
                }
                for (var i = int32(0L); i < n; i++)
                {
                    if (buf[i] == '\n')
                    {
                        ncpu++;
                    }
                }

            }

            closefd(fd);
            if (ncpu == 0L)
            {
                ncpu = 1L;
            }
            return ncpu;
        }

        private static slice<byte> devswap = (slice<byte>)"/dev/swap\x00";
        private static slice<byte> pagesize = (slice<byte>)" pagesize\n";

        private static System.UIntPtr getPageSize()
        {
            array<byte> buf = new array<byte>(2048L);
            long pos = default;
            var fd = open(ref devswap[0L], _OREAD, 0L);
            if (fd < 0L)
            { 
                // There's not much we can do if /dev/swap doesn't
                // exist. However, nothing in the memory manager uses
                // this on Plan 9, so it also doesn't really matter.
                return minPhysPageSize;
            }
            while (pos < len(buf))
            {
                var n = read(fd, @unsafe.Pointer(ref buf[pos]), int32(len(buf) - pos));
                if (n <= 0L)
                {
                    break;
                }
                pos += int(n);
            }

            closefd(fd);
            var text = buf[..pos]; 
            // Find "<n> pagesize" line.
            long bol = 0L;
            foreach (var (i, c) in text)
            {
                if (c == '\n')
                {
                    bol = i + 1L;
                }
                if (bytesHasPrefix(text[i..], pagesize))
                { 
                    // Parse number at the beginning of this line.
                    return uintptr(_atoi(text[bol..]));
                }
            } 
            // Again, the page size doesn't really matter, so use a fallback.
            return minPhysPageSize;
        }

        private static bool bytesHasPrefix(slice<byte> s, slice<byte> prefix)
        {
            if (len(s) < len(prefix))
            {
                return false;
            }
            foreach (var (i, p) in prefix)
            {
                if (s[i] != p)
                {
                    return false;
                }
            }
            return true;
        }

        private static slice<byte> pid = (slice<byte>)"#c/pid\x00";

        private static ulong getpid()
        {
            array<byte> b = new array<byte>(20L);
            var fd = open(ref pid[0L], 0L, 0L);
            if (fd >= 0L)
            {
                read(fd, @unsafe.Pointer(ref b), int32(len(b)));
                closefd(fd);
            }
            var c = b[..];
            while (c[0L] == ' ' || c[0L] == '\t')
            {
                c = c[1L..];
            }

            return uint64(_atoi(c));
        }

        private static void osinit()
        {
            initBloc();
            ncpu = getproccount();
            physPageSize = getPageSize();
            getg().m.procid = getpid();
            notify(@unsafe.Pointer(funcPC(sigtramp)));
        }

        private static void crash()
        {
            notify(null) * (int.Value)(null);

            0L;
        }

        //go:nosplit
        private static void getRandomData(slice<byte> r)
        {
            extendRandom(r, 0L);
        }

        private static void goenvs()
        {
        }

        private static void initsig(bool preinit)
        {
        }

        //go:nosplit
        private static void osyield()
        {
            sleep(0L);
        }

        //go:nosplit
        private static void usleep(uint µs)
        {
            var ms = int32(µs / 1000L);
            if (ms == 0L)
            {
                ms = 1L;
            }
            sleep(ms);
        }

        //go:nosplit
        private static long nanotime()
        {
            long scratch = default;
            var ns = nsec(ref scratch); 
            // TODO(aram): remove hack after I fix _nsec in the pc64 kernel.
            if (ns == 0L)
            {
                return scratch;
            }
            return ns;
        }

        //go:nosplit
        private static slice<byte> itoa(slice<byte> buf, ulong val)
        {
            var i = len(buf) - 1L;
            while (val >= 10L)
            {
                buf[i] = byte(val % 10L + '0');
                i--;
                val /= 10L;
            }

            buf[i] = byte(val + '0');
            return buf[i..];
        }

        private static slice<byte> goexits = (slice<byte>)"go: exit ";
        private static slice<byte> emptystatus = (slice<byte>)"\x00";
        private static uint exiting = default;

        private static void goexitsall(ref byte status)
        {
            array<byte> buf = new array<byte>(_ERRMAX);
            if (!atomic.Cas(ref exiting, 0L, 1L))
            {
                return;
            }
            getg().m.locks++;
            var n = copy(buf[..], goexits);
            n = copy(buf[n..], gostringnocopy(status));
            var pid = getpid();
            {
                var mp = (m.Value)(atomic.Loadp(@unsafe.Pointer(ref allm)));

                while (mp != null)
                {
                    if (mp.procid != 0L && mp.procid != pid)
                    {
                        postnote(mp.procid, buf[..]);
                    mp = mp.alllink;
                    }
                }

            }
            getg().m.locks--;
        }

        private static slice<byte> procdir = (slice<byte>)"/proc/";
        private static slice<byte> notefile = (slice<byte>)"/note\x00";

        private static long postnote(ulong pid, slice<byte> msg)
        {
            array<byte> buf = new array<byte>(128L);
            array<byte> tmp = new array<byte>(32L);
            var n = copy(buf[..], procdir);
            n += copy(buf[n..], itoa(tmp[..], pid));
            copy(buf[n..], notefile);
            var fd = open(ref buf[0L], _OWRITE, 0L);
            if (fd < 0L)
            {
                return -1L;
            }
            var len = findnull(ref msg[0L]);
            if (write(uintptr(fd), @unsafe.Pointer(ref msg[0L]), int32(len)) != int64(len))
            {
                closefd(fd);
                return -1L;
            }
            closefd(fd);
            return 0L;
        }

        //go:nosplit
        private static void exit(int e)
        {
            slice<byte> status = default;
            if (e == 0L)
            {
                status = emptystatus;
            }
            else
            { 
                // build error string
                array<byte> tmp = new array<byte>(32L);
                status = append(itoa(tmp[..len(tmp) - 1L], uint64(e)), 0L);
            }
            goexitsall(ref status[0L]);
            exits(ref status[0L]);
        }

        // May run with m.p==nil, so write barriers are not allowed.
        //go:nowritebarrier
        private static void newosproc(ref m mp, unsafe.Pointer stk)
        {
            if (false)
            {
                print("newosproc mp=", mp, " ostk=", ref mp, "\n");
            }
            var pid = rfork(_RFPROC | _RFMEM | _RFNOWAIT);
            if (pid < 0L)
            {
                throw("newosproc: rfork failed");
            }
            if (pid == 0L)
            {
                tstart_plan9(mp);
            }
        }

        private static void exitThread(ref uint wait)
        { 
            // We should never reach exitThread on Plan 9 because we let
            // the OS clean up threads.
            throw("exitThread");
        }

        //go:nosplit
        private static void semacreate(ref m mp)
        {
        }

        //go:nosplit
        private static long semasleep(long ns)
        {
            var _g_ = getg();
            if (ns >= 0L)
            {
                var ms = timediv(ns, 1000000L, null);
                if (ms == 0L)
                {
                    ms = 1L;
                }
                var ret = plan9_tsemacquire(ref _g_.m.waitsemacount, ms);
                if (ret == 1L)
                {
                    return 0L; // success
                }
                return -1L; // timeout or interrupted
            }
            while (plan9_semacquire(ref _g_.m.waitsemacount, 1L) < 0L)
            { 
                // interrupted; try again (c.f. lock_sema.go)
            }

            return 0L; // success
        }

        //go:nosplit
        private static void semawakeup(ref m mp)
        {
            plan9_semrelease(ref mp.waitsemacount, 1L);
        }

        //go:nosplit
        private static int read(int fd, unsafe.Pointer buf, int n)
        {
            return pread(fd, buf, n, -1L);
        }

        //go:nosplit
        private static long write(System.UIntPtr fd, unsafe.Pointer buf, int n)
        {
            return int64(pwrite(int32(fd), buf, n, -1L));
        }

        private static ulong memlimit()
        {
            return 0L;
        }

        private static slice<byte> _badsignal = (slice<byte>)"runtime: signal received on thread not created by Go.\n";

        // This runs on a foreign stack, without an m or a g. No stack split.
        //go:nosplit
        private static void badsignal2()
        {
            pwrite(2L, @unsafe.Pointer(ref _badsignal[0L]), int32(len(_badsignal)), -1L);
            exits(ref _badsignal[0L]);
        }

        private static void raisebadsignal(uint sig)
        {
            badsignal2();
        }

        private static long _atoi(slice<byte> b)
        {
            long n = 0L;
            while (len(b) > 0L && '0' <= b[0L] && b[0L] <= '9')
            {
                n = n * 10L + int(b[0L]) - '0';
                b = b[1L..];
            }

            return n;
        }

        private static @string signame(uint sig)
        {
            if (sig >= uint32(len(sigtable)))
            {
                return "";
            }
            return sigtable[sig].name;
        }
    }
}
