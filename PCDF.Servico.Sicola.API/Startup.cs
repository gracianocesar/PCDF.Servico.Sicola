using FluentValidation.AspNetCore;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Logging;
using PCDF.Corporativo.Logging;
using PCDF.ServicoSicola.API.Application.Extensions;
using PCDF.ServicoSicola.API.Configurations;
using PCDF.ServicoSicola.API.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;

namespace PCDF.ServicoSicola.API
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Exibir logs detalhados do identity server
            IdentityModelEventSource.ShowPII = true;

            var apiConfiguration = _configuration.GetSection(nameof(ApiConfiguration)).Get<ApiConfiguration>();
            services.AddSingleton(apiConfiguration);

            services.AddApiAuthentication(apiConfiguration);
            services.AddApiAuthorizationPolicies(apiConfiguration);
            services.AddApiCors(apiConfiguration);
            services.AddApiSwaggerGen(apiConfiguration);

            services.AddControllers()
                .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddDependencyInjection(_configuration, "DefaultConnection");

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddAppLogging(_configuration);

            services.AddHealthChecks();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApiConfiguration apiConfiguration)
        {
            app.AddApiForwardHeaders();

            app.UseAppLogging();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var cultureInfo = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", apiConfiguration.ApiName);

                c.OAuthClientId(apiConfiguration.OidcSwaggerUiClientId);
                c.OAuthAppName(apiConfiguration.ApiName);
                c.OAuthUsePkce();
                c.DefaultModelsExpandDepth(-1);
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health", new HealthCheckOptions
                {
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });
            });
        }
    }
}
