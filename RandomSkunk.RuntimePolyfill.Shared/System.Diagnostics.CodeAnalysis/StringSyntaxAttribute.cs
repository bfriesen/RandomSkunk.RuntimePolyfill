#if !NET7_0_OR_GREATER

#pragma warning disable IDE0079
#pragma warning disable CA1825

#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal sealed class StringSyntaxAttribute : Attribute
    {
        private static readonly object[] _emptyArguments = new object[0];

        public const string CompositeFormat = nameof(CompositeFormat);

        public const string DateOnlyFormat = nameof(DateOnlyFormat);

        public const string DateTimeFormat = nameof(DateTimeFormat);

        public const string EnumFormat = nameof(EnumFormat);

        public const string GuidFormat = nameof(GuidFormat);

        public const string Json = nameof(Json);

        public const string NumericFormat = nameof(NumericFormat);

        public const string Regex = nameof(Regex);

        public const string TimeOnlyFormat = nameof(TimeOnlyFormat);

        public const string TimeSpanFormat = nameof(TimeSpanFormat);

        public const string Uri = nameof(Uri);

        public const string Xml = nameof(Xml);

        public StringSyntaxAttribute(string syntax)
        {
            Syntax = syntax;
            Arguments = _emptyArguments;
        }

        public StringSyntaxAttribute(string syntax, params object?[] arguments)
        {
            Syntax = syntax;
            Arguments = arguments;
        }

        public string Syntax { get; }

        public object?[] Arguments { get; }
    }
}

#endif
