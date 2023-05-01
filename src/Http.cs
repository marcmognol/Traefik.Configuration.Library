using Traefik.Configuration.Library.Middlewares;

namespace Traefik.Configuration.Library;

public class Http
{
    [JsonPropertyName("middlewares")]
    public IDictionary<string, HttpMiddleware>? Middlewares { get; set; }
}
