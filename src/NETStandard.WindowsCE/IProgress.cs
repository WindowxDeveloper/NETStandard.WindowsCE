﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** 
** 
**
**
** Purpose: Interface for providing progress updates.
**
**
===========================================================*/

#if NET35_CF
namespace System
#else
namespace Mock.System
#endif
{
    /// <summary>Defines a provider for progress updates.</summary>
    /// <typeparam name="T">The type of progress update value.</typeparam>
    public interface IProgress<in T>
    {
        /// <summary>Reports a progress update.</summary>
        /// <param name="value">The value of the updated progress.</param>
        void Report(T value);
    }
}