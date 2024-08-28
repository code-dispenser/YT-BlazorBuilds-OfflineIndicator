using BlazorBuilds.Components.OfflineIndicator;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorBuilds.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped<OfflineIndicatorService>();

            await builder.Build().RunAsync();
        }
    }
}
