#if !NET7_0_OR_GREATER

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// This attribute is non-functional.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class ConstantExpectedAttribute : Attribute
    {
        public object? Min { get; set; }

        public object? Max { get; set; }
    }
}

#endif
