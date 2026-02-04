using System.ComponentModel.DataAnnotations;

namespace TheChopClub.Models;

/// <summary>
/// Representa um utilizador da plataforma (Cliente ou Barbeiro)
/// </summary>
public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome de utilizador é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    public UserType UserType { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string? ProfilePicture { get; set; }

    [StringLength(500)]
    public string? Bio { get; set; }

    [StringLength(100)]
    public string? Location { get; set; }

    // Navegação
    public Barbershop? Barbershop { get; set; }
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}