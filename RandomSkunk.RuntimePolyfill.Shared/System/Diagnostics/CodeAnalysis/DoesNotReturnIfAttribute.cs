// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NETCOREAPP2_2 || NETCOREAPP2_1 || NETCOREAPP2_0 || NETSTANDARD2_0 || NET48 || NET472 || NET471 || NET47 || NET462 || NET461

#pragma warning disable IDE0079
#pragma warning disable IDE0290

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that the method will not return if the associated Boolean parameter is passed the specified value.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class DoesNotReturnIfAttribute : Attribute
    {
        /// <summary>
        /// Initializes the attribute with the specified parameter value.
        /// </summary>
        /// <param name="parameterValue">The condition parameter value. Code after the method will be considered unreachable by
        ///     diagnostics if the argument to the associated parameter matches this value.</param>
        public DoesNotReturnIfAttribute(bool parameterValue) => ParameterValue = parameterValue;

        /// <summary>
        /// Gets the condition parameter value.
        /// </summary>
        public bool ParameterValue { get; }
    }
}

#endif
