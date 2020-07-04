using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using McpSquadBuilder.Core.Services;
using System.Net.Http.Json;
using McpSquadBuilder.Core.Models;

namespace McpSquadBuilder.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            var affiliations = await httpClient.GetFromJsonAsync<IEnumerable<Affiliation>>("data/affiliations.json");
            builder.Services.AddSingleton<IEnumerable<Affiliation>>(affiliations);

            builder.Services.AddTransient<ISquadService, SquadService>();

            await builder.Build().RunAsync();
        }
    }
}
