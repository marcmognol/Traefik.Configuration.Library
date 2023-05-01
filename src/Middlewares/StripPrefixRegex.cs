namespace Traefik.Configuration.Library.Middlewares;

public class StripPrefixRegex : HttpMiddleware
{
    [JsonPropertyName("regex")]
    public required IEnumerable<string> Regex { get; set; }
}
