namespace Traefik.Configuration.Library.Middlewares;

public class Retry : HttpMiddleware
{
    [JsonPropertyName("attempts")]
    public required int Attempts { get; set; }

    [JsonPropertyName("initialInterval")]
    public int? InitialInterval { get; set; }
}
