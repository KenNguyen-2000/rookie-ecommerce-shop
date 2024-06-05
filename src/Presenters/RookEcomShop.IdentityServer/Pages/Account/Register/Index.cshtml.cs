using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Domain.Entities;
using RookEcomShop.IdentityServer.Domain;
using RookEcomShop.Persistence;
using Serilog;

namespace RookEcomShop.IdentityServer.Pages.Account.Register;

public class IndexModel : PageModel
{
    public RegisterViewModel RegisterViewModel { get; set; } = new();
    [FromQuery]
    public string? ReturnUrl { get; set; }

    [BindProperty]
    public RegisterInputModel RegisterInputModel { get; set; } = new();

    private readonly UserManager<ApplicationUser> _userManager;

    private readonly RookEcomShopDbContext _rookEcomContext;

    public IndexModel(UserManager<ApplicationUser> userManager, RookEcomShopDbContext rookEcomContext)
    {
        _userManager = userManager;
        _rookEcomContext = rookEcomContext;
    }


    public IActionResult OnGet(string? returnUrl)
    {
        if (User?.Identity?.IsAuthenticated == true)
        {
            return Redirect("~/");
        }

        ReturnUrl = returnUrl ?? "~/";

        return Page();
    }

    public async Task<IActionResult> OnPost(string button)
    {
        if (button != "register")
            return RedirectToPage("/Account/Login/Index", new { returnUrl = ReturnUrl });

        if (!ModelState.IsValid)
        {
            Log.Error("Model state is invalid");
            return Page();
        }

        if (RegisterInputModel.Username is null || RegisterInputModel.Password is null || RegisterInputModel.PhoneNumber is null)
            return Page();

        var user = await _userManager.FindByNameAsync(RegisterInputModel.Username);
        var appUser = await _rookEcomContext.Users.FirstOrDefaultAsync(u => u.Username == RegisterInputModel.Username);
        if (user is not null || appUser is not null)
        {
            List<string> errorMessages = new List<string>();
            errorMessages.Add("Username is already taken");
            ViewData["ErrorMessages"] = errorMessages;
            ModelState.AddModelError("Username", "Username is already taken");
            return Page();
        }

        user = new ApplicationUser()
        {
            Id = Guid.NewGuid(),
            UserName = RegisterInputModel.Username,
            Email = RegisterInputModel.Email,
            PhoneNumber = RegisterInputModel.PhoneNumber,
            FirstName = RegisterInputModel.Firstname,
            LastName = RegisterInputModel.Lastname,
            EmailConfirmed = false
        };

        var result = _userManager.CreateAsync(user, RegisterInputModel.Password).Result;

        if (!result.Succeeded)
        {
            Log.Error("Identity task failed");
            List<string> errorMessages = new List<string>();
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            errorMessages.AddRange(result.Errors.Select(e => e.Description));
            ViewData["ErrorMessages"] = errorMessages;
            return Page();
        }

        appUser = await SyncUserToDomain(user);
        await _userManager.AddClaimsAsync(user,
        [
            new(JwtClaimTypes.PhoneNumber, user.PhoneNumber),
            new(JwtClaimTypes.Email, user.Email)
        ]);

        await _userManager.AddToRoleAsync(user, "Buyer");

        return RedirectToPage("/Account/Login/Index", new { returnUrl = ReturnUrl });
    }

    private async Task<User?> SyncUserToDomain(ApplicationUser user)
    {
        User? appUser = new User
        {
            Id = user.Id,
            Username = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            FirstName = user.FirstName,
            LastName = user.LastName,
            EmailConfirmed = user.EmailConfirmed
        };
        var buyerRole = await _rookEcomContext.Roles.FirstOrDefaultAsync(r => r.Name == "Buyer");
        appUser.UserRoles.Add(new UserRole { RoleId = buyerRole.Id, UserId = appUser.Id });
        _rookEcomContext.Users.Add(appUser);

        await _rookEcomContext.SaveChangesAsync();
        return appUser;
    }
}