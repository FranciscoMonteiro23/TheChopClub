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
    private readonly BookingService _bookingService;

    public PostDetailsModel(
        IPostService postService,
        ICommentService commentService,
        BookingService bookingService)
    {
        _postService = postService;
        _commentService = commentService;
        _bookingService = bookingService;
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

    [TempData]
    public string? BookingSuccessMessage { get; set; }

    [TempData]
    public string? BookingErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        UserId = HttpContext.Session.GetInt32("UserId");

        Post = await _postService.GetPostByIdAsync(id);

        if (Post == null)
        {
            return Page();
        }

        await _postService.IncrementViewsAsync(id);

        Comments = await _commentService.GetCommentsByPostIdAsync(id);

        RelatedPosts = await _postService.GetPostsByBarbershopIdAsync(Post.BarbershopId);
        RelatedPosts = RelatedPosts.Where(p => p.Id != id).Take(6).ToList();

        return Page();
    }

    public async Task<IActionResult> OnGetAvailableSlotsAsync(int barbershopId, string date)
    {
        if (!DateTime.TryParse(date, out var bookingDate))
        {
            return BadRequest();
        }

        var slots = await _bookingService.GetAvailableSlotsAsync(barbershopId, bookingDate);

        var result = slots.Select(s => new
        {
            time = s.Time.ToString(@"hh\:mm"),
            available = s.IsAvailable
        });

        return new JsonResult(result);
    }

    public async Task<IActionResult> OnPostBookAsync(
        int id,
        int barbershopId,
        DateTime bookingDate,
        string bookingTime,
        string? bookingNotes)
    {
        UserId = HttpContext.Session.GetInt32("UserId");

        if (UserId == null)
        {
            BookingErrorMessage = "Precisa estar autenticado para marcar um horário";
            return RedirectToPage(new { id });
        }

        if (!TimeSpan.TryParse(bookingTime, out var time))
        {
            BookingErrorMessage = "Horário inválido";
            return RedirectToPage(new { id });
        }

        var booking = await _bookingService.CreateBookingAsync(
            barbershopId,
            UserId.Value,
            bookingDate,
            time,
            bookingNotes);

        if (booking == null)
        {
            BookingErrorMessage = "Este horário já não está disponível. Escolha outro.";
            return RedirectToPage(new { id });
        }

        BookingSuccessMessage = $"Marcação confirmada para {bookingDate:dd/MM/yyyy} às {time:hh\\:mm}.";
        return RedirectToPage(new { id });
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
