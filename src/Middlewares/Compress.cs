namespace Traefik.Configuration.Library.Middlewares;

public class Compress : HttpMiddleware
{
    [JsonPropertyName("excludedContentTypes")]
    public string? ExcludedContentTypes { get; set; }

    [JsonPropertyName("minResponseBodyBytes")]
    public int MinResponseBodyBytes { get; set; } = 1024;
}
