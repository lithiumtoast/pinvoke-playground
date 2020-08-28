// Copyright (c) Lucas Girouard-Stranks. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System.ComponentModel;
using System.Runtime.InteropServices;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace app
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate ScreenBounds D_getScreenBounds();
    
    [StructLayout(LayoutKind.Sequential)]
    public struct ScreenBounds
    {
        public uint X;
        public uint Y;
        public uint Width;
        public uint Height;

        public override string ToString()
        {
            return $"({X},{Y},{Width},{Height})";
        }
    }
}
