#if !NETSTANDARD2_1_OR_GREATER && !NET5_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
internal sealed class DoesNotReturnIfAttribute(bool parameterValue) : Attribute
{
    public bool ParameterValue { get; } = parameterValue;
}

#endif
