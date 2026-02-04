using Microsoft.EntityFrameworkCore;
using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Serviço para gestão de comentários
/// </summary>
public class CommentService : ICommentService
{
    private readonly ApplicationDbContext _context;

    public CommentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<(bool Success, string Message, Comment? Comment)> AddCommentAsync(int postId, int userId, string content)
    {
        try
        {
            // Validações
            if (string.IsNullOrWhiteSpace(content))
                return (false, "O comentário não pode estar vazio", null);

            if (content.Length > 500)
                return (false, "O comentário é demasiado longo (máximo 500 caracteres)", null);

            // Verificar se o post existe
            var post = await _context.Posts.FindAsync(postId);
            if (post == null)
                return (false, "Post não encontrado", null);

            // Verificar se o utilizador existe
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
                return (false, "Utilizador não encontrado", null);

            // Criar comentário
            var comment = new Comment
            {
                PostId = postId,
                UserId = userId,
                Content = content.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            // Carregar dados do utilizador para retornar
            await _context.Entry(comment).Reference(c => c.User).LoadAsync();

            return (true, "Comentário adicionado com sucesso!", comment);
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao adicionar comentário: {ex.Message}", null);
        }
    }

    public async Task<List<Comment>> GetCommentsByPostIdAsync(int postId)
    {
        return await _context.Comments
            .Include(c => c.User)
            .Where(c => c.PostId == postId)
            .OrderByDescending(c => c.CreatedAt)
            .ToListAsync();
    }

    public async Task<(bool Success, string Message)> DeleteCommentAsync(int commentId, int userId)
    {
        try
        {
            var comment = await _context.Comments.FindAsync(commentId);

            if (comment == null)
                return (false, "Comentário não encontrado");

            // Verificar se o utilizador é o dono do comentário
            if (comment.UserId != userId)
                return (false, "Não tem permissão para eliminar este comentário");

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return (true, "Comentário eliminado com sucesso!");
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao eliminar comentário: {ex.Message}");
        }
    }

    public async Task<int> GetCommentsCountAsync(int postId)
    {
        return await _context.Comments.CountAsync(c => c.PostId == postId);
    }
}