using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TheChopClub.Services;

namespace TheChopClub.Pages.Barbershop;

public class CreatePostModel : PageModel
{
    private readonly IPostService _postService;
    private readonly IProfileService _profileService;

    public CreatePostModel(IPostService postService, IProfileService profileService)
    {
        _postService = postService;
        _profileService = profileService;
    }

    [BindProperty]
    [Required(ErrorMessage = "O título é obrigatório")]
    [StringLength(150, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 150 caracteres")]
    public string Title { get; set; } = string.Empty;

    [BindProperty]
    [StringLength(1000, ErrorMessage = "A descrição não pode ter mais de 1000 caracteres")]
    public string? Description { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "A URL da imagem é obrigatória")]
    [Url(ErrorMessage = "URL inválido")]
    public string ImageUrl { get; set; } = string.Empty;

    [TempData]
    public string? ErrorMessage { get; set; }

    [TempData]
    public string? SuccessMessage { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        var userType = HttpContext.Session.GetString("UserType");

        // Verificar se está autenticado
        if (userId == null)
        {
            return RedirectToPage("/Login");
        }

        // Verificar se é barbeiro
        if (userType != "Barber")
        {
            TempData["ErrorMessage"] = "Apenas barbeiros podem criar posts.";
            return RedirectToPage("/Index");
        }

        // Verificar se tem barbearia
        var barbershop = await _profileService.GetBarbershopByUserIdAsync(userId.Value);
        if (barbershop == null)
        {
            TempData["ErrorMessage"] = "Precisa criar uma barbearia primeiro.";
            return RedirectToPage("/Profile/Index");
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        var userType = HttpContext.Session.GetString("UserType");

        if (userId == null)
        {
            return RedirectToPage("/Login");
        }

        if (userType != "Barber")
        {
            ErrorMessage = "Apenas barbeiros podem criar posts.";
            return RedirectToPage("/Index");
        }

        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Obter barbearia
        var barbershop = await _profileService.GetBarbershopByUserIdAsync(userId.Value);
        if (barbershop == null)
        {
            ErrorMessage = "Precisa criar uma barbearia primeiro.";
            return RedirectToPage("/Profile/Index");
        }

        // Criar post
        var result = await _postService.CreatePostAsync(
            barbershop.Id,
            Title,
            Description ?? string.Empty,
            ImageUrl
        );

        if (!result.Success)
        {
            ErrorMessage = result.Message;
            return Page();
        }

        SuccessMessage = "Post publicado com sucesso!";
        return RedirectToPage("/Index");
    }
}