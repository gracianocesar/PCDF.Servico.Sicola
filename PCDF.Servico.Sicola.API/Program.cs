using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using PCDF.Corporativo.Logging;
using Serilog.Events;
using System.Diagnostics.CodeAnalysis;

namespace PCDF.ServicoSicola.API
{
    [ExcludeFromCodeCoverage]
    public static class Program
    {
        private static IConfigurationRoot ConfigurationRoot;

        public static void Main(string[] args)
        {
            ConfigurationRoot = new ConfigurationBuilder()
                                        .AddJsonFile("appsettings.json", true, true)
                                        .AddCommandLine(args)
                                        .Build();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                        .ConfigureAppLogging(ConfigurationRoot, LogEventLevel.Error)
                        .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }
    }
}
