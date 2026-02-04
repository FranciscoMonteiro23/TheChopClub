using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using TheChopClub.Models; // <-- ajusta se necessário

namespace TheChopClub.Pages
{
    public class IndexModel : PageModel
    {
        // Utilizador
        public string? UserId { get; set; }

        // Feed
        public List<Post> Posts { get; set; } = new();

        // Sidebar
        public List<Barbershop> TopBarbershops { get; set; } = new();

        // Estatísticas
        public int TotalBarbershops { get; set; }
        public int TotalPosts { get; set; }
        public int TotalUsers { get; set; }

        public void OnGet()
        {
            // ID do utilizador autenticado
            UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // ⚠️ Para já dados fake (só para não rebentar o build)
            Posts = new List<Post>();
            TopBarbershops = new List<Barbershop>();

            TotalBarbershops = 0;
            TotalPosts = 0;
            TotalUsers = 0;
        }
    }
}
