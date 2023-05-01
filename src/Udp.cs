using Traefik.Configuration.Library.Routers;

namespace Traefik.Configuration.Library;

public class Udp
{
    [JsonPropertyName("routers")]
    public IDictionary<string, UdpRouter>? Routers { get; set; }
}
