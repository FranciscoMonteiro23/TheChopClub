using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheChopClub.Models;

/// <summary>
/// Representa um produto vendido por uma barbearia
/// </summary>
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int BarbershopId { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    [Required(ErrorMessage = "O preço é obrigatório")]
    [Range(0.01, 10000, ErrorMessage = "O preço deve ser maior que zero")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public string? ImageUrl { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Stock { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navegação
    [ForeignKey("BarbershopId")]
    public Barbershop Barbershop { get; set; } = null!;
}