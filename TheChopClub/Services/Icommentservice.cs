using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Interface para gestão de comentários
/// </summary>
public interface ICommentService
{
    /// <summary>
    /// Adiciona um comentário a um post
    /// </summary>
    Task<(bool Success, string Message, Comment? Comment)> AddCommentAsync(int postId, int userId, string content);

    /// <summary>
    /// Obtém comentários de um post
    /// </summary>
    Task<List<Comment>> GetCommentsByPostIdAsync(int postId);

    /// <summary>
    /// Elimina um comentário
    /// </summary>
    Task<(bool Success, string Message)> DeleteCommentAsync(int commentId, int userId);

    /// <summary>
    /// Obtém contagem de comentários de um post
    /// </summary>
    Task<int> GetCommentsCountAsync(int postId);
}