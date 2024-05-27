using IdentityServer4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.IdentityServer.Persistence.Repositories;

namespace RookEcomShop.IdentityServer.Controllers.Users
{
    [ApiController]
    [Route("api/v1/users")]
    public class UsersController : ControllerBase
    {
        private readonly UsersRepository _userRepository;

        public UsersController(UsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Authorize(Policy = "Bearer")]
        public async Task<IActionResult> GetUsers()
        {
            if(User?.Identity?.IsAuthenticated == true)
            {
                var users = await _userRepository.GetListUsers();
                return Ok(users);
            }


            return Unauthorized();
        }
    }
}

