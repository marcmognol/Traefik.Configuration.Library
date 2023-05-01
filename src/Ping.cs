namespace Traefik.Configuration.Library;

public class Ping
{
    [JsonPropertyName("entryPoint")]
    public string EntryPoint { get; set; } = "traefik";

    [JsonPropertyName("manualRouting")]
    public bool ManualRouting { get; set; } = false;

    [JsonPropertyName("terminatingStatusCode")]
    public int TerminatingStatusCode { get; set; } = 503;
}
