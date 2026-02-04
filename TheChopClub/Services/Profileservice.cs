using Microsoft.EntityFrameworkCore;
using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Serviço para gestão de perfis e barbearias
/// </summary>
public class ProfileService : IProfileService
{
    private readonly ApplicationDbContext _context;

    public ProfileService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<(bool Success, string Message)> UpdateProfileAsync(
        int userId,
        string? bio,
        string? location,
        string? profilePicture)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
                return (false, "Utilizador não encontrado");

            user.Bio = bio;
            user.Location = location;

            if (!string.IsNullOrWhiteSpace(profilePicture))
                user.ProfilePicture = profilePicture;

            await _context.SaveChangesAsync();

            return (true, "Perfil atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao atualizar perfil: {ex.Message}");
        }
    }

    public async Task<(bool Success, string Message, Barbershop? Barbershop)> CreateBarbershopAsync(
        int userId,
        string name,
        string city,
        string? description = null,
        string? address = null,
        string? phone = null)
    {
        try
        {
            // Verificar se utilizador existe e é barbeiro
            var user = await _context.Users
                .Include(u => u.Barbershop)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                return (false, "Utilizador não encontrado", null);

            if (user.UserType != UserType.Barber)
                return (false, "Apenas barbeiros podem criar barbearias", null);

            if (user.Barbershop != null)
                return (false, "Já existe uma barbearia associada a este utilizador", null);

            // Validações
            if (string.IsNullOrWhiteSpace(name))
                return (false, "O nome da barbearia é obrigatório", null);

            if (string.IsNullOrWhiteSpace(city))
                return (false, "A cidade é obrigatória", null);

            // Criar barbearia
            var barbershop = new Barbershop
            {
                UserId = userId,
                Name = name,
                City = city,
                Description = description,
                Address = address,
                Phone = phone,
                CreatedAt = DateTime.UtcNow
            };

            _context.Barbershops.Add(barbershop);
            await _context.SaveChangesAsync();

            return (true, "Barbearia criada com sucesso!", barbershop);
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao criar barbearia: {ex.Message}", null);
        }
    }

    public async Task<(bool Success, string Message)> UpdateBarbershopAsync(
        int barbershopId,
        string name,
        string city,
        string? description,
        string? address,
        string? phone)
    {
        try
        {
            var barbershop = await _context.Barbershops.FindAsync(barbershopId);

            if (barbershop == null)
                return (false, "Barbearia não encontrada");

            // Validações
            if (string.IsNullOrWhiteSpace(name))
                return (false, "O nome da barbearia é obrigatório");

            if (string.IsNullOrWhiteSpace(city))
                return (false, "A cidade é obrigatória");

            barbershop.Name = name;
            barbershop.City = city;
            barbershop.Description = description;
            barbershop.Address = address;
            barbershop.Phone = phone;

            await _context.SaveChangesAsync();

            return (true, "Barbearia atualizada com sucesso!");
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao atualizar barbearia: {ex.Message}");
        }
    }

    public async Task<Barbershop?> GetBarbershopByUserIdAsync(int userId)
    {
        return await _context.Barbershops
            .Include(b => b.User)
            .Include(b => b.Posts)
            .Include(b => b.Reviews)
            .FirstOrDefaultAsync(b => b.UserId == userId);
    }
}