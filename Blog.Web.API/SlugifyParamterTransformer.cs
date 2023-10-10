using System.Text.RegularExpressions;

namespace Blog.Web.API;

public partial class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value)
    {
        return value == null ? null : SlugifyRegex().Replace(value?.ToString() ?? string.Empty, "$1-$2").ToLower();
    }

    [GeneratedRegex("([a-z])([A-Z])")]
    private static partial Regex SlugifyRegex();
}