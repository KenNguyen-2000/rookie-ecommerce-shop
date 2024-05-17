﻿using IdentityServer4;
using IdentityServer4.Models;

namespace RookEcomShop.Infrastructure.Extensions.IdentityServer
{
    public static class IdentityServerConfig
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new List<IdentityResource>
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                   };
        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource("rookEcomShop.api", "RookEcomShop Api")
            };


        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                //new ApiScope("rookEcomShop.read"),
                //new ApiScope("rookEcomShop.write"),
                new ApiScope("rookEcomShop.api", "RookEcomShop Api")
            };

        public static IEnumerable<Client> Clients(Dictionary<string, string> clientUrls) =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "rookEcomShop.api",
                    ClientName = "RookEcomShop Api Client",
                    AllowedGrantTypes = GrantTypes.Code,

                    RequireConsent = false,

                    RedirectUris =           { $"{clientUrls["Swagger"]}/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { $"{clientUrls["Swagger"]}/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins =     { $"{clientUrls["Swagger"]}" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "rookEcomShop.api"
                    }
                },
                 new Client
                {
                    ClientId = "rookEcomShop.mvc",
                    ClientName = "RookEcomShop Customer Client",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    RedirectUris = { $"{clientUrls["Mvc"]}/signin-oidc" },
                    FrontChannelLogoutUri = $"{clientUrls["Mvc"]}/signout-oidc",
                    PostLogoutRedirectUris = { $"{clientUrls["Mvc"]}/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes =
                    {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile,
                         "rookEcomShop.api"
                    }
                },

                  new Client
                {
                    ClientId = "rookEcomShop.react",
                    ClientName = "RookEcomShop Admin Client",
                    ClientUri = "https://localhost:5003",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris = {$"{clientUrls["React"]}/login-callback" },

                    PostLogoutRedirectUris = { $"{clientUrls["React"]}/logout" },
                    AllowedCorsOrigins = { $"{clientUrls["React"]}" },

                    AllowedScopes =
                    {
                          IdentityServerConstants.StandardScopes.OpenId,
                          IdentityServerConstants.StandardScopes.Profile,
                          "rookEcomShop.api"
                    }
                }
            };
    }
}
