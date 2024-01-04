﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if !NET5_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

#pragma warning disable IDE0079
#pragma warning disable IDE0290

#nullable enable

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Indicates that a parameter captures the expression passed for another parameter as a string.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class CallerArgumentExpressionAttribute : Attribute
    {
        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }
}

#endif
