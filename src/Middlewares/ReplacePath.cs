namespace Traefik.Configuration.Library.Middlewares;

public class ReplacePath : HttpMiddleware
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}
