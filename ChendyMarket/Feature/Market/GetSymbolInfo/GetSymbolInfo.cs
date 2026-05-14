namespace ChendyMarket.Feature.Market;

public static class GetSymbolInfo
{
    public static IEndpointRouteBuilder MapGetSymbolInfoEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/markets/{symbol}", async (IHttpClientFactory clientFactory, string symbol) =>
        {
           var httpClient = clientFactory.CreateClient();
           var encodedSymbol = Uri.EscapeDataString(symbol);
           var res = await httpClient.GetAsync($"https://api.binance.com/api/v3/ticker/price?symbol={encodedSymbol}");

           if (res.IsSuccessStatusCode)
           {
                var content = await res.Content.ReadFromJsonAsync<SymbolInfoModel>();
                
                if (content == null)
                {
                    return Results.BadRequest("Failed to parse symbol info");
                }

                return Results.Ok(new SymbolInfoDTO(content.symbol, content.price));
           }
           else
           {
               return Results.BadRequest("Failed to fetch symbol info");
           }
        });

        return app;
    }

}

public record SymbolInfoModel(string symbol, string price);

public record SymbolInfoDTO (string pair, string lastPrice);