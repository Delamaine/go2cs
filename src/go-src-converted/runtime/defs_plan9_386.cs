// package runtime -- go2cs converted at 2020 August 29 08:16:51 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\defs_plan9_386.go

using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private static readonly ulong _PAGESIZE = 0x1000UL;



        private partial struct ureg
        {
            public uint di; /* general registers */
            public uint si; /* ... */
            public uint bp; /* ... */
            public uint nsp;
            public uint bx; /* ... */
            public uint dx; /* ... */
            public uint cx; /* ... */
            public uint ax; /* ... */
            public uint gs; /* data segments */
            public uint fs; /* ... */
            public uint es; /* ... */
            public uint ds; /* ... */
            public uint trap; /* trap _type */
            public uint ecode; /* error code (or zero) */
            public uint pc; /* pc */
            public uint cs; /* old context */
            public uint flags; /* old flags */
            public uint sp;
            public uint ss; /* old stack segment */
        }

        private partial struct sigctxt
        {
            public ptr<ureg> u;
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static System.UIntPtr pc(this ref sigctxt c)
        {
            return uintptr(c.u.pc);
        }

        private static System.UIntPtr sp(this ref sigctxt c)
        {
            return uintptr(c.u.sp);
        }
        private static System.UIntPtr lr(this ref sigctxt c)
        {
            return uintptr(0L);
        }

        private static void setpc(this ref sigctxt c, System.UIntPtr x)
        {
            c.u.pc = uint32(x);

        }
        private static void setsp(this ref sigctxt c, System.UIntPtr x)
        {
            c.u.sp = uint32(x);

        }
        private static void setlr(this ref sigctxt c, System.UIntPtr x)
        {
        }

        private static void savelr(this ref sigctxt c, System.UIntPtr x)
        {
        }

        private static void dumpregs(ref ureg u)
        {
            print("ax    ", hex(u.ax), "\n");
            print("bx    ", hex(u.bx), "\n");
            print("cx    ", hex(u.cx), "\n");
            print("dx    ", hex(u.dx), "\n");
            print("di    ", hex(u.di), "\n");
            print("si    ", hex(u.si), "\n");
            print("bp    ", hex(u.bp), "\n");
            print("sp    ", hex(u.sp), "\n");
            print("pc    ", hex(u.pc), "\n");
            print("flags ", hex(u.flags), "\n");
            print("cs    ", hex(u.cs), "\n");
            print("fs    ", hex(u.fs), "\n");
            print("gs    ", hex(u.gs), "\n");
        }

        private static void sigpanictramp()
        {
        }
    }
}
