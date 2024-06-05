using System.Net;

namespace RookEcomShop.CustomerFrontend.Extensions
{
    public class UnauthorizedHttpClientHandler : DelegatingHandler
    {

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException("Unauthorized access");
            }

            return response;
        }
    }

}