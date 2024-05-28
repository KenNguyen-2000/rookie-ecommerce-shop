using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RookEcomShop.Domain.Entities;
using RookEcomShop.IdentityServer.Domain;
using RookEcomShop.IdentityServer.Views.Account.Register;
using RookEcomShop.Persistence;

namespace RookEcomShop.IdentityServer.Pages.Account.Register;

public class IndexModel : PageModel
{
    public RegisterViewModel RegisterViewModel { get; set; } = new();
    public string ReturnUrl { get; set; } = "~/";

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
            return Page();

        if (RegisterInputModel.Username is null || RegisterInputModel.Password is null || RegisterInputModel.PhoneNumber is null)
            return Page();

        var user = await _userManager.FindByNameAsync(RegisterInputModel.Username);
        if (user is not null)
        {
            ModelState.AddModelError("Username", "Username is already taken");
            return Page();
        }

        user = new ApplicationUser()
        {
            UserName = RegisterInputModel.Username,
            Email = RegisterInputModel.Username,
            PhoneNumber = RegisterInputModel.PhoneNumber,
            FirstName = RegisterInputModel.Firstname,
            LastName = RegisterInputModel.Lastname,
            EmailConfirmed = true
        };

        var identityTask = _userManager.CreateAsync(user, RegisterInputModel.Password);

        _rookEcomContext.Users.Add(new User
        {
            Email = RegisterInputModel.Username,
            PhoneNumber = RegisterInputModel.PhoneNumber,
            FirstName = RegisterInputModel.Firstname,
            LastName = RegisterInputModel.Lastname,
        });
        var appTask = _rookEcomContext.SaveChangesAsync();
        await Task.WhenAll(identityTask, appTask);
        Console.WriteLine("Finish");
        if (appTask.IsFaulted || identityTask.IsFaulted)
        {
            Console.WriteLine("Something went wrong!");
            ModelState.AddModelError(string.Empty, "An error occurred while creating the user");
            return Page();
        }
        if (!identityTask.Result.Succeeded)
        {
            Console.WriteLine("Identity task failed");
            foreach (var error in identityTask.Result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return Page();
        }

        await _userManager.AddClaimsAsync(user,
        [
            new(JwtClaimTypes.PhoneNumber, user.PhoneNumber),
            new(JwtClaimTypes.Email, user.Email)
        ]);

        await _userManager.AddToRoleAsync(user, "Buyer");

        return RedirectToPage("/Account/Login/Index", new { returnUrl = ReturnUrl });
    }
}