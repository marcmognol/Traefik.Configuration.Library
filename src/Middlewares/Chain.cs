namespace Traefik.Configuration.Library.Middlewares;

public class Chain : HttpMiddleware
{
    [JsonPropertyName("middlewares")]
    public IEnumerable<string>? Middlewares { get; set; }
}
