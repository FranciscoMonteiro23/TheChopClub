using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Interface para gestão de perfis de utilizadores
/// </summary>
public interface IProfileService
{
    /// <summary>
    /// Atualiza o perfil de um utilizador
    /// </summary>
    Task<(bool Success, string Message)> UpdateProfileAsync(int userId, string? bio, string? location, string? profilePicture);

    /// <summary>
    /// Cria uma barbearia para um utilizador
    /// </summary>
    Task<(bool Success, string Message, Barbershop? Barbershop)> CreateBarbershopAsync(
        int userId,
        string name,
        string city,
        string? description = null,
        string? address = null,
        string? phone = null);

    /// <summary>
    /// Atualiza informações de uma barbearia
    /// </summary>
    Task<(bool Success, string Message)> UpdateBarbershopAsync(
        int barbershopId,
        string name,
        string city,
        string? description,
        string? address,
        string? phone);

    /// <summary>
    /// Obtém a barbearia de um utilizador
    /// </summary>
    Task<Barbershop?> GetBarbershopByUserIdAsync(int userId);
}