using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Handlers.Users.GetById;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly UserContext _userContext;

        public UserController(ISender sender, UserContext userContext)
        {
            _sender = sender;
            _userContext = userContext;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetUserByIdQuery { Id = _userContext.UserId };
            var result = await _sender.Send(query);
            if (result.IsFailed)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
