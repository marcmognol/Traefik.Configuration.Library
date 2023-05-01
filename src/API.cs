using System.Text.Json.Serialization;

namespace Traefik.Configuration.Library;

public class API
{
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("dashboard")]
    public bool Dashboard { get; set; } = true;

    [JsonPropertyName("debug")]
    public bool Debug { get; set; } = false;
}
