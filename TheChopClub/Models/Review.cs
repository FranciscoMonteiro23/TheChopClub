using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheChopClub.Models;

/// <summary>
/// Representa uma avaliação feita por um cliente a uma barbearia
/// </summary>
public class Review
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int BarbershopId { get; set; }

    [Required(ErrorMessage = "A classificação é obrigatória")]
    [Range(1, 5, ErrorMessage = "A classificação deve ser entre 1 e 5")]
    public int Rating { get; set; }

    [Required(ErrorMessage = "O comentário é obrigatório")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "O comentário deve ter entre 10 e 500 caracteres")]
    public string Comment { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navegação
    [ForeignKey("UserId")]
    public User User { get; set; } = null!;

    [ForeignKey("BarbershopId")]
    public Barbershop Barbershop { get; set; } = null!;
}