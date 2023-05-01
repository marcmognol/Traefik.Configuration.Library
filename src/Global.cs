namespace Traefik.Configuration.Library;

public class Global
{
    [JsonPropertyName("checkNewVersion")]
    public bool CheckNewVersion { get; set; } = true;

    [JsonPropertyName("sendAnonymousUsage")]
    public bool SendAnonymousUsage { get; set; } = false;
}
