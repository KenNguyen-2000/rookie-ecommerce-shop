using Microsoft.AspNetCore.Authentication;
using Serilog;
using System.Net;

namespace RookEcomShop.CustomerFrontend.Extensions
{
    public class UnauthorizedHttpClientHandler : DelegatingHandler
    {

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            if(response.StatusCode == HttpStatusCode.Unauthorized)
            {
                Log.Error("Unauthorized request");
                throw new UnauthorizedAccessException();
            }

            return response;
        }
    }

}