// Code generated by mkbuiltin.go. DO NOT EDIT.

// package gc -- go2cs converted at 2020 August 29 09:25:55 UTC
// import "cmd/compile/internal/gc" ==> using gc = go.cmd.compile.@internal.gc_package
// Original source: C:\Go\src\cmd\compile\internal\gc\builtin.go
using types = go.cmd.compile.@internal.types_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {


        private static slice<ref types.Type> runtimeTypes()
        {
            array<ref types.Type> typs = new array<ref types.Type>(115L);
            typs[0L] = types.Bytetype;
            typs[1L] = types.NewPtr(typs[0L]);
            typs[2L] = types.Types[TANY];
            typs[3L] = types.NewPtr(typs[2L]);
            typs[4L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]) }));
            typs[5L] = functype(null, null, null);
            typs[6L] = types.Types[TINTER];
            typs[7L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[6]) }), null);
            typs[8L] = types.Types[TINT32];
            typs[9L] = types.NewPtr(typs[8L]);
            typs[10L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[9]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[6]) }));
            typs[11L] = types.Types[TBOOL];
            typs[12L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }), null);
            typs[13L] = types.Types[TFLOAT64];
            typs[14L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }), null);
            typs[15L] = types.Types[TINT64];
            typs[16L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[15]) }), null);
            typs[17L] = types.Types[TUINT64];
            typs[18L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[17]) }), null);
            typs[19L] = types.Types[TCOMPLEX128];
            typs[20L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[19]) }), null);
            typs[21L] = types.Types[TSTRING];
            typs[22L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }), null);
            typs[23L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[2]) }), null);
            typs[24L] = types.NewArray(typs[0L], 32L);
            typs[25L] = types.NewPtr(typs[24L]);
            typs[26L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[21]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[27L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[21]), anonfield(typs[21]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[28L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[21]), anonfield(typs[21]), anonfield(typs[21]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[29L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[21]), anonfield(typs[21]), anonfield(typs[21]), anonfield(typs[21]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[30L] = types.NewSlice(typs[21L]);
            typs[31L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[30]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[32L] = types.Types[TINT];
            typs[33L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[21]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[32]) }));
            typs[34L] = types.NewArray(typs[0L], 4L);
            typs[35L] = types.NewPtr(typs[34L]);
            typs[36L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[35]), anonfield(typs[15]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[37L] = types.NewSlice(typs[0L]);
            typs[38L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[37]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[39L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[37]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[40L] = types.Runetype;
            typs[41L] = types.NewSlice(typs[40L]);
            typs[42L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[41]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[21]) }));
            typs[43L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[25]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[37]) }));
            typs[44L] = types.NewArray(typs[40L], 32L);
            typs[45L] = types.NewPtr(typs[44L]);
            typs[46L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[45]), anonfield(typs[21]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[41]) }));
            typs[47L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[21]), anonfield(typs[32]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[40]), anonfield(typs[32]) }));
            typs[48L] = types.Types[TUINTPTR];
            typs[49L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[2]), anonfield(typs[2]), anonfield(typs[48]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[32]) }));
            typs[50L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[2]), anonfield(typs[2]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[32]) }));
            typs[51L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[2]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[2]) }));
            typs[52L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[2]) }));
            typs[53L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[2]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[2]), anonfield(typs[11]) }));
            typs[54L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[1]), anonfield(typs[1]) }), null);
            typs[55L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]) }), null);
            typs[56L] = types.NewPtr(typs[48L]);
            typs[57L] = types.Types[TUNSAFEPTR];
            typs[58L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[56]), anonfield(typs[57]), anonfield(typs[57]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[59L] = types.Types[TUINT32];
            typs[60L] = functype(null, null, new slice<ref Node>(new ref Node[] { anonfield(typs[59]) }));
            typs[61L] = types.NewMap(typs[2L], typs[2L]);
            typs[62L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[61]) }));
            typs[63L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[32]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[61]) }));
            typs[64L] = functype(null, null, new slice<ref Node>(new ref Node[] { anonfield(typs[61]) }));
            typs[65L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]) }));
            typs[66L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[2]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]) }));
            typs[67L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[3]), anonfield(typs[1]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]) }));
            typs[68L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[11]) }));
            typs[69L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[2]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[11]) }));
            typs[70L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[3]), anonfield(typs[1]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[11]) }));
            typs[71L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[3]) }), null);
            typs[72L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[61]), anonfield(typs[2]) }), null);
            typs[73L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]) }), null);
            typs[74L] = types.NewChan(typs[2L], types.Cboth);
            typs[75L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[15]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[74]) }));
            typs[76L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[32]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[74]) }));
            typs[77L] = types.NewChan(typs[2L], types.Crecv);
            typs[78L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[77]), anonfield(typs[3]) }), null);
            typs[79L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[77]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[80L] = types.NewChan(typs[2L], types.Csend);
            typs[81L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[80]), anonfield(typs[3]) }), null);
            typs[82L] = types.NewArray(typs[0L], 3L);
            typs[83L] = tostruct(new slice<ref Node>(new ref Node[] { namedfield("enabled",typs[11]), namedfield("pad",typs[82]), namedfield("needed",typs[11]), namedfield("cgo",typs[11]), namedfield("alignme",typs[17]) }));
            typs[84L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[2]) }), null);
            typs[85L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[3]), anonfield(typs[3]) }), null);
            typs[86L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[3]) }), null);
            typs[87L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[2]), anonfield(typs[2]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[32]) }));
            typs[88L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[80]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[89L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[77]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[90L] = types.NewPtr(typs[11L]);
            typs[91L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[90]), anonfield(typs[77]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[92L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[8]) }), null);
            typs[93L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[80]), anonfield(typs[3]) }), null);
            typs[94L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[77]), anonfield(typs[3]), anonfield(typs[90]) }), null);
            typs[95L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[32]) }));
            typs[96L] = types.NewSlice(typs[2L]);
            typs[97L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[32]), anonfield(typs[32]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[96]) }));
            typs[98L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[15]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[96]) }));
            typs[99L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[1]), anonfield(typs[96]), anonfield(typs[32]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[96]) }));
            typs[100L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[3]), anonfield(typs[48]) }), null);
            typs[101L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[57]), anonfield(typs[48]) }), null);
            typs[102L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[3]), anonfield(typs[48]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[103L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[3]), anonfield(typs[3]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[11]) }));
            typs[104L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[15]), anonfield(typs[15]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[15]) }));
            typs[105L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[17]), anonfield(typs[17]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[17]) }));
            typs[106L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[15]) }));
            typs[107L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[17]) }));
            typs[108L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[59]) }));
            typs[109L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[15]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }));
            typs[110L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[17]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }));
            typs[111L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[59]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[13]) }));
            typs[112L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[19]), anonfield(typs[19]) }), new slice<ref Node>(new ref Node[] { anonfield(typs[19]) }));
            typs[113L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[48]) }), null);
            typs[114L] = functype(null, new slice<ref Node>(new ref Node[] { anonfield(typs[48]), anonfield(typs[48]) }), null);
            return typs[..];
        }
    }
}}}}
