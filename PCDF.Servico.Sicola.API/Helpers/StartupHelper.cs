using IdentityModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using PCDF.ServicoSicola.API.Configurations;
using PCDF.ServicoSicola.API.Middlewares;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PCDF.ServicoSicola.API.Helpers
{
    public static class StartupHelper
    {

        public static void AddApiAuthentication(this IServiceCollection services, ApiConfiguration apiConfiguration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.Authority = apiConfiguration.IdentityServerBaseUrl;
                    options.RequireHttpsMetadata = apiConfiguration.RequireHttpsMetadata;
                    options.Audience = apiConfiguration.OidcApiName;
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                });
        }
        public static void AddApiAuthorizationPolicies(this IServiceCollection services, ApiConfiguration apiConfiguration)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy(AuthorizationConsts.AdministrationPolicy,
                    policy =>
                        policy.RequireAssertion(context => context.User.HasClaim(c => c.Type == JwtClaimTypes.Scope && c.Value == apiConfiguration.OidcApiName)
                        ));
            });
        }

        public static void AddApiForwardHeaders(this IApplicationBuilder app)
        {
            var forwardingOptions = new ForwardedHeadersOptions()
            {
                ForwardedHeaders = ForwardedHeaders.All
            };

            forwardingOptions.KnownNetworks.Clear();
            forwardingOptions.KnownProxies.Clear();

            app.UseForwardedHeaders(forwardingOptions);
        }

        public static IServiceCollection AddApiCors(this IServiceCollection services, ApiConfiguration apiConfiguration)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        if (apiConfiguration.CorsAllowAnyOrigin)
                        {
                            builder.AllowAnyOrigin();
                        }
                        else
                        {
                            builder.WithOrigins(apiConfiguration.CorsAllowOrigins);
                        }

                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    });
            });

            return services;
        }

        public static void AddApiSwaggerGen(this IServiceCollection services, ApiConfiguration apiConfiguration)
        {
            services.AddSwaggerGen(options =>
            {
                options.DocumentFilter<SwaggerControllersFilter>();

                options.SwaggerDoc(apiConfiguration.ApiVersion, new OpenApiInfo
                {
                    Title = apiConfiguration.ApiName,
                    Version = apiConfiguration.ApiVersion,
                    Description = apiConfiguration.ApiDescription
                });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri($"{apiConfiguration.IdentityServerBaseUrl}/connect/authorize"),
                            TokenUrl = new Uri($"{apiConfiguration.IdentityServerBaseUrl}/connect/token"),
                            Scopes = new Dictionary<string, string> {
                                { apiConfiguration.OidcApiName, apiConfiguration.ApiName }
                            }
                        }
                    }
                });
                options.OperationFilter<AuthorizeCheckOperationFilter>();

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }

    }
}
