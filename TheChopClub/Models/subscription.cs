using System.ComponentModel.DataAnnotations;

namespace TheChopClub.Models
{
    public enum SubscriptionTier
    {
        Free = 0,
        Premium = 1,
        Professional = 2
    }

    public class Subscription
    {
        public int Id { get; set; }

        public SubscriptionTier Tier { get; set; } = SubscriptionTier.Free;

        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; } = true;

        // Funcionalidades por tier
        public int MaxPhotosPerPost { get; set; } = 5;
        public bool CanUseAnalytics { get; set; } = false;
        public bool CanUseShop { get; set; } = false;
        public bool HasPrioritySupport { get; set; } = false;
        public bool CanHighlightPosts { get; set; } = false;

        // Relação
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}