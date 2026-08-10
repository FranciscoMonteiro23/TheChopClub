using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using TheChopClub.Models;

namespace TheChopClub.Pages
{
    public class PremiumModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public PremiumModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public User? CurrentUser { get; set; }

        public int? CurrentUserId => HttpContext.Session.GetInt32("UserId");

        public bool IsLoggedIn => CurrentUserId.HasValue;

        public bool IsBarber { get; set; }

        public async Task OnGetAsync()
        {
            if (IsLoggedIn)
            {
                CurrentUser = await _context.Users.FindAsync(CurrentUserId);

                if (CurrentUser != null)
                {
                    IsBarber = CurrentUser.UserType == UserType.Barber;
                }
            }
        }

        public IActionResult OnPostSubscribe(string plan)
        {
            TempData["Success"] = $"Plano {plan} selecionado com sucesso!";
            return RedirectToPage();
        }
    }
}