using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PCDF.ServicoSicola.API.Application.Extensions;

namespace PCDF.Servico.Sicola.Tests
{
    public class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder)
        {
            hostBuilder
                .ConfigureHostConfiguration(builder =>
                {
                    builder
                    .AddJsonFile("appsettings.tests.json", true);
                });
        }

        public void ConfigureServices(IServiceCollection services, HostBuilderContext context)
        {
            services.AddDependencyInjection(context.Configuration, "DefaultConnection");
        }
    }
}
