using IdentityModel;
using IdentityServer4.Test;
using IdentityServer4;
using System.Security.Claims;
using System.Text.Json;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.IdentityServer
{
    public class TestUsers
    {
        public static List<User> Users
        {
            get
            {
                var address = new
                {
                    street_address = "One Hacker Way",
                    locality = "Heidelberg",
                    postal_code = 69118,
                    country = "Germany"
                };

                return new List<User>
                {
                    new User
                    {
                        Id = 3,
                        UserName = "admin",
                        Password = "admin"
                    }
                };
            }
        }
    }
}
