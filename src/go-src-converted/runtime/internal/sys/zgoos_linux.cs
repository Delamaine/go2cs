// Code generated by gengoos.go using 'go generate'. DO NOT EDIT.

// +build !android
// +build linux

// package sys -- go2cs converted at 2020 August 29 08:16:27 UTC
// import "runtime/internal/sys" ==> using sys = go.runtime.@internal.sys_package
// Original source: C:\Go\src\runtime\internal\sys\zgoos_linux.go

using static go.builtin;

namespace go {
namespace runtime {
namespace @internal
{
    public static partial class sys_package
    {
        public static readonly @string GOOS = "linux";



        public static readonly long GoosAndroid = 0L;

        public static readonly long GoosDarwin = 0L;

        public static readonly long GoosDragonfly = 0L;

        public static readonly long GoosFreebsd = 0L;

        public static readonly long GoosLinux = 1L;

        public static readonly long GoosNacl = 0L;

        public static readonly long GoosNetbsd = 0L;

        public static readonly long GoosOpenbsd = 0L;

        public static readonly long GoosPlan9 = 0L;

        public static readonly long GoosSolaris = 0L;

        public static readonly long GoosWindows = 0L;

        public static readonly long GoosZos = 0L;

    }
}}}
