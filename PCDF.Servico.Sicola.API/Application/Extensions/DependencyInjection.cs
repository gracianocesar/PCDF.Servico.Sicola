using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCDF.Servico.Sicola.API.Application.Interfaces;
using PCDF.Servico.Sicola.API.Application.Services;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Data.Repositories;
using PCDF.ServicoSicola.API.Application.Interfaces;
using PCDF.ServicoSicola.API.Application.Services;
using PCDF.ServicoSicola.API.Data.Interfaces;
using PCDF.ServicoSicola.API.Data.Repositories;
using System;
using System.Diagnostics.CodeAnalysis;

namespace PCDF.ServicoSicola.API.Application.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services,
                                                                IConfiguration configuration,
                                                                string sicolaConnectionStringName)
        {

            if (sicolaConnectionStringName == null)
            {
                throw new ArgumentNullException(nameof(sicolaConnectionStringName), "A connection string do banco IML deve ser informada");
            }


            services.AddDbContext<ImlContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(sicolaConnectionStringName)));


            services.AddScoped<IDocumentoAssinaturaRepository, DocumentoAssinaturaRepository>();
            services.AddScoped<IDocumentoAssinaturaService, DocumentoAssinaturaService>();
            services.AddScoped<IUsuarioRepository, UsuarioRopository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IMensagemRepository, MensagemRepository>();
            services.AddScoped<IMensagemService, MensagemService>();
            services.AddScoped<ILaudoVwRepository, LaudoVwRepository>();
            services.AddScoped<ILaudoVwService, LaudoVwService>();
            return services;
        }
    }
}
