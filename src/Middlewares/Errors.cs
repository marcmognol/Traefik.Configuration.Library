namespace Traefik.Configuration.Library.Middlewares;

public class Errors : HttpMiddleware
{
    [JsonPropertyName("status")]
    public IEnumerable<string>? Status { get; set; }

    [JsonPropertyName("service")]
    public required string Service { get; set; }

    [JsonPropertyName("query")]
    public required string Query { get; set; }
}
