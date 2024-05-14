using IdentityServer4.Models;

namespace RookEcomShop.IndentityServer
{
    public static class IdentityServerConfig
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                   };
        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("rookEcomShop.api", "RookEcomShop Api")
            };


        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("rookEcomShop.read"),
                new ApiScope("rookEcomShop.write"),
            };

        public static IEnumerable<Client> Clients(Dictionary<string, string> clientUrls) =>
            new Client[]
            {
                 new Client
                {
                    ClientId = "rookEcomShop.mvc",
                    ClientName = "RookEcomShop Customer Client",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    RedirectUris = { "https://localhost:5002/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:5002/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile",  "rookEcomShop.api" }
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

                    RedirectUris =
                    {
                        "https://localhost:5003/index.html",
                        "https://localhost:5003/callback.html"
                    },

                    PostLogoutRedirectUris = { "https://localhost:5003/index.html" },
                    AllowedCorsOrigins = { "https://localhost:5003" },

                    AllowedScopes = { "openid", "profile", "rookEcomShop.api" }
                }
            };
    }
}
