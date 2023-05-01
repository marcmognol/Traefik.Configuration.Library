using Traefik.Configuration.Library.Services;

namespace Traefik.Configuration.Library.Routers;

public class UdpRouter
{
    [JsonPropertyName("entryPoints")]
    public IEnumerable<EntryPoint>? EntryPoints { get; set; }

    [JsonPropertyName("service")]
    public required UdpService Service { get; set; }
}
