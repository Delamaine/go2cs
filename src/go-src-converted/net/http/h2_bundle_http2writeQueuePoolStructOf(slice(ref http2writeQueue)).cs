//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2writeQueuePool
        {
            // Value of the http2writeQueuePool struct
            private readonly slice<ref http2writeQueue> m_value;

            public http2writeQueuePool(slice<ref http2writeQueue> value) => m_value = value;

            // Enable implicit conversions between slice<ref http2writeQueue> and http2writeQueuePool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2writeQueuePool(slice<ref http2writeQueue> value) => new http2writeQueuePool(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ref http2writeQueue>(http2writeQueuePool value) => value.m_value;
            
            // Enable comparisons between nil and http2writeQueuePool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2writeQueuePool value, NilType nil) => value.Equals(default(http2writeQueuePool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2writeQueuePool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2writeQueuePool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2writeQueuePool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2writeQueuePool(NilType nil) => default(http2writeQueuePool);
        }
    }
}}
