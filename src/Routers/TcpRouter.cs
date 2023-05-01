using Traefik.Configuration.Library.Middlewares;
using Traefik.Configuration.Library.Services;

namespace Traefik.Configuration.Library.Routers;

public class TcpRouter
{
    [JsonPropertyName("entryPoints")]
    public IEnumerable<EntryPoint>? EntryPoints { get; set; }

    [JsonPropertyName("rule")]
    public required string Rule { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("middlewares")]
    public IEnumerable<TcpMiddleware>? Middlewares { get; set; }

    [JsonPropertyName("service")]
    public required HttpService Service { get; set; }
}
