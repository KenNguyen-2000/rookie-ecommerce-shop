using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Infrastructure.ConfigurationOptions
{
    public class AppSettings
    {
        public ConnectionStrings? ConnectionStrings { get; set; }
        public Cors? Cors { get; set; }
        public IdentityServerSettings? IdentityServerSettings { get; set; }
    }
}
