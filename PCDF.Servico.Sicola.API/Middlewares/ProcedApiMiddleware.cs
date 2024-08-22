using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCDF.ServicoSicola.API.Application.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace PCDF.ServicoSicola.API.Middlewares
{
    [ExcludeFromCodeCoverage]
    public static class SicolaApiMiddleware
    {
        public static IServiceCollection AddSicolaApi(this IServiceCollection services, IConfiguration configuration,
                                                        string sicolaConnectionStringName)
        {
            services.AddDependencyInjection(configuration, sicolaConnectionStringName);

            return services;
        }
    }
}
