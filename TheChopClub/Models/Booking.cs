using System.ComponentModel.DataAnnotations;

namespace TheChopClub.Models
{
    public enum BookingStatus
    {
        Pending = 0,
        Confirmed = 1,
        Cancelled = 2,
        Completed = 3
    }

    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relações
        public int BarbershopId { get; set; }
        public Barbershop Barbershop { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}