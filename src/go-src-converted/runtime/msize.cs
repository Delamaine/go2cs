// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Malloc small size classes.
//
// See malloc.go for overview.
// See also mksizeclasses.go for how we decide what size classes to use.

// package runtime -- go2cs converted at 2020 August 29 08:18:30 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\msize.go

using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        // Returns size of the memory block that mallocgc will allocate if you ask for the size.
        private static System.UIntPtr roundupsize(System.UIntPtr size)
        {
            if (size < _MaxSmallSize)
            {
                if (size <= smallSizeMax - 8L)
                {
                    return uintptr(class_to_size[size_to_class8[(size + smallSizeDiv - 1L) / smallSizeDiv]]);
                }
                else
                {
                    return uintptr(class_to_size[size_to_class128[(size - smallSizeMax + largeSizeDiv - 1L) / largeSizeDiv]]);
                }
            }
            if (size + _PageSize < size)
            {
                return size;
            }
            return round(size, _PageSize);
        }
    }
}
