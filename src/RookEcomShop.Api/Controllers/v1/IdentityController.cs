using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Identity;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/identity")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
