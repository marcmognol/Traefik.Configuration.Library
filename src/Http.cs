﻿using Traefik.Configuration.Library.Middlewares;
using Traefik.Configuration.Library.Routers;

namespace Traefik.Configuration.Library;

public class Http
{
    [JsonPropertyName("routers")]
    public IDictionary<string, TcpRouter>? Routers { get; set; }

    [JsonPropertyName("middlewares")]
    public IDictionary<string, HttpMiddleware>? Middlewares { get; set; }
}
