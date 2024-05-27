using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace RookEcomShop.IdentityServer.Pages.Home
{
    public class ErrorModel : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;
        private readonly IIdentityServerInteractionService _interraction;
        private readonly IWebHostEnvironment environment;

        public ErrorModel(IIdentityServerInteractionService interraction, IWebHostEnvironment environment, ILogger<ErrorModel> logger)
        {
            _interraction = interraction;
            this.environment = environment;
            _logger = logger;
        }

        public ErrorViewModel View { get; set; } = new();

        public async Task OnGet(string? errorId)
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

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
