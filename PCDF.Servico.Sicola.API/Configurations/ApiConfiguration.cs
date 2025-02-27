﻿namespace PCDF.ServicoSicola.API.Configurations
{
    public class ApiConfiguration
    {
        public string ApiName { get; set; }

        public string ApiVersion { get; set; }

        public string ApiDescription { get; set; }

        public string IdentityServerBaseUrl { get; set; }

        public string OidcSwaggerUiClientId { get; set; }

        public bool RequireHttpsMetadata { get; set; }

        public string OidcApiName { get; set; }

        public bool CorsAllowAnyOrigin { get; set; }

        public string[] CorsAllowOrigins { get; set; }
    }
}
