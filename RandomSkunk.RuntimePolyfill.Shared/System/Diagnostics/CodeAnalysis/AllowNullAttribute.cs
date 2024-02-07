// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NETCOREAPP2_2 || NETCOREAPP2_1 || NETCOREAPP2_0 || NETSTANDARD2_0 || NET48 || NET472 || NET471 || NET47 || NET462 || NET461

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that null is allowed as an input even if the corresponding type disallows it.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
    internal sealed class AllowNullAttribute : Attribute
    {
    }
}

#endif
