// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 August 29 08:17:49 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\mem_windows.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private static readonly ulong _MEM_COMMIT = 0x1000UL;
        private static readonly ulong _MEM_RESERVE = 0x2000UL;
        private static readonly ulong _MEM_DECOMMIT = 0x4000UL;
        private static readonly ulong _MEM_RELEASE = 0x8000UL;

        private static readonly ulong _PAGE_READWRITE = 0x0004UL;
        private static readonly ulong _PAGE_NOACCESS = 0x0001UL;

        private static readonly long _ERROR_NOT_ENOUGH_MEMORY = 8L;
        private static readonly long _ERROR_COMMITMENT_LIMIT = 1455L;

        // Don't split the stack as this function may be invoked without a valid G,
        // which prevents us from allocating more stack.
        //go:nosplit
        private static unsafe.Pointer sysAlloc(System.UIntPtr n, ref ulong sysStat)
        {
            mSysStatInc(sysStat, n);
            return @unsafe.Pointer(stdcall4(_VirtualAlloc, 0L, n, _MEM_COMMIT | _MEM_RESERVE, _PAGE_READWRITE));
        }

        private static void sysUnused(unsafe.Pointer v, System.UIntPtr n)
        {
            var r = stdcall3(_VirtualFree, uintptr(v), n, _MEM_DECOMMIT);
            if (r != 0L)
            {
                return;
            } 

            // Decommit failed. Usual reason is that we've merged memory from two different
            // VirtualAlloc calls, and Windows will only let each VirtualFree handle pages from
            // a single VirtualAlloc. It is okay to specify a subset of the pages from a single alloc,
            // just not pages from multiple allocs. This is a rare case, arising only when we're
            // trying to give memory back to the operating system, which happens on a time
            // scale of minutes. It doesn't have to be terribly fast. Instead of extra bookkeeping
            // on all our VirtualAlloc calls, try freeing successively smaller pieces until
            // we manage to free something, and then repeat. This ends up being O(n log n)
            // in the worst case, but that's fast enough.
            while (n > 0L)
            {
                var small = n;
                while (small >= 4096L && stdcall3(_VirtualFree, uintptr(v), small, _MEM_DECOMMIT) == 0L)
                {
                    small /= 2L;
                    small &= 4096L - 1L;
                }

                if (small < 4096L)
                {
                    print("runtime: VirtualFree of ", small, " bytes failed with errno=", getlasterror(), "\n");
                    throw("runtime: failed to decommit pages");
                }
                v = add(v, small);
                n -= small;
            }

        }

        private static void sysUsed(unsafe.Pointer v, System.UIntPtr n)
        {
            var r = stdcall4(_VirtualAlloc, uintptr(v), n, _MEM_COMMIT, _PAGE_READWRITE);
            if (r == uintptr(v))
            {
                return;
            } 

            // Commit failed. See SysUnused.
            while (n > 0L)
            {
                var small = n;
                while (small >= 4096L && stdcall4(_VirtualAlloc, uintptr(v), small, _MEM_COMMIT, _PAGE_READWRITE) == 0L)
                {
                    small /= 2L;
                    small &= 4096L - 1L;
                }

                if (small < 4096L)
                {
                    print("runtime: VirtualAlloc of ", small, " bytes failed with errno=", getlasterror(), "\n");
                    throw("runtime: failed to commit pages");
                }
                v = add(v, small);
                n -= small;
            }

        }

        // Don't split the stack as this function may be invoked without a valid G,
        // which prevents us from allocating more stack.
        //go:nosplit
        private static void sysFree(unsafe.Pointer v, System.UIntPtr n, ref ulong sysStat)
        {
            mSysStatDec(sysStat, n);
            var r = stdcall3(_VirtualFree, uintptr(v), 0L, _MEM_RELEASE);
            if (r == 0L)
            {
                print("runtime: VirtualFree of ", n, " bytes failed with errno=", getlasterror(), "\n");
                throw("runtime: failed to release pages");
            }
        }

        private static void sysFault(unsafe.Pointer v, System.UIntPtr n)
        { 
            // SysUnused makes the memory inaccessible and prevents its reuse
            sysUnused(v, n);
        }

        private static unsafe.Pointer sysReserve(unsafe.Pointer v, System.UIntPtr n, ref bool reserved)
        {
            reserved.Value = true; 
            // v is just a hint.
            // First try at v.
            v = @unsafe.Pointer(stdcall4(_VirtualAlloc, uintptr(v), n, _MEM_RESERVE, _PAGE_READWRITE));
            if (v != null)
            {
                return v;
            } 

            // Next let the kernel choose the address.
            return @unsafe.Pointer(stdcall4(_VirtualAlloc, 0L, n, _MEM_RESERVE, _PAGE_READWRITE));
        }

        private static void sysMap(unsafe.Pointer v, System.UIntPtr n, bool reserved, ref ulong sysStat)
        {
            mSysStatInc(sysStat, n);
            var p = stdcall4(_VirtualAlloc, uintptr(v), n, _MEM_COMMIT, _PAGE_READWRITE);
            if (p != uintptr(v))
            {
                var errno = getlasterror();
                print("runtime: VirtualAlloc of ", n, " bytes failed with errno=", errno, "\n");

                if (errno == _ERROR_NOT_ENOUGH_MEMORY || errno == _ERROR_COMMITMENT_LIMIT) 
                    throw("out of memory");
                else 
                    throw("runtime: cannot map pages in arena address space");
                            }
        }
    }
}
