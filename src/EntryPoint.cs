namespace Traefik.Configuration.Library;

public class EntryPoint
{
    [JsonPropertyName("address")]
    public required string Address { get; set; }
}
