namespace Traefik.Configuration.Library.Middlewares;

public class Buffering : HttpMiddleware
{
    [JsonPropertyName("maxRequestBodyBytes")]
    public int MaxRequestBodyBytes { get; set; } = 0;

    [JsonPropertyName("memRequestBodyBytes")]
    public int MemRequestBodyBytes { get; set; } = 1048576;

    [JsonPropertyName("maxResponseBodyBytes")]
    public int MaxResponseBodyBytes { get; set; } = 0;

    [JsonPropertyName("memResponseBodyBytes")]
    public int MemResponseBodyBytes { get; set; } = 1048576;

    [JsonPropertyName("retryExpression")]
    public string RetryExpression { get; set; } = string.Empty;
}
