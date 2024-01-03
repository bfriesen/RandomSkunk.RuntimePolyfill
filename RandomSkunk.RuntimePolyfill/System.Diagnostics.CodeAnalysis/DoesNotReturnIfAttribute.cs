#if !NETSTANDARD2_1_OR_GREATER && !NET5_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

#pragma warning disable IDE0079
#pragma warning disable IDE0290

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class DoesNotReturnIfAttribute : Attribute
    {
        public DoesNotReturnIfAttribute(bool parameterValue)
        {
            ParameterValue = parameterValue;
        }

        public bool ParameterValue { get; }
    }
}

#endif
