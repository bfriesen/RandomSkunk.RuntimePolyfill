#if !NET7_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
internal sealed class StringSyntaxAttribute : Attribute
{
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
        Arguments = [];
    }

    public StringSyntaxAttribute(string syntax, params object?[] arguments)
    {
        Syntax = syntax;
        Arguments = arguments;
    }

    public string Syntax { get; }

    public object?[] Arguments { get; }
}

#endif
