namespace Traefik.Configuration.Library.Middlewares;

public class AddPrefix : Middleware
{
    public required string Prefix { get; set; }
}
