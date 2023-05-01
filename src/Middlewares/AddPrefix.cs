namespace Traefik.Configuration.Library.Middlewares;

public class AddPrefix : HttpMiddleware
{
    [JsonPropertyName("prefix")]
    public required string Prefix { get; set; }
}
