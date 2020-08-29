// Copyright 2014 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// pprof is a tool for collection, manipulation and visualization
// of performance profiles.
// package main -- go2cs converted at 2020 August 29 10:05:08 UTC
// Original source: C:\Go\src\cmd\vendor\github.com\google\pprof\pprof.go
using fmt = go.fmt_package;
using os = go.os_package;

using driver = go.github.com.google.pprof.driver_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        private static void Main()
        {
            {
                var err = driver.PProf(ref new driver.Options());

                if (err != null)
                {
                    fmt.Fprintf(os.Stderr, "pprof: %v\n", err);
                    os.Exit(2L);
                }
            }
        }
    }
}
