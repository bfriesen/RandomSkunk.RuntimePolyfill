﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if !NETSTANDARD2_1_OR_GREATER && !NET5_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that null is disallowed as an input even if the corresponding type allows it.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
    internal class DisallowNullAttribute : Attribute
    {
    }
}

#endif