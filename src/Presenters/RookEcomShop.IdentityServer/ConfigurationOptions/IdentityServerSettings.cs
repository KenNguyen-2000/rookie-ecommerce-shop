using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.IdentityServer.ConfigurationOptions
{
    public class IdentityServerSettings
    {
        public string? Authority { get; set; }
        public string? Audience { get; set; }
        public Dictionary<string, string>? ClientUrls { get; set; }
    }

    public class ClientUrls
    {
        public string? Mvc { get; set; }
        public string? React { get; set;}
        public string? Swagger { get; set; }
    }
}
