using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Interface para o serviço de autenticação
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Regista um novo utilizador
    /// </summary>
    Task<(bool Success, string Message, User? User)> RegisterAsync(string username, string email, string password, UserType userType);

    /// <summary>
    /// Autentica um utilizador
    /// </summary>
    Task<(bool Success, string Message, User? User)> LoginAsync(string email, string password);

    /// <summary>
    /// Verifica se um email já está registado
    /// </summary>
    Task<bool> EmailExistsAsync(string email);

    /// <summary>
    /// Verifica se um username já está registado
    /// </summary>
    Task<bool> UsernameExistsAsync(string username);

    /// <summary>
    /// Obtém utilizador por ID
    /// </summary>
    Task<User?> GetUserByIdAsync(int userId);
}