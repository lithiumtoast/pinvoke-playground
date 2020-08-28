// Copyright (c) Lucas Girouard-Stranks. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System;

// ReSharper disable MemberCanBeInternal

namespace app
{
    [Flags]
    public enum NativePlatform : uint
    {
        Unknown = 0,
        Windows = 1 << 0,
        macOS = 1 << 1,

        Linux = 1 << 2
        // Android = 1 << 3,
        // iOS = 1 << 4,
        // tvOS = 1 << 5,
        // Web = 1 << 6,
    }
}
