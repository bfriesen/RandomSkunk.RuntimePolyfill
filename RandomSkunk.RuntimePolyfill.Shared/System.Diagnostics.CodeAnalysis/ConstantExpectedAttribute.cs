#if !NET7_0_OR_GREATER

#pragma warning disable IDE0079
#pragma warning disable CS8618

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// This attribute is non-functional.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class ConstantExpectedAttribute : Attribute
    {
        public object Min { get; set; }

        public object Max { get; set; }
    }
}

#endif
