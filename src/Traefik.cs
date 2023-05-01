namespace Traefik.Configuration.Library;

public class Traefik
{
    [JsonPropertyName("global")]
    public Global? Global { get; set; }

    [JsonPropertyName("providers")]
    public Providers.Providers? Providers { get; set; }

    [JsonPropertyName("entryPoints")]
    public IDictionary<string, EntryPoint>? EntryPoints { get; set; }

    [JsonPropertyName("http")]
    public Http? Http { get; set; }

    [JsonPropertyName("api")]
    public API? API { get; set; }

    [JsonPropertyName("ping")]
    public Ping? Ping { get; set; }
}
