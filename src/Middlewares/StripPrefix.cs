namespace Traefik.Configuration.Library.Middlewares;

public class StripPrefix : HttpMiddleware
{
    [JsonPropertyName("prefixes")]
    public required IEnumerable<string> Prefixes { get; set; }

    [JsonPropertyName("forceSlash")]
    public bool ForceSlash { get; set; } = true;
}
