namespace ChendyMarket.Feature.Market;

public static class MarketEndpoints
{
    public static IEndpointRouteBuilder MapMarketEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGetSymbolInfoEndpoint();
        return app;
    }
}