#if !NET7_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
internal sealed class UnscopedRefAttribute : Attribute
{
}

#endif
