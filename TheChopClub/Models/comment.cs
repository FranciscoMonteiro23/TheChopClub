using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheChopClub.Models;

public class Comment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PostId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required(ErrorMessage = "O comentário não pode estar vazio")]
    [StringLength(500, MinimumLength = 1, ErrorMessage = "O comentário deve ter entre 1 e 500 caracteres")]
    public string Content { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [ForeignKey("PostId")]
    public Post Post { get; set; } = null!;

    [ForeignKey("UserId")]
    public User User { get; set; } = null!;
}