// Code generated by "stringer -type EType -trimprefix T"; DO NOT EDIT.

// package types -- go2cs converted at 2020 August 29 08:53:13 UTC
// import "cmd/compile/internal/types" ==> using types = go.cmd.compile.@internal.types_package
// Original source: C:\Go\src\cmd\compile\internal\types\etype_string.go
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        private static readonly @string _EType_name = "xxxINT8UINT8INT16UINT16INT32UINT32INT64UINT64INTUINTUINTPTRCOMPLEX64COMPLEX128FLOAT32FLOAT64BOOLPTR32PTR64FUNCSLICEARRAYSTRUCTCHANMAPINTERFORWANYSTRINGUNSAFEPTRIDEALNILBLANKFUNCARGSCHANARGSDDDFIELDSSATUPLENTYPE";



        private static array<byte> _EType_index = new array<byte>(new byte[] { 0, 3, 7, 12, 17, 23, 28, 34, 39, 45, 48, 52, 59, 68, 78, 85, 92, 96, 101, 106, 110, 115, 120, 126, 130, 133, 138, 142, 145, 151, 160, 165, 168, 173, 181, 189, 197, 200, 205, 210 });

        public static @string String(this EType i)
        {
            if (i >= EType(len(_EType_index) - 1L))
            {
                return fmt.Sprintf("EType(%d)", i);
            }
            return _EType_name[_EType_index[i].._EType_index[i + 1L]];
        }
    }
}}}}
