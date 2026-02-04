using Microsoft.EntityFrameworkCore;
using TheChopClub.Models;

namespace TheChopClub.Services;

/// <summary>
/// Serviço para gestão de publicações no feed
/// </summary>
public class PostService : IPostService
{
    private readonly ApplicationDbContext _context;

    public PostService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<(bool Success, string Message, Post? Post)> CreatePostAsync(
        int barbershopId,
        string title,
        string? description,
        string imageUrl)
    {
        try
        {
            // Validações
            if (string.IsNullOrWhiteSpace(title))
                return (false, "O título é obrigatório", null);

            if (string.IsNullOrWhiteSpace(imageUrl))
                return (false, "É necessário adicionar uma imagem", null);

            var barbershop = await _context.Barbershops.FindAsync(barbershopId);
            if (barbershop == null)
                return (false, "Barbearia não encontrada", null);

            var post = new Post
            {
                BarbershopId = barbershopId,
                Title = title,
                Description = description,
                ImageUrl = imageUrl,
                CreatedAt = DateTime.UtcNow
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return (true, "Publicação criada com sucesso!", post);
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao criar publicação: {ex.Message}", null);
        }
    }

    public async Task<List<Post>> GetAllPostsAsync(int skip = 0, int take = 20)
    {
        return await _context.Posts
            .Include(p => p.Barbershop)
            .ThenInclude(b => b.User)
            .OrderByDescending(p => p.CreatedAt)
            .Skip(skip)
            .Take(take)
            .ToListAsync();
    }

    public async Task<List<Post>> GetPostsByBarbershopIdAsync(int barbershopId)
    {
        return await _context.Posts
            .Include(p => p.Barbershop)
            .Where(p => p.BarbershopId == barbershopId)
            .OrderByDescending(p => p.CreatedAt)
            .ToListAsync();
    }

    public async Task IncrementViewsAsync(int postId)
    {
        try
        {
            var post = await _context.Posts.FindAsync(postId);
            if (post != null)
            {
                post.Views++;
                await _context.SaveChangesAsync();
            }
        }
        catch
        {
            // Silenciar erro - não é crítico
        }
    }

    public async Task<(bool Success, int NewLikes)> ToggleLikeAsync(int postId)
    {
        try
        {
            var post = await _context.Posts.FindAsync(postId);
            if (post == null)
                return (false, 0);

            // Simples toggle - em produção seria necessário controlar quem deu like
            post.Likes++;
            await _context.SaveChangesAsync();

            return (true, post.Likes);
        }
        catch
        {
            return (false, 0);
        }
    }

    public async Task<Post?> GetPostByIdAsync(int postId)
    {
        return await _context.Posts
            .Include(p => p.Barbershop)
            .ThenInclude(b => b.User)
            .FirstOrDefaultAsync(p => p.Id == postId);
    }

    public async Task<(bool Success, string Message)> DeletePostAsync(int postId, int userId)
    {
        try
        {
            var post = await _context.Posts
                .Include(p => p.Barbershop)
                .FirstOrDefaultAsync(p => p.Id == postId);

            if (post == null)
                return (false, "Publicação não encontrada");

            // Verificar se o utilizador é o dono
            if (post.Barbershop.UserId != userId)
                return (false, "Não tem permissão para eliminar esta publicação");

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return (true, "Publicação eliminada com sucesso!");
        }
        catch (Exception ex)
        {
            return (false, $"Erro ao eliminar publicação: {ex.Message}");
        }
    }
}