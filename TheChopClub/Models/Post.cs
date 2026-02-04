using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheChopClub.Models;

/// <summary>
/// Representa uma publicação no feed (foto de trabalho, tutorial, promoção)
/// </summary>
public class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int BarbershopId { get; set; }

    [Required(ErrorMessage = "O título é obrigatório")]
    [StringLength(150)]
    public string Title { get; set; } = string.Empty;

    [StringLength(1000)]
    public string? Description { get; set; }

    [Required(ErrorMessage = "É necessário adicionar uma imagem")]
    public string ImageUrl { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int Likes { get; set; } = 0;

    public int Views { get; set; } = 0;

    // Navegação
    [ForeignKey("BarbershopId")]
    public Barbershop Barbershop { get; set; } = null!;

    // NOVO: Comentários
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

}