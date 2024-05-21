using System.Security.Claims;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.IdentityServer.Pages.Account.Register
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public RegisterInputModel RegisterInputModel { get; set; } = null!;
        [FromQuery]
        public string? ReturnUrl { get; set; }
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost(RegisterInputModel registerInputModel)
        {
            var existingUser = _userManager.FindByEmailAsync(registerInputModel.Email).Result;
            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "Email already exists");
                return Page();
            }

            var newUser = new User
            {
                FirstName = registerInputModel.Firstname,
                LastName = registerInputModel.Lastname,
                UserName = registerInputModel.Email,
                Email = registerInputModel.Email,
                EmailConfirmed = true,
            };
            var result = await _userManager.CreateAsync(newUser, registerInputModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return await Task.FromResult<IActionResult>(Page());
            }

            await _userManager.AddToRoleAsync(newUser, "Buyer");

            result = _userManager.AddClaimsAsync(newUser, new Claim[]{
                            new Claim(JwtClaimTypes.Name, newUser.FirstName + " " + newUser.LastName),
                            new Claim(JwtClaimTypes.GivenName, newUser.FirstName),
                            new Claim(JwtClaimTypes.FamilyName, newUser.LastName),
                        }).Result;

            var signInResult = await _signInManager.PasswordSignInAsync(registerInputModel.Email, registerInputModel.Password, true, lockoutOnFailure: true);

            if (signInResult.Succeeded)
            {

            }

            // request for a local page
            if (Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }
            else if (string.IsNullOrEmpty(ReturnUrl))
            {
                return Redirect("~/");
            }
            else
            {
                // user might have clicked on a malicious link - should be logged
                throw new Exception("invalid return URL");
            }
        }
    }
}
