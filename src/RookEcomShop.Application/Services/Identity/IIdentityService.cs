using RookEcomShop.Application.Common.Dto;
using RookEcomShop.ViewModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Services.Identity
{
    public interface IIdentityService
    {
        public Task<Response> RegisterAsync(RegisterRequest registerRequest);
    }
}
