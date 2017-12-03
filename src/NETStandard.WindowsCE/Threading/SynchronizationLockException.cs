﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: Wait(), Notify() or NotifyAll() was called from an unsynchronized
**          block of code.
**
**
=============================================================================*/

using System.Runtime.Serialization;
using System;

#if NET35_CF
using System.Runtime.ExceptionServices;
#else
using Mock.System.Runtime.ExceptionServices;
#endif

#if NET35_CF
namespace System.Threading
#else
namespace Mock.System.Threading
#endif
{
    [Serializable]
    //[System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class SynchronizationLockException : SystemException, ISerializable
    {
        public SynchronizationLockException()
            : base(SR.Arg_SynchronizationLockException)
        {
            HResult = HResults.COR_E_SYNCHRONIZATIONLOCK;
        }

        public SynchronizationLockException(String message)
            : base(message)
        {
            HResult = HResults.COR_E_SYNCHRONIZATIONLOCK;
        }

        public SynchronizationLockException(String message, Exception innerException)
            : base(message, innerException)
        {
            HResult = HResults.COR_E_SYNCHRONIZATIONLOCK;
        }

        protected SynchronizationLockException(SerializationInfo info, StreamingContext context)
            //: base(info, context)
        {
            ExceptionSerializer.SetObjectData(this, info, context);
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            ExceptionSerializer.GetObjectData(this, info, context);
        }
    }
}