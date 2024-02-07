// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET5_0 || NETCOREAPP3_1 || NETCOREAPP3_0 || NETCOREAPP2_2 || NETCOREAPP2_1 || NETCOREAPP2_0 || NETSTANDARD2_1 || NETSTANDARD2_0 || NET48 || NET472 || NET471 || NET47 || NET462 || NET461

#nullable enable

namespace System.Diagnostics
{
    /// <summary>
    /// Types and Methods attributed with StackTraceHidden will be omitted from the stack trace text shown in
    /// <c>StackTrace.ToString()</c> and <c>Exception.StackTrace</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Struct, Inherited = false)]
    internal sealed class StackTraceHiddenAttribute : Attribute
    {
    }
}

#endif
