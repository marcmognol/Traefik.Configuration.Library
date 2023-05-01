namespace Traefik.Configuration.Library.Middlewares;

public class ContentType : HttpMiddleware
{
    [JsonPropertyName("autoDetect")]
    public bool? AutoDetect { get; set; }
}
