#if !NET8_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
internal sealed class ExperimentalAttribute(string diagnosticId) : Attribute
{
    public string DiagnosticId { get; } = diagnosticId;

    public string? UrlFormat { get; set; }
}

#endif
