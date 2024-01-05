using AgriKingApp.Api;
using AgriKingApp.Data;
using AgrikingPWA;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<AgriKingApi>();
//builder.Services.AddFileReaderService(options => options.UseWasmSharedBuffer = true);

await builder.Build().RunAsync();
