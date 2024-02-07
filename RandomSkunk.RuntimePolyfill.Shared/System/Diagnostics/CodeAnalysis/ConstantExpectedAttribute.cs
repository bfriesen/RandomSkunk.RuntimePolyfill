﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET6_0 || NET5_0 || NETCOREAPP3_1 || NETCOREAPP3_0 || NETCOREAPP2_2 || NETCOREAPP2_1 || NETCOREAPP2_0 || NETSTANDARD2_1 || NETSTANDARD2_0 || NET48 || NET472 || NET471 || NET47 || NET462 || NET461

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Indicates that the specified method parameter expects a constant.
    /// </summary>
    /// <remarks>
    /// This can be used to inform tooling that a constant should be used as an argument for the annotated parameter.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class ConstantExpectedAttribute : Attribute
    {
        /// <summary>
        /// Indicates the minimum bound of the expected constant, inclusive.
        /// </summary>
        public object? Min { get; set; }

        /// <summary>
        /// Indicates the maximum bound of the expected constant, inclusive.
        /// </summary>
        public object? Max { get; set; }
    }
}

#endif
