//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:12:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using net = go.net_package;
using url = go.net.url_package;
using os = go.os_package;
using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace net
{
    public static partial class proxy_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Auth
        {
            // Constructors
            public Auth(NilType _)
            {
                this.User = default;
                this.Password = default;
            }

            public Auth(@string User = default, @string Password = default)
            {
                this.User = User;
                this.Password = Password;
            }

            // Enable comparisons between nil and Auth struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Auth value, NilType nil) => value.Equals(default(Auth));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Auth value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Auth value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Auth value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Auth(NilType nil) => default(Auth);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Auth Auth_cast(dynamic value)
        {
            return new Auth(value.User, value.Password);
        }
    }
}}}}}