namespace Traefik.Configuration.Library.Middlewares;

public class ReplacePathRegex : HttpMiddleware
{
    [JsonPropertyName("regex")]
    public required string Regex { get; set; }

    [JsonPropertyName("replacement")]
    public required string Replacement { get; set; }
}
