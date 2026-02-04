using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Interface para gestão de publicações (posts)
/// </summary>
public interface IPostService
{
    /// <summary>
    /// Cria uma nova publicação
    /// </summary>
    Task<(bool Success, string Message, Post? Post)> CreatePostAsync(int barbershopId, string title, string? description, string imageUrl);

    /// <summary>
    /// Obtém todas as publicações ordenadas por data
    /// </summary>
    Task<List<Post>> GetAllPostsAsync(int skip = 0, int take = 20);

    /// <summary>
    /// Obtém publicações de uma barbearia específica
    /// </summary>
    Task<List<Post>> GetPostsByBarbershopIdAsync(int barbershopId);

    /// <summary>
    /// Incrementa visualizações de um post
    /// </summary>
    Task IncrementViewsAsync(int postId);

    /// <summary>
    /// Incrementa ou decrementa likes
    /// </summary>
    Task<(bool Success, int NewLikes)> ToggleLikeAsync(int postId);

    /// <summary>
    /// Obtém um post por ID
    /// </summary>
    Task<Post?> GetPostByIdAsync(int postId);

    /// <summary>
    /// Elimina um post
    /// </summary>
    Task<(bool Success, string Message)> DeletePostAsync(int postId, int userId);
}