namespace Traefik.Configuration.Library.Providers;

public class Docker
{
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; } = "unix:///var/run/docker.sock";

    [JsonPropertyName("useBindPortIP")]
    public bool UseBindPortIP { get; set; } = false;

    [JsonPropertyName("exposedByDefault")]
    public bool ExposedByDefault { get; set; } = true;
}
