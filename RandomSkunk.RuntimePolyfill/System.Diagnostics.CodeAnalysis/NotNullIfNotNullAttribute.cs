#if !NETSTANDARD2_1_OR_GREATER && !NET5_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
internal sealed class NotNullIfNotNullAttribute(string parameterName) : Attribute
{
    public string ParameterName { get; } = parameterName;
}

#endif
