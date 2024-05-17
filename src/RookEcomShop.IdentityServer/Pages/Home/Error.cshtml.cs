using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using System;

namespace RookEcomShop.IdentityServer.Pages.Home
{
    public class ErrorModel : PageModel
    {
        private readonly IIdentityServerInteractionService _interraction;
        private readonly IWebHostEnvironment environment;

        public ErrorModel(IIdentityServerInteractionService interraction, IWebHostEnvironment environment)
        {
            _interraction = interraction;
            this.environment = environment;
        }

        public ErrorViewModel View { get; set; } = new();

        public async Task OnGet(string? errorId)
        {
            // retrieve error details from identityserver
            var message = await _interraction.GetErrorContextAsync(errorId);
            if (message is not null)
            {
                View.Error = message;

                if (!environment.IsDevelopment())
                    // only show in development
                    message.ErrorDescription = null;
            }
        }
    }
}
