// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Garbage collector: finalizers and block profiling.

// package runtime -- go2cs converted at 2020 August 29 08:17:52 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\mfinal.go
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;
using System;
using System.Threading;

namespace go
{
    public static unsafe partial class runtime_package
    {
        // finblock is an array of finalizers to be executed. finblocks are
        // arranged in a linked list for the finalizer queue.
        //
        // finblock is allocated from non-GC'd memory, so any heap pointers
        // must be specially handled. GC currently assumes that the finalizer
        // queue does not grow during marking (but it can shrink).
        //
        //go:notinheap
        private partial struct finblock
        {
            public ptr<finblock> alllink;
            public ptr<finblock> next;
            public uint cnt;
            public int _;
            public array<finalizer> fin;
        }

        private static mutex finlock = default; // protects the following variables
        private static ref g fing = default; // goroutine that runs finalizers
        private static ref finblock finq = default; // list of finalizers that are to be executed
        private static ref finblock finc = default; // cache of free blocks
        private static array<byte> finptrmask = new array<byte>(_FinBlockSize / sys.PtrSize / 8L);
        private static bool fingwait = default;
        private static bool fingwake = default;
        private static ref finblock allfin = default; // list of all blocks

        // NOTE: Layout known to queuefinalizer.
        private partial struct finalizer
        {
            public ptr<funcval> fn; // function to call (may be a heap pointer)
            public unsafe.Pointer arg; // ptr to object (may be a heap pointer)
            public System.UIntPtr nret; // bytes of return values from fn
            public ptr<_type> fint; // type of first argument of fn
            public ptr<ptrtype> ot; // type of ptr to object (may be a heap pointer)
        }

        private static array<byte> finalizer1 = new array<byte>(new byte[] { 1<<0|1<<1|0<<2|1<<3|1<<4|1<<5|1<<6|0<<7, 1<<0|1<<1|1<<2|1<<3|0<<4|1<<5|1<<6|1<<7, 1<<0|0<<1|1<<2|1<<3|1<<4|1<<5|0<<6|1<<7, 1<<0|1<<1|1<<2|0<<3|1<<4|1<<5|1<<6|1<<7, 0<<0|1<<1|1<<2|1<<3|1<<4|0<<5|1<<6|1<<7 });

        private static void queuefinalizer(unsafe.Pointer p, ref funcval fn, System.UIntPtr nret, ref _type fint, ref ptrtype ot)
        {
            if (gcphase != _GCoff)
            { 
                // Currently we assume that the finalizer queue won't
                // grow during marking so we don't have to rescan it
                // during mark termination. If we ever need to lift
                // this assumption, we can do it by adding the
                // necessary barriers to queuefinalizer (which it may
                // have automatically).
                throw("queuefinalizer during GC");
            }
            lock(ref finlock);
            if (finq == null || finq.cnt == uint32(len(finq.fin)))
            {
                if (finc == null)
                {
                    finc = (finblock.Value)(persistentalloc(_FinBlockSize, 0L, ref memstats.gc_sys));
                    finc.alllink = allfin;
                    allfin = finc;
                    if (finptrmask[0L] == 0L)
                    { 
                        // Build pointer mask for Finalizer array in block.
                        // Check assumptions made in finalizer1 array above.
                        if ((@unsafe.Sizeof(new finalizer()) != 5L * sys.PtrSize || @unsafe.Offsetof(new finalizer().fn) != 0L || @unsafe.Offsetof(new finalizer().arg) != sys.PtrSize || @unsafe.Offsetof(new finalizer().nret) != 2L * sys.PtrSize || @unsafe.Offsetof(new finalizer().fint) != 3L * sys.PtrSize || @unsafe.Offsetof(new finalizer().ot) != 4L * sys.PtrSize))
                        {
                            throw("finalizer out of sync");
                        }
                        foreach (var (i) in finptrmask)
                        {
                            finptrmask[i] = finalizer1[i % len(finalizer1)];
                        }
                    }
                }
                var block = finc;
                finc = block.next;
                block.next = finq;
                finq = block;
            }
            var f = ref finq.fin[finq.cnt];
            atomic.Xadd(ref finq.cnt, +1L); // Sync with markroots
            f.fn = fn;
            f.nret = nret;
            f.fint = fint;
            f.ot = ot;
            f.arg = p;
            fingwake = true;
            unlock(ref finlock);
        }

        //go:nowritebarrier
        private static void iterate_finq(Action<ref funcval, unsafe.Pointer, System.UIntPtr, ref _type, ref ptrtype> callback)
        {
            {
                var fb = allfin;

                while (fb != null)
                {
                    for (var i = uint32(0L); i < fb.cnt; i++)
                    {
                        var f = ref fb.fin[i];
                        callback(f.fn, f.arg, f.nret, f.fint, f.ot);
                    }

                    fb = fb.alllink;
                }

            }
        }

        private static ref g wakefing()
        {
            ref g res = default;
            lock(ref finlock);
            if (fingwait && fingwake)
            {
                fingwait = false;
                fingwake = false;
                res = fing;
            }
            unlock(ref finlock);
            return res;
        }

        private static uint fingCreate = default;        private static bool fingRunning = default;

        private static void createfing()
        { 
            // start the finalizer goroutine exactly once
            if (fingCreate == 0L && atomic.Cas(ref fingCreate, 0L, 1L))
            {
                go_(() => runfinq());
            }
        }

        // This is the goroutine that runs all of the finalizers
        private static void runfinq()
        {
            unsafe.Pointer frame = default;            System.UIntPtr framecap = default;

            while (true)
            {
                lock(ref finlock);
                var fb = finq;
                finq = null;
                if (fb == null)
                {
                    var gp = getg();
                    fing = gp;
                    fingwait = true;
                    goparkunlock(ref finlock, "finalizer wait", traceEvGoBlock, 1L);
                    continue;
                }
                unlock(ref finlock);
                if (raceenabled)
                {
                    racefingo();
                }
                while (fb != null)
                {
                    for (var i = fb.cnt; i > 0L; i--)
                    {
                        var f = ref fb.fin[i - 1L];

                        var framesz = @unsafe.Sizeof() + f.nret;
                        if (framecap < framesz)
                        { 
                            // The frame does not contain pointers interesting for GC,
                            // all not yet finalized objects are stored in finq.
                            // If we do not mark it as FlagNoScan,
                            // the last finalized object is not collected.
                            frame = mallocgc(framesz, null, true);
                            framecap = framesz;
                        }
                        if (f.fint == null)
                        {
                            throw("missing type in runfinq");
                        } 
                        // frame is effectively uninitialized
                        // memory. That means we have to clear
                        // it before writing to it to avoid
                        // confusing the write barrier.
                        frame.Value = new array<System.UIntPtr>(new System.UIntPtr[] {  });

                        if (f.fint.kind & kindMask == kindPtr) 
                            // direct use of pointer
                            (@unsafe.Pointer.Value)(frame).Value;

                            f.arg;
                        else if (f.fint.kind & kindMask == kindInterface) 
                            var ityp = (interfacetype.Value)(@unsafe.Pointer(f.fint))(eface.Value)(frame)._type;

                            ref f.ot.typ(eface.Value)(frame).data;

                            f.arg;
                            if (len(ityp.mhdr) != 0L)
                            { 
                                // convert to interface with methods
                                // this conversion is guaranteed to succeed - we checked in SetFinalizer
                                (iface.Value)(frame).Value;

                                assertE2I(ityp, frame.Value);
                            }
                        else 
                            throw("bad kind in runfinq");
                                                fingRunning = true;
                        reflectcall(null, @unsafe.Pointer(f.fn), frame, uint32(framesz), uint32(framesz));
                        fingRunning = false; 

                        // Drop finalizer queue heap references
                        // before hiding them from markroot.
                        // This also ensures these will be
                        // clear if we reuse the finalizer.
                        f.fn = null;
                        f.arg = null;
                        f.ot = null;
                        atomic.Store(ref fb.cnt, i - 1L);
                    }

                    var next = fb.next;
                    lock(ref finlock);
                    fb.next = finc;
                    finc = fb;
                    unlock(ref finlock);
                    fb = next;
                }

            }

        }

        // SetFinalizer sets the finalizer associated with obj to the provided
        // finalizer function. When the garbage collector finds an unreachable block
        // with an associated finalizer, it clears the association and runs
        // finalizer(obj) in a separate goroutine. This makes obj reachable again,
        // but now without an associated finalizer. Assuming that SetFinalizer
        // is not called again, the next time the garbage collector sees
        // that obj is unreachable, it will free obj.
        //
        // SetFinalizer(obj, nil) clears any finalizer associated with obj.
        //
        // The argument obj must be a pointer to an object allocated by calling
        // new, by taking the address of a composite literal, or by taking the
        // address of a local variable.
        // The argument finalizer must be a function that takes a single argument
        // to which obj's type can be assigned, and can have arbitrary ignored return
        // values. If either of these is not true, SetFinalizer may abort the
        // program.
        //
        // Finalizers are run in dependency order: if A points at B, both have
        // finalizers, and they are otherwise unreachable, only the finalizer
        // for A runs; once A is freed, the finalizer for B can run.
        // If a cyclic structure includes a block with a finalizer, that
        // cycle is not guaranteed to be garbage collected and the finalizer
        // is not guaranteed to run, because there is no ordering that
        // respects the dependencies.
        //
        // The finalizer for obj is scheduled to run at some arbitrary time after
        // obj becomes unreachable.
        // There is no guarantee that finalizers will run before a program exits,
        // so typically they are useful only for releasing non-memory resources
        // associated with an object during a long-running program.
        // For example, an os.File object could use a finalizer to close the
        // associated operating system file descriptor when a program discards
        // an os.File without calling Close, but it would be a mistake
        // to depend on a finalizer to flush an in-memory I/O buffer such as a
        // bufio.Writer, because the buffer would not be flushed at program exit.
        //
        // It is not guaranteed that a finalizer will run if the size of *obj is
        // zero bytes.
        //
        // It is not guaranteed that a finalizer will run for objects allocated
        // in initializers for package-level variables. Such objects may be
        // linker-allocated, not heap-allocated.
        //
        // A finalizer may run as soon as an object becomes unreachable.
        // In order to use finalizers correctly, the program must ensure that
        // the object is reachable until it is no longer required.
        // Objects stored in global variables, or that can be found by tracing
        // pointers from a global variable, are reachable. For other objects,
        // pass the object to a call of the KeepAlive function to mark the
        // last point in the function where the object must be reachable.
        //
        // For example, if p points to a struct that contains a file descriptor d,
        // and p has a finalizer that closes that file descriptor, and if the last
        // use of p in a function is a call to syscall.Write(p.d, buf, size), then
        // p may be unreachable as soon as the program enters syscall.Write. The
        // finalizer may run at that moment, closing p.d, causing syscall.Write
        // to fail because it is writing to a closed file descriptor (or, worse,
        // to an entirely different file descriptor opened by a different goroutine).
        // To avoid this problem, call runtime.KeepAlive(p) after the call to
        // syscall.Write.
        //
        // A single goroutine runs all finalizers for a program, sequentially.
        // If a finalizer must run for a long time, it should do so by starting
        // a new goroutine.
        public static void SetFinalizer(object obj, object finalizer)
        {
            if (debug.sbrk != 0L)
            { 
                // debug.sbrk never frees memory, so no finalizers run
                // (and we don't have the data structures to record them).
                return;
            }
            var e = efaceOf(ref obj);
            var etyp = e._type;
            if (etyp == null)
            {
                throw("runtime.SetFinalizer: first argument is nil");
            }
            if (etyp.kind & kindMask != kindPtr)
            {
                throw("runtime.SetFinalizer: first argument is " + etyp.@string() + ", not pointer");
            }
            var ot = (ptrtype.Value)(@unsafe.Pointer(etyp));
            if (ot.elem == null)
            {
                throw("nil elem type!");
            } 

            // find the containing object
            var (_, base, _) = findObject(e.data);

            if (base == null)
            { 
                // 0-length objects are okay.
                if (e.data == @unsafe.Pointer(ref zerobase))
                {
                    return;
                } 

                // Global initializers might be linker-allocated.
                //    var Foo = &Object{}
                //    func main() {
                //        runtime.SetFinalizer(Foo, nil)
                //    }
                // The relevant segments are: noptrdata, data, bss, noptrbss.
                // We cannot assume they are in any order or even contiguous,
                // due to external linking.
                {
                    var datap = ref firstmoduledata;

                    while (datap != null)
                    {
                        if (datap.noptrdata <= uintptr(e.data) && uintptr(e.data) < datap.enoptrdata || datap.data <= uintptr(e.data) && uintptr(e.data) < datap.edata || datap.bss <= uintptr(e.data) && uintptr(e.data) < datap.ebss || datap.noptrbss <= uintptr(e.data) && uintptr(e.data) < datap.enoptrbss)
                        {
                            return;
                        datap = datap.next;
                        }
                    }

                }
                throw("runtime.SetFinalizer: pointer not in allocated block");
            }
            if (e.data != base)
            { 
                // As an implementation detail we allow to set finalizers for an inner byte
                // of an object if it could come from tiny alloc (see mallocgc for details).
                if (ot.elem == null || ot.elem.kind & kindNoPointers == 0L || ot.elem.size >= maxTinySize)
                {
                    throw("runtime.SetFinalizer: pointer not at beginning of allocated block");
                }
            }
            var f = efaceOf(ref finalizer);
            var ftyp = f._type;
            if (ftyp == null)
            { 
                // switch to system stack and remove finalizer
                systemstack(() =>
                {
                    removefinalizer(e.data);
                });
                return;
            }
            if (ftyp.kind & kindMask != kindFunc)
            {
                throw("runtime.SetFinalizer: second argument is " + ftyp.@string() + ", not a function");
            }
            var ft = (functype.Value)(@unsafe.Pointer(ftyp));
            if (ft.dotdotdot())
            {
                throw("runtime.SetFinalizer: cannot pass " + etyp.@string() + " to finalizer " + ftyp.@string() + " because dotdotdot");
            }
            if (ft.inCount != 1L)
            {
                throw("runtime.SetFinalizer: cannot pass " + etyp.@string() + " to finalizer " + ftyp.@string());
            }
            var fint = ft.@in()[0L];

            if (fint == etyp) 
                // ok - same type
                goto okarg;
            else if (fint.kind & kindMask == kindPtr) 
                if ((fint.uncommon() == null || etyp.uncommon() == null) && (ptrtype.Value)(@unsafe.Pointer(fint)).elem == ot.elem)
                { 
                    // ok - not same type, but both pointers,
                    // one or the other is unnamed, and same element type, so assignable.
                    goto okarg;
                }
            else if (fint.kind & kindMask == kindInterface) 
                var ityp = (interfacetype.Value)(@unsafe.Pointer(fint));
                if (len(ityp.mhdr) == 0L)
                { 
                    // ok - satisfies empty interface
                    goto okarg;
                }
                {
                    var (_, ok) = assertE2I2(ityp, new ptr<ref efaceOf>(ref obj));

                    if (ok)
                    {
                        goto okarg;
                    }

                }
                        throw("runtime.SetFinalizer: cannot pass " + etyp.@string() + " to finalizer " + ftyp.@string());
okarg:
            var nret = uintptr(0L);
            foreach (var (_, t) in ft.@out())
            {
                nret = round(nret, uintptr(t.align)) + uintptr(t.size);
            }
            nret = round(nret, sys.PtrSize); 

            // make sure we have a finalizer goroutine
            createfing();

            systemstack(() =>
            {
                if (!addfinalizer(e.data, (funcval.Value)(f.data), nret, fint, ot))
                {
                    throw("runtime.SetFinalizer: finalizer already set");
                }
            });
        }

        // Look up pointer v in heap. Return the span containing the object,
        // the start of the object, and the size of the object. If the object
        // does not exist, return nil, nil, 0.
        private static (ref mspan, unsafe.Pointer, System.UIntPtr) findObject(unsafe.Pointer v)
        {
            var c = gomcache();
            c.local_nlookup++;
            if (sys.PtrSize == 4L && c.local_nlookup >= 1L << (int)(30L))
            { 
                // purge cache stats to prevent overflow
                lock(ref mheap_.@lock);
                purgecachedstats(c);
                unlock(ref mheap_.@lock);
            } 

            // find span
            var arena_start = mheap_.arena_start;
            var arena_used = mheap_.arena_used;
            if (uintptr(v) < arena_start || uintptr(v) >= arena_used)
            {
                return;
            }
            var p = uintptr(v) >> (int)(pageShift);
            var q = p - arena_start >> (int)(pageShift);
            s = mheap_.spans[q];
            if (s == null)
            {
                return;
            }
            x = @unsafe.Pointer(s.@base());

            if (uintptr(v) < uintptr(x) || uintptr(v) >= uintptr(@unsafe.Pointer(s.limit)) || s.state != mSpanInUse)
            {
                s = null;
                x = null;
                return;
            }
            n = s.elemsize;
            if (s.spanclass.sizeclass() != 0L)
            {
                x = add(x, (uintptr(v) - uintptr(x)) / n * n);
            }
            return;
        }

        // Mark KeepAlive as noinline so that it is easily detectable as an intrinsic.
        //go:noinline

        // KeepAlive marks its argument as currently reachable.
        // This ensures that the object is not freed, and its finalizer is not run,
        // before the point in the program where KeepAlive is called.
        //
        // A very simplified example showing where KeepAlive is required:
        //     type File struct { d int }
        //     d, err := syscall.Open("/file/path", syscall.O_RDONLY, 0)
        //     // ... do something if err != nil ...
        //     p := &File{d}
        //     runtime.SetFinalizer(p, func(p *File) { syscall.Close(p.d) })
        //     var buf [10]byte
        //     n, err := syscall.Read(p.d, buf[:])
        //     // Ensure p is not finalized until Read returns.
        //     runtime.KeepAlive(p)
        //     // No more uses of p after this point.
        //
        // Without the KeepAlive call, the finalizer could run at the start of
        // syscall.Read, closing the file descriptor before syscall.Read makes
        // the actual system call.
        public static void KeepAlive(object x)
        { 
            // Introduce a use of x that the compiler can't eliminate.
            // This makes sure x is alive on entry. We need x to be alive
            // on entry for "defer runtime.KeepAlive(x)"; see issue 21402.
            if (cgoAlwaysFalse)
            {
                println(x);
            }
        }
    }
}
