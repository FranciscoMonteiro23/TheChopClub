using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheChopClub.Models;

/// <summary>
/// Representa uma barbearia na plataforma
/// </summary>
public class Barbershop
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required(ErrorMessage = "O nome da barbearia é obrigatório")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(1000)]
    public string? Description { get; set; }

    [StringLength(200)]
    public string? Address { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória")]
    [StringLength(100)]
    public string City { get; set; } = string.Empty;

    [Phone]
    [StringLength(20)]
    public string? Phone { get; set; }

    [Range(0, 5)]
    public decimal Rating { get; set; } = 0;

    public int TotalReviews { get; set; } = 0;

    public bool IsPremium { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navegação
    [ForeignKey("UserId")]
    public User User { get; set; } = null!;

    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Product> Products { get; set; } = new List<Product>();
}