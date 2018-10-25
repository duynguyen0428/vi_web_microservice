using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace authenticate.service {
    public static class Config {
        public static IEnumerable<ApiResource> GetApiResources () {
            return new List<ApiResource> {
                new ApiResource ("api1", "My API")
                //new ApiResource ("postman_api", "Postman Test Resource")
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients () {
            // client credentials client
            return new List<Client> {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret ("secret".Sha256 ())
                    },
                    AllowedScopes = { "api1" }
                },
                //new Client {
                //    ClientId = "postman-api",
                //    ClientName = "Postman Test Client",
                //    AllowedGrantTypes = GrantTypes.Code,
                //    AllowAccessTokensViaBrowser = true,
                //    RequireConsent = false,
                //    RedirectUris = { "https://www.getpostman.com/oauth2/callback" },
                //    //NOTE: This link needs to match the link from the presentation layer - oidc-client
                //    //      otherwise IdentityServer won't display the link to go back to the site
                //    PostLogoutRedirectUris = { "https://www.getpostman.com" },
                //    AllowedCorsOrigins = { "https://www.getpostman.com" },
                //    EnableLocalLogin = true,
                //    AllowedScopes = {
                //    IdentityServerConstants.StandardScopes.OpenId,
                //    IdentityServerConstants.StandardScopes.Profile,
                //    IdentityServerConstants.StandardScopes.Email,
                //    "postman_api"
                //    },
                //    ClientSecrets = new List<Secret> () { new Secret ("SomeValue".Sha256 ()) }
                //},
                                // OpenID Connect hybrid flow and client credentials client (MVC)
                //new Client
                //{
                //    ClientId = "mvc",
                //    ClientName = "MVC Client",
                //    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

                //    ClientSecrets =
                //    {
                //        new Secret("secret".Sha256())
                //    },

                //    RedirectUris = { "http://localhost:5000/signin-oidc" },
                //    PostLogoutRedirectUris = { "http://localhost:5000/signout-callback-oidc" },

                //    AllowedScopes =
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile,
                //        "api1"
                //    },
                //    AllowOfflineAccess = true
                //}

            };
        }

        public static List<TestUser> GetUsers () {
            return new List<TestUser> {
                new TestUser {
                    SubjectId = "1",
                        Username = "alice",
                        Password = "password"
                },
                new TestUser {
                    SubjectId = "2",
                        Username = "bob",
                        Password = "password"
                }
            };
        }
    }
}