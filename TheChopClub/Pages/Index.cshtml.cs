using Microsoft.AspNetCore.Mvc.RazorPages;
using TheChopClub.Models;
using TheChopClub.Services;

namespace TheChopClub.Pages;

public class IndexModel : PageModel
{
    private readonly IPostService _postService;
    private readonly ApplicationDbContext _context;

    public IndexModel(IPostService postService, ApplicationDbContext context)
    {
        _postService = postService;
        _context = context;
    }

    public List<Post> Posts { get; set; } = new();
    public List<Models.Barbershop> TopBarbershops { get; set; } = new();
    public int? UserId { get; set; }
    public int TotalBarbershops { get; set; }
    public int TotalPosts { get; set; }
    public int TotalUsers { get; set; }

    public async Task OnGetAsync()
    {
        UserId = HttpContext.Session.GetInt32("UserId");

        Posts = await _postService.GetAllPostsAsync(0, 20);

        TopBarbershops = _context.Barbershops
            .OrderByDescending(b => b.Rating)
            .ThenByDescending(b => b.TotalReviews)
            .Take(5)
            .ToList();

        TotalBarbershops = _context.Barbershops.Count();
        TotalPosts = _context.Posts.Count();
        TotalUsers = _context.Users.Count();

        foreach (var post in Posts)
        {
            _ = _postService.IncrementViewsAsync(post.Id);
        }
    }
}