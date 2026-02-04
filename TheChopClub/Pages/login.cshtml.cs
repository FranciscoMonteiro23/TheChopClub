using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TheChopClub.Services;

namespace TheChopClub.Pages;

public class LoginModel : PageModel
{
    private readonly IAuthService _authService;

    public LoginModel(IAuthService authService)
    {
        _authService = authService;
    }

    [BindProperty]
    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "A password é obrigatória")]
    public string Password { get; set; } = string.Empty;

    [TempData]
    public string? ErrorMessage { get; set; }

    [TempData]
    public string? SuccessMessage { get; set; }

    public void OnGet()
    {
        if (HttpContext.Session.GetInt32("UserId") != null)
        {
            Response.Redirect("/Index");
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var result = await _authService.LoginAsync(Email, Password);

        if (!result.Success)
        {
            ErrorMessage = result.Message;
            return Page();
        }

        HttpContext.Session.SetInt32("UserId", result.User!.Id);
        HttpContext.Session.SetString("Username", result.User.Username);
        HttpContext.Session.SetString("UserType", result.User.UserType.ToString());

        if (result.User.UserType == Models.UserType.Barber)
        {
            return RedirectToPage("/Barbershop/Dashboard");
        }
        else
        {
            return RedirectToPage("/Index");
        }
    }
}




