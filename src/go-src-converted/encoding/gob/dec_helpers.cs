// Created by decgen --output dec_helpers.go; DO NOT EDIT

// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package gob -- go2cs converted at 2020 August 29 08:35:28 UTC
// import "encoding/gob" ==> using gob = go.encoding.gob_package
// Original source: C:\Go\src\encoding\gob\dec_helpers.go
using math = go.math_package;
using reflect = go.reflect_package;
using static go.builtin;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        private static map decArrayHelper = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<reflect.Kind, decHelper>{reflect.Bool:decBoolArray,reflect.Complex64:decComplex64Array,reflect.Complex128:decComplex128Array,reflect.Float32:decFloat32Array,reflect.Float64:decFloat64Array,reflect.Int:decIntArray,reflect.Int16:decInt16Array,reflect.Int32:decInt32Array,reflect.Int64:decInt64Array,reflect.Int8:decInt8Array,reflect.String:decStringArray,reflect.Uint:decUintArray,reflect.Uint16:decUint16Array,reflect.Uint32:decUint32Array,reflect.Uint64:decUint64Array,reflect.Uintptr:decUintptrArray,};

        private static map decSliceHelper = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<reflect.Kind, decHelper>{reflect.Bool:decBoolSlice,reflect.Complex64:decComplex64Slice,reflect.Complex128:decComplex128Slice,reflect.Float32:decFloat32Slice,reflect.Float64:decFloat64Slice,reflect.Int:decIntSlice,reflect.Int16:decInt16Slice,reflect.Int32:decInt32Slice,reflect.Int64:decInt64Slice,reflect.Int8:decInt8Slice,reflect.String:decStringSlice,reflect.Uint:decUintSlice,reflect.Uint16:decUint16Slice,reflect.Uint32:decUint32Slice,reflect.Uint64:decUint64Slice,reflect.Uintptr:decUintptrSlice,};

        private static bool decBoolArray(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decBoolSlice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decBoolSlice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<bool> (slice, ok) = v.Interface()._<slice<bool>>();
            if (!ok)
            { 
                // It is kind bool but not type bool. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding bool array or slice: length exceeds input size (%d elements)", length);
                }
                slice[i] = state.decodeUint() != 0L;
            }

            return true;
        }

        private static bool decComplex64Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decComplex64Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decComplex64Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<complex64> (slice, ok) = v.Interface()._<slice<complex64>>();
            if (!ok)
            { 
                // It is kind complex64 but not type complex64. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding complex64 array or slice: length exceeds input size (%d elements)", length);
                }
                var real = float32FromBits(state.decodeUint(), ovfl);
                var imag = float32FromBits(state.decodeUint(), ovfl);
                slice[i] = complex(float32(real), float32(imag));
            }

            return true;
        }

        private static bool decComplex128Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decComplex128Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decComplex128Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<System.Numerics.Complex128> (slice, ok) = v.Interface()._<slice<System.Numerics.Complex128>>();
            if (!ok)
            { 
                // It is kind complex128 but not type complex128. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding complex128 array or slice: length exceeds input size (%d elements)", length);
                }
                var real = float64FromBits(state.decodeUint());
                var imag = float64FromBits(state.decodeUint());
                slice[i] = complex(real, imag);
            }

            return true;
        }

        private static bool decFloat32Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decFloat32Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decFloat32Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<float> (slice, ok) = v.Interface()._<slice<float>>();
            if (!ok)
            { 
                // It is kind float32 but not type float32. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding float32 array or slice: length exceeds input size (%d elements)", length);
                }
                slice[i] = float32(float32FromBits(state.decodeUint(), ovfl));
            }

            return true;
        }

        private static bool decFloat64Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decFloat64Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decFloat64Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<double> (slice, ok) = v.Interface()._<slice<double>>();
            if (!ok)
            { 
                // It is kind float64 but not type float64. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding float64 array or slice: length exceeds input size (%d elements)", length);
                }
                slice[i] = float64FromBits(state.decodeUint());
            }

            return true;
        }

        private static bool decIntArray(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decIntSlice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decIntSlice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<long> (slice, ok) = v.Interface()._<slice<long>>();
            if (!ok)
            { 
                // It is kind int but not type int. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding int array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeInt(); 
                // MinInt and MaxInt
                if (x < ~int64(~uint(0L) >> (int)(1L)) || int64(~uint(0L) >> (int)(1L)) < x)
                {
                    error_(ovfl);
                }
                slice[i] = int(x);
            }

            return true;
        }

        private static bool decInt16Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decInt16Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decInt16Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<short> (slice, ok) = v.Interface()._<slice<short>>();
            if (!ok)
            { 
                // It is kind int16 but not type int16. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding int16 array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeInt();
                if (x < math.MinInt16 || math.MaxInt16 < x)
                {
                    error_(ovfl);
                }
                slice[i] = int16(x);
            }

            return true;
        }

        private static bool decInt32Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decInt32Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decInt32Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<int> (slice, ok) = v.Interface()._<slice<int>>();
            if (!ok)
            { 
                // It is kind int32 but not type int32. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding int32 array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeInt();
                if (x < math.MinInt32 || math.MaxInt32 < x)
                {
                    error_(ovfl);
                }
                slice[i] = int32(x);
            }

            return true;
        }

        private static bool decInt64Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decInt64Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decInt64Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<long> (slice, ok) = v.Interface()._<slice<long>>();
            if (!ok)
            { 
                // It is kind int64 but not type int64. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding int64 array or slice: length exceeds input size (%d elements)", length);
                }
                slice[i] = state.decodeInt();
            }

            return true;
        }

        private static bool decInt8Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decInt8Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decInt8Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<sbyte> (slice, ok) = v.Interface()._<slice<sbyte>>();
            if (!ok)
            { 
                // It is kind int8 but not type int8. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding int8 array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeInt();
                if (x < math.MinInt8 || math.MaxInt8 < x)
                {
                    error_(ovfl);
                }
                slice[i] = int8(x);
            }

            return true;
        }

        private static bool decStringArray(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decStringSlice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decStringSlice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<@string> (slice, ok) = v.Interface()._<slice<@string>>();
            if (!ok)
            { 
                // It is kind string but not type string. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding string array or slice: length exceeds input size (%d elements)", length);
                }
                var u = state.decodeUint();
                var n = int(u);
                if (n < 0L || uint64(n) != u || n > state.b.Len())
                {
                    errorf("length of string exceeds input size (%d bytes)", u);
                }
                if (n > state.b.Len())
                {
                    errorf("string data too long for buffer: %d", n);
                } 
                // Read the data.
                var data = state.b.Bytes();
                if (len(data) < n)
                {
                    errorf("invalid string length %d: exceeds input size %d", n, len(data));
                }
                slice[i] = string(data[..n]);
                state.b.Drop(n);
            }

            return true;
        }

        private static bool decUintArray(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decUintSlice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decUintSlice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<ulong> (slice, ok) = v.Interface()._<slice<ulong>>();
            if (!ok)
            { 
                // It is kind uint but not type uint. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding uint array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeUint();
                /*TODO if math.MaxUint32 < x {
                            error_(ovfl)
                        }*/
                slice[i] = uint(x);
            }

            return true;
        }

        private static bool decUint16Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decUint16Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decUint16Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<ushort> (slice, ok) = v.Interface()._<slice<ushort>>();
            if (!ok)
            { 
                // It is kind uint16 but not type uint16. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding uint16 array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeUint();
                if (math.MaxUint16 < x)
                {
                    error_(ovfl);
                }
                slice[i] = uint16(x);
            }

            return true;
        }

        private static bool decUint32Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decUint32Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decUint32Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<uint> (slice, ok) = v.Interface()._<slice<uint>>();
            if (!ok)
            { 
                // It is kind uint32 but not type uint32. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding uint32 array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeUint();
                if (math.MaxUint32 < x)
                {
                    error_(ovfl);
                }
                slice[i] = uint32(x);
            }

            return true;
        }

        private static bool decUint64Array(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decUint64Slice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decUint64Slice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<ulong> (slice, ok) = v.Interface()._<slice<ulong>>();
            if (!ok)
            { 
                // It is kind uint64 but not type uint64. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding uint64 array or slice: length exceeds input size (%d elements)", length);
                }
                slice[i] = state.decodeUint();
            }

            return true;
        }

        private static bool decUintptrArray(ref decoderState state, reflect.Value v, long length, error ovfl)
        { 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }
            return decUintptrSlice(state, v.Slice(0L, v.Len()), length, ovfl);
        }

        private static bool decUintptrSlice(ref decoderState state, reflect.Value v, long length, error ovfl)
        {
            slice<System.UIntPtr> (slice, ok) = v.Interface()._<slice<System.UIntPtr>>();
            if (!ok)
            { 
                // It is kind uintptr but not type uintptr. TODO: We can handle this unsafely.
                return false;
            }
            for (long i = 0L; i < length; i++)
            {
                if (state.b.Len() == 0L)
                {
                    errorf("decoding uintptr array or slice: length exceeds input size (%d elements)", length);
                }
                var x = state.decodeUint();
                if (uint64(~uintptr(0L)) < x)
                {
                    error_(ovfl);
                }
                slice[i] = uintptr(x);
            }

            return true;
        }
    }
}}
