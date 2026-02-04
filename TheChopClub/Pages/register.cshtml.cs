using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TheChopClub.Models;
using TheChopClub.Services;

namespace TheChopClub.Pages;

public class RegisterModel : PageModel
{
    private readonly IAuthService _authService;

    public RegisterModel(IAuthService authService)
    {
        _authService = authService;
    }

    [BindProperty]
    [Required(ErrorMessage = "O nome de utilizador é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres")]
    public string Username { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "A password é obrigatória")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "A password deve ter pelo menos 6 caracteres")]
    public string Password { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "Confirme a password")]
    [Compare("Password", ErrorMessage = "As passwords não coincidem")]
    public string ConfirmPassword { get; set; } = string.Empty;

    [BindProperty]
    public UserType UserType { get; set; }

    [TempData]
    public string? ErrorMessage { get; set; }

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

        var result = await _authService.RegisterAsync(Username, Email, Password, UserType);

        if (!result.Success)
        {
            ErrorMessage = result.Message;
            return Page();
        }

        TempData["SuccessMessage"] = "Conta criada com sucesso! Faça login para continuar.";
        return RedirectToPage("/Login");
    }
}