using First_WebApplication.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace First_WebApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");


            //builder.Services.AddCors(policy =>
            //{
            //    policy.AddPolicy("_myAllowSpecificOrigins", builder => builder.WithOrigins("https://localhost:44371/")
            //         .AllowAnyMethod()
            //         .AllowAnyHeader()
            //         .AllowCredentials());
            //});

            builder.Services.AddSingleton<LocalData>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            
            await builder.Build().RunAsync();
        }
    }
}
