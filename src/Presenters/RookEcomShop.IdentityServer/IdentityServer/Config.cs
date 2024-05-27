using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;

namespace RookEcomShop.IdentityServer.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new List<IdentityResource>
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource(
         name: "roles",
         userClaims: new[] {JwtClaimTypes.Role})
                   };
        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource("rookEcomShop.api", "RookEcomShop Api") {Scopes = {"rookEcomShop.api"}, UserClaims = {JwtClaimTypes.Role}}
            };


        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("rookEcomShop.api", "RookEcomShop Api")
            };

        public static IEnumerable<Client> Clients(Dictionary<string, string> clientUrls) =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "rookEcomShop.client",
                    ClientName = "Swagger UI for RookEcomShop",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,
                    AllowAccessTokensViaBrowser = true,

                    RequireConsent = false,
                    RequirePkce = true,

                    RedirectUris =           { $"{clientUrls["Swagger"]}/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { $"{clientUrls["Swagger"]}/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins =     { $"{clientUrls["Swagger"]}" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "rookEcomShop.api",
                        "roles"
                    },
                    AccessTokenLifetime = 3600,
                    IdentityTokenLifetime = 3600
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
                         "rookEcomShop.api",
                        "roles"

                    },
                    AccessTokenLifetime = 3600,
                    IdentityTokenLifetime = 3600
                },

                  new Client
                {
                    ClientId = "rookEcomShop.react",
                    ClientName = "RookEcomShop Admin Client",
                    ClientUri = clientUrls["React"],
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris = {
                        $"{clientUrls["React"]}/authentication/login-callback"
                     },

                    PostLogoutRedirectUris = {
                         $"{clientUrls["React"]}/unauthorized",
                        $"{clientUrls["React"]}/authentication/logout-callback",
                        $"{clientUrls["React"]}"
                     },
                    AllowedCorsOrigins = { $"{clientUrls["React"]}" },

                    AllowedScopes =
                    {
                          IdentityServerConstants.StandardScopes.OpenId,
                          IdentityServerConstants.StandardScopes.Profile,
                          "rookEcomShop.api",
                          "roles"
                    },
                    AccessTokenLifetime = 3600,
                    IdentityTokenLifetime = 3600
                }
            };
    }
}
