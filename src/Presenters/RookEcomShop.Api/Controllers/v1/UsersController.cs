using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Dto;
using RookEcomShop.Application.Handlers.Users.GetById;
using RookEcomShop.Application.Handlers.Users.GetList;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly UserContext _userContext;

        public UsersController(ISender sender, UserContext userContext)
        {
            _sender = sender;
            _userContext = userContext;
        }

        [Authorize]
        [HttpGet("detail")]
        public async Task<IActionResult> GetById()
        {
            var query = new GetUserByIdQuery { Id = _userContext.UserId };
            var result = await _sender.Send(query);
            if (result.IsFailed)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetListUsers([FromQuery] QueryDto queryDto)
        {
            var query = new GetListUsersQuery
            {
                QueryObject = queryDto
            };
            var result = await _sender.Send(query);
            if (result.IsFailed)
            {
                return NotFound();
            }
            return Ok(result.Value);
        }
    }
}
