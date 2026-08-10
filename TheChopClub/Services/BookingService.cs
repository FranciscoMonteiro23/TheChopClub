using Microsoft.EntityFrameworkCore;
using TheChopClub.Models;

namespace TheChopClub.Services
{
    public class BookingService
    {
        private readonly ApplicationDbContext _context;

        // Horário de funcionamento da barbearia (pode tornar configurável no futuro)
        private static readonly TimeSpan OpeningTime = new TimeSpan(9, 0, 0);
        private static readonly TimeSpan ClosingTime = new TimeSpan(19, 0, 0);
        private static readonly TimeSpan SlotDuration = TimeSpan.FromMinutes(30);

        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// 
        /// Devolve todos os horários possíveis de um dia (ex: 09:00, 09:30, 10:00...)
        /// e marca quais já estão ocupados.

        public async Task<List<TimeSlot>> GetAvailableSlotsAsync(int barbershopId, DateTime date)
        {
            var dayStart = date.Date;

            var existingBookings = await _context.Bookings
                .Where(b => b.BarbershopId == barbershopId
                            && b.Date.Date == dayStart
                            && b.Status != BookingStatus.Cancelled)
                .Select(b => b.Time)
                .ToListAsync();

            var slots = new List<TimeSlot>();
            var current = OpeningTime;

            while (current < ClosingTime)
            {
                slots.Add(new TimeSlot
                {
                    Time = current,
                    IsAvailable = !existingBookings.Contains(current)
                });
                current = current.Add(SlotDuration);
            }

            return slots;
        }

        public async Task<Booking?> CreateBookingAsync(int barbershopId, int userId, DateTime date, TimeSpan time, string? notes)
        {
            // Verificar se o horário ainda está livre (evitar duplo booking)
            var alreadyBooked = await _context.Bookings.AnyAsync(b =>
                b.BarbershopId == barbershopId &&
                b.Date.Date == date.Date &&
                b.Time == time &&
                b.Status != BookingStatus.Cancelled);

            if (alreadyBooked)
                return null;

            var booking = new Booking
            {
                BarbershopId = barbershopId,
                UserId = userId,
                Date = date.Date,
                Time = time,
                Notes = notes,
                Status = BookingStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return booking;
        }

        public async Task<List<Booking>> GetUserBookingsAsync(int userId)
        {
            return await _context.Bookings
                .Include(b => b.Barbershop)
                .Where(b => b.UserId == userId)
                .OrderByDescending(b => b.Date)
                .ThenByDescending(b => b.Time)
                .ToListAsync();
        }

        public async Task<bool> CancelBookingAsync(int bookingId, int userId)
        {
            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == bookingId && b.UserId == userId);

            if (booking == null)
                return false;

            booking.Status = BookingStatus.Cancelled;
            await _context.SaveChangesAsync();
            return true;
        }
    }

    public class TimeSlot
    {
        public TimeSpan Time { get; set; }
        public bool IsAvailable { get; set; }
    }
}