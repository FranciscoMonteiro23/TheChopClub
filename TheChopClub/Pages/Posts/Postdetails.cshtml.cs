using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TheChopClub.Models;
using TheChopClub.Services;

namespace TheChopClub.Pages;

public class PostDetailsModel : PageModel
{
    private readonly IPostService _postService;
    private readonly ICommentService _commentService;

    public PostDetailsModel(IPostService postService, ICommentService commentService)
    {
        _postService = postService;
        _commentService = commentService;
    }

    public Post? Post { get; set; }
    public List<Comment> Comments { get; set; } = new();
    public List<Post> RelatedPosts { get; set; } = new();
    public int? UserId { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "O comentário não pode estar vazio")]
    [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
    public string NewComment { get; set; } = string.Empty;

    [TempData]
    public string? SuccessMessage { get; set; }

    [TempData]
    public string? ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        // Obter utilizador da sessão
        UserId = HttpContext.Session.GetInt32("UserId");

        // Carregar post
        Post = await _postService.GetPostByIdAsync(id);

        if (Post == null)
        {
            return Page();
        }

        // Incrementar visualizações
        await _postService.IncrementViewsAsync(id);

        // Carregar comentários
        Comments = await _commentService.GetCommentsByPostIdAsync(id);

        // Carregar posts relacionados (da mesma barbearia)
        RelatedPosts = await _postService.GetPostsByBarbershopIdAsync(Post.BarbershopId);
        RelatedPosts = RelatedPosts.Where(p => p.Id != id).Take(6).ToList();

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        UserId = HttpContext.Session.GetInt32("UserId");

        if (UserId == null)
        {
            ErrorMessage = "Precisa estar autenticado para comentar";
            return RedirectToPage("/Login");
        }

        if (!ModelState.IsValid)
        {
            // Recarregar dados
            await OnGetAsync(id);
            return Page();
        }

        var result = await _commentService.AddCommentAsync(id, UserId.Value, NewComment);

        if (result.Success)
        {
            SuccessMessage = result.Message;
            NewComment = string.Empty;
        }
        else
        {
            ErrorMessage = result.Message;
        }

        return RedirectToPage(new { id });
    }

    public async Task<IActionResult> OnPostDeleteCommentAsync(int id, int commentId)
    {
        UserId = HttpContext.Session.GetInt32("UserId");

        if (UserId == null)
        {
            ErrorMessage = "Precisa estar autenticado";
            return RedirectToPage("/Login");
        }

        var result = await _commentService.DeleteCommentAsync(commentId, UserId.Value);

        if (result.Success)
        {
            SuccessMessage = result.Message;
        }
        else
        {
            ErrorMessage = result.Message;
        }

        return RedirectToPage(new { id });
    }
}