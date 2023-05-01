namespace Traefik.Configuration.Library.Middlewares;

public class BasicAuth : HttpMiddleware
{
    [JsonPropertyName("users")]
    public IEnumerable<string>? Users { get; set; }

    [JsonPropertyName("usersFile")]
    public string? UsersFile { get; set; }

    [JsonPropertyName("realm")]
    public string Realm { get; set; } = "traefik";

    [JsonPropertyName("headerField")]
    public string? HeaderField { get; set; }

    [JsonPropertyName("removeHeader")]
    public bool RemoveHeader { get; set; } = false;
}
