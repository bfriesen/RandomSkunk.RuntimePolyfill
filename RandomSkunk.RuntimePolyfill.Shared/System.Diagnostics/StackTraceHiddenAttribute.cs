#if !NET6_0_OR_GREATER

#nullable enable

namespace System.Diagnostics
{
    /// <summary>
    /// This attribute is non-functional.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Struct, Inherited = false)]
    internal sealed class StackTraceHiddenAttribute : Attribute
    {
    }
}

#endif
