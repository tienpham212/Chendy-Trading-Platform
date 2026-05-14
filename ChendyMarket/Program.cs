using ChendyMarket.Feature.Market;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapMarketEndpoints();

app.Run();
