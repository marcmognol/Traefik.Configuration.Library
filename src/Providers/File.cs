namespace Traefik.Configuration.Library.Providers;

public class File
{
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    [JsonPropertyName("watch")]
    public bool? Watch { get; set; }
}
