using Microsoft.EntityFrameworkCore;
using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Serviço responsável pela autenticação e registo de utilizadores
/// </summary>
public class AuthService : IAuthService
{
    private readonly ApplicationDbContext _context;

    public AuthService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<(bool Success, string Message, User? User)> RegisterAsync(
        string username,
        string email,
        string password,
        UserType userType)
    {
        try
        {
            // Validações
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                return (false, "O nome de utilizador deve ter pelo menos 3 caracteres", null);

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return (false, "Email inválido", null);

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                return (false, "A password deve ter pelo menos 6 caracteres", null);

            // Verificar se email já existe
            if (await EmailExistsAsync(email))
                return (false, "Este email já está registado", null);

            // Verificar se username já existe
            if (await UsernameExistsAsync(username))
                return (false, "Este nome de utilizador já está em uso", null);

            // Criar novo utilizador
            var user = new User
            {
                Username = username,
                Email = email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                UserType = userType,
                CreatedAt = DateTime.UtcNow
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return (true, "Registo efetuado com sucesso!", user);
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao registar: {ex.Message}", null);
        }
    }

    public async Task<(bool Success, string Message, User? User)> LoginAsync(string email, string password)
    {
        try
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(email))
                return (false, "Email é obrigatório", null);

            if (string.IsNullOrWhiteSpace(password))
                return (false, "Password é obrigatória", null);

            // Procurar utilizador
            var user = await _context.Users
                .Include(u => u.Barbershop)
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
                return (false, "Email ou password incorretos", null);

            // Verificar password
            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return (false, "Email ou password incorretos", null);

            return (true, "Login efetuado com sucesso!", user);
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao fazer login: {ex.Message}", null);
        }
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await _context.Users.AnyAsync(u => u.Email == email);
    }

    public async Task<bool> UsernameExistsAsync(string username)
    {
        return await _context.Users.AnyAsync(u => u.Username == username);
    }

    public async Task<User?> GetUserByIdAsync(int userId)
    {
        return await _context.Users
            .Include(u => u.Barbershop)
            .FirstOrDefaultAsync(u => u.Id == userId);
    }
}