//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using xml = go.encoding.xml_package;
using go;

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UnexpectedSpacetest
        {
            // Constructors
            public UnexpectedSpacetest(NilType _)
            {
                this.A = default;
                this.B = default;
                this.C = default;
                this.D = default;
                this.E = default;
                this.F = default;
                this.G = default;
                this.H = default;
                this.I = default;
                this.J = default;
                this.K = default;
                this.L = default;
                this.M = default;
                this.N = default;
                this.O = default;
                this.P = default;
                this.Q = default;
            }

            public UnexpectedSpacetest(long A = default, long B = default, long C = default, long D = default, long E = default, long F = default, long G = default, long H = default, long I = default, long J = default, long K = default, long L = default, long M = default, long N = default, long O = default, long P = default, long Q = default)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.E = E;
                this.F = F;
                this.G = G;
                this.H = H;
                this.I = I;
                this.J = J;
                this.K = K;
                this.L = L;
                this.M = M;
                this.N = N;
                this.O = O;
                this.P = P;
                this.Q = Q;
            }

            // Enable comparisons between nil and UnexpectedSpacetest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnexpectedSpacetest value, NilType nil) => value.Equals(default(UnexpectedSpacetest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnexpectedSpacetest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnexpectedSpacetest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnexpectedSpacetest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnexpectedSpacetest(NilType nil) => default(UnexpectedSpacetest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UnexpectedSpacetest UnexpectedSpacetest_cast(dynamic value)
        {
            return new UnexpectedSpacetest(value.A, value.B, value.C, value.D, value.E, value.F, value.G, value.H, value.I, value.J, value.K, value.L, value.M, value.N, value.O, value.P, value.Q);
        }
    }
}}}