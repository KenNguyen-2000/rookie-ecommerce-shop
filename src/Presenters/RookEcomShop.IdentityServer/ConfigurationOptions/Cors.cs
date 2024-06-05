using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.IdentityServer.ConfigurationOptions
{
    public class Cors
    {
        public const string SectionName = "Cors";
        public string[] AllowedOrigins { get; set; } = [];
        public bool AllowAnyOrigin;
    }
}
