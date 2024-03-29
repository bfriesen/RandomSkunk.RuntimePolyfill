﻿// This file is generated by the RandomSkunk.RuntimePolyfill library.
// <auto-generated/>

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NETCOREAPP3_1 || NETCOREAPP3_0 || NETCOREAPP2_2 || NETCOREAPP2_1 || NETCOREAPP2_0 || NETSTANDARD2_1 || NETSTANDARD2_0 || NET48 || NET472 || NET471 || NET47 || NET462 || NET461

#pragma warning disable IDE0079
#pragma warning disable IDE0290

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Indicates that the specified method requires dynamic access to code that is not referenced statically, for example
    /// through <see cref="Reflection"/>.
    /// </summary>
    /// <remarks>
    /// This allows tools to understand which methods are unsafe to call when removing unreferenced code from an application.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Class, Inherited = false)]
    internal sealed class RequiresUnreferencedCodeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiresUnreferencedCodeAttribute"/> class with the specified message.
        /// </summary>
        /// <param name="message">A message that contains information about the usage of unreferenced code.</param>
        public RequiresUnreferencedCodeAttribute(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Gets a message that contains information about the usage of unreferenced code.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets or sets an optional URL that contains more information about the method, why it requires unreferenced code, and
        /// what options a consumer has to deal with it.
        /// </summary>
        public string? Url { get; set; }
    }
}

#endif
