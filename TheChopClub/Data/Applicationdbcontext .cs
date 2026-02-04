using Microsoft.EntityFrameworkCore;

namespace TheChopClub.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Barbershop> Barbershops { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<Barbershop>()
            .HasOne(b => b.User)
            .WithOne(u => u.Barbershop)
            .HasForeignKey<Barbershop>(b => b.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Post>()
            .HasOne(p => p.Barbershop)
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BarbershopId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Barbershop)
            .WithMany(b => b.Products)
            .HasForeignKey(p => p.BarbershopId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reviews)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Barbershop)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.BarbershopId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comment>()
            .HasOne(c => c.Post)
            .WithMany(p => p.Comments)
            .HasForeignKey(c => c.PostId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comment>()
            .HasOne(c => c.User)
            .WithMany()
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        var now = DateTime.UtcNow;

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "admin", Email = "admin@chopclub.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin123!"), UserType = UserType.Client, CreatedAt = now.AddMonths(-6), Bio = "Administrador da plataforma", Location = "Porto, Portugal" },
            new User { Id = 2, Username = "joao_barber", Email = "joao@classiccuts.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Barber123!"), UserType = UserType.Barber, CreatedAt = now.AddMonths(-5), Bio = "Barbeiro profissional há 15 anos", Location = "Porto, Portugal" },
            new User { Id = 3, Username = "ricardo_silva", Email = "ricardo@mastercuts.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Barber123!"), UserType = UserType.Barber, CreatedAt = now.AddMonths(-4), Bio = "Mestre barbeiro. Campeão nacional 2023", Location = "Lisboa, Portugal" },
            new User { Id = 4, Username = "carlos_styles", Email = "carlos@urbanbarbershop.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Barber123!"), UserType = UserType.Barber, CreatedAt = now.AddMonths(-3), Bio = "Especialista em fades e designs", Location = "Braga, Portugal" },
            new User { Id = 5, Username = "miguel_premium", Email = "miguel@thebarberlounge.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Barber123!"), UserType = UserType.Barber, CreatedAt = now.AddMonths(-2), Bio = "Barba e cabelo com técnicas tradicionais", Location = "Coimbra, Portugal" },
            new User { Id = 6, Username = "andre_cuts", Email = "andre@sharpcuts.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Barber123!"), UserType = UserType.Barber, CreatedAt = now.AddMonths(-1), Bio = "Cortes modernos e clássicos", Location = "Aveiro, Portugal" },
            new User { Id = 7, Username = "pedro_cliente", Email = "pedro@email.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Cliente123!"), UserType = UserType.Client, CreatedAt = now.AddMonths(-2), Bio = "Apaixonado por bons cortes", Location = "Porto, Portugal" },
            new User { Id = 8, Username = "tiago_sousa", Email = "tiago@email.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Cliente123!"), UserType = UserType.Client, CreatedAt = now.AddMonths(-1), Bio = "Cliente regular", Location = "Lisboa, Portugal" }
        );

        modelBuilder.Entity<Barbershop>().HasData(
            new Barbershop { Id = 1, UserId = 2, Name = "Classic Cuts Porto", Description = "Barbearia tradicional no coração do Porto", Address = "Rua de Santa Catarina, 123", City = "Porto", Phone = "+351 222 123 456", Rating = 4.8M, TotalReviews = 127, IsPremium = true, CreatedAt = now.AddMonths(-5) },
            new Barbershop { Id = 2, UserId = 3, Name = "Master Cuts Lisboa", Description = "Cortes de excelência na capital", Address = "Av. da Liberdade, 456", City = "Lisboa", Phone = "+351 211 234 567", Rating = 4.9M, TotalReviews = 203, IsPremium = true, CreatedAt = now.AddMonths(-4) },
            new Barbershop { Id = 3, UserId = 4, Name = "Urban Barbershop", Description = "Estilo urbano e moderno", Address = "Praça da República, 789", City = "Braga", Phone = "+351 253 345 678", Rating = 4.7M, TotalReviews = 89, IsPremium = false, CreatedAt = now.AddMonths(-3) },
            new Barbershop { Id = 4, UserId = 5, Name = "The Barber Lounge", Description = "Experiência de barbeiro de luxo", Address = "Rua da Sofia, 321", City = "Coimbra", Phone = "+351 239 456 789", Rating = 4.6M, TotalReviews = 64, IsPremium = true, CreatedAt = now.AddMonths(-2) },
            new Barbershop { Id = 5, UserId = 6, Name = "Sharp Cuts", Description = "Cortes precisos e estilo impecável", Address = "Rua João Mendonça, 654", City = "Aveiro", Phone = "+351 234 567 890", Rating = 4.5M, TotalReviews = 45, IsPremium = false, CreatedAt = now.AddMonths(-1) }
        );

        modelBuilder.Entity<Post>().HasData(
            new Post { Id = 1, BarbershopId = 1, Title = "Fade Clássico com Barba Alinhada", Description = "Trabalho de hoje! Fade suave com degradê perfeito", ImageUrl = "https://images.unsplash.com/photo-1621605815971-fbc98d665033?w=800", CreatedAt = now.AddDays(-1), Likes = 145, Views = 890 },
            new Post { Id = 2, BarbershopId = 1, Title = "Corte Executivo Premium", Description = "Para o cliente que valoriza elegância", ImageUrl = "https://images.unsplash.com/photo-1622286342621-4bd786c2447c?w=800", CreatedAt = now.AddDays(-3), Likes = 98, Views = 654 },
            new Post { Id = 3, BarbershopId = 1, Title = "Transformação Completa", Description = "Antes e depois impressionante!", ImageUrl = "https://images.unsplash.com/photo-1605497788044-5a32c7078486?w=800", CreatedAt = now.AddDays(-5), Likes = 203, Views = 1245 },
            new Post { Id = 4, BarbershopId = 2, Title = "Fade Diamante - Técnica Avançada", Description = "Trabalho premiado! Precisão milimétrica", ImageUrl = "https://images.unsplash.com/photo-1503951914875-452162b0f3f1?w=800", CreatedAt = now.AddDays(-2), Likes = 287, Views = 1567 },
            new Post { Id = 5, BarbershopId = 2, Title = "Barba Esculpida - Arte Pura", Description = "Técnica tradicional com toques modernos", ImageUrl = "https://images.unsplash.com/photo-1621607512214-68297480165e?w=800", CreatedAt = now.AddDays(-4), Likes = 176, Views = 987 },
            new Post { Id = 6, BarbershopId = 3, Title = "Design Capilar Personalizado", Description = "Arte e estilo em cada detalhe", ImageUrl = "https://images.unsplash.com/photo-1599351431202-1e0f0137899a?w=800", CreatedAt = now.AddDays(-1), Likes = 134, Views = 756 },
            new Post { Id = 7, BarbershopId = 3, Title = "Low Fade + Design Lateral", Description = "Estilo urbano que marca presença", ImageUrl = "https://images.unsplash.com/photo-1620331311520-246422fd82f9?w=800", CreatedAt = now.AddDays(-6), Likes = 89, Views = 543 },
            new Post { Id = 8, BarbershopId = 4, Title = "Experiência Premium Completa", Description = "Corte + Barba + Tratamento facial", ImageUrl = "https://images.unsplash.com/photo-1621274790572-7c32596bc67f?w=800", CreatedAt = now.AddHours(-12), Likes = 167, Views = 923 },
            new Post { Id = 9, BarbershopId = 4, Title = "Corte Clássico Refinado", Description = "Elegância atemporal", ImageUrl = "https://images.unsplash.com/photo-1622286342621-4bd786c2447c?w=800", CreatedAt = now.AddDays(-7), Likes = 112, Views = 687 },
            new Post { Id = 10, BarbershopId = 5, Title = "Mid Fade Texturizado", Description = "Corte moderno e versátil", ImageUrl = "https://images.unsplash.com/photo-1599351431613-75d5c1f95541?w=800", CreatedAt = now.AddDays(-2), Likes = 78, Views = 456 },
            new Post { Id = 11, BarbershopId = 5, Title = "Degradê Perfeito", Description = "Suavidade e precisão", ImageUrl = "https://images.unsplash.com/photo-1621605815971-fbc98d665033?w=800", CreatedAt = now.AddDays(-8), Likes = 92, Views = 534 },
            new Post { Id = 12, BarbershopId = 2, Title = "Curso de Barbering - Próxima Turma", Description = "Aprenda com os melhores!", ImageUrl = "https://images.unsplash.com/photo-1585747860715-2ba37e788b70?w=800", CreatedAt = now.AddDays(-3), Likes = 234, Views = 1890 },
            new Post { Id = 13, BarbershopId = 1, Title = "Cliente VIP - Tratamento Especial", Description = "Atendimento exclusivo", ImageUrl = "https://images.unsplash.com/photo-1493256338651-d82f7acb2b38?w=800", CreatedAt = now.AddHours(-6), Likes = 156, Views = 876 },
            new Post { Id = 14, BarbershopId = 3, Title = "Promo Weekend - 20% OFF", Description = "Fim de semana com desconto!", ImageUrl = "https://images.unsplash.com/photo-1621607512214-68297480165e?w=800", CreatedAt = now.AddHours(-18), Likes = 267, Views = 1456 },
            new Post { Id = 15, BarbershopId = 4, Title = "Produto do Mês - Pomada Premium", Description = "A melhor pomada para o teu estilo", ImageUrl = "https://images.unsplash.com/photo-1605497788044-5a32c7078486?w=800", CreatedAt = now.AddDays(-4), Likes = 98, Views = 678 }
        );

        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, UserId = 7, BarbershopId = 1, Rating = 5, Comment = "Excelente profissional! Corte impecável!", CreatedAt = now.AddDays(-10) },
            new Review { Id = 2, UserId = 8, BarbershopId = 1, Rating = 5, Comment = "Melhor barbeiro do Porto!", CreatedAt = now.AddDays(-15) },
            new Review { Id = 3, UserId = 1, BarbershopId = 1, Rating = 4, Comment = "Muito bom serviço!", CreatedAt = now.AddDays(-20) },
            new Review { Id = 4, UserId = 7, BarbershopId = 2, Rating = 5, Comment = "Campeão nacional não é à toa!", CreatedAt = now.AddDays(-12) },
            new Review { Id = 5, UserId = 8, BarbershopId = 2, Rating = 5, Comment = "Perfeição absoluta!", CreatedAt = now.AddDays(-18) },
            new Review { Id = 6, UserId = 1, BarbershopId = 3, Rating = 5, Comment = "Designs capilares incríveis!", CreatedAt = now.AddDays(-8) },
            new Review { Id = 7, UserId = 7, BarbershopId = 3, Rating = 4, Comment = "Muito bom! Ambiente descontraído!", CreatedAt = now.AddDays(-14) },
            new Review { Id = 8, UserId = 8, BarbershopId = 4, Rating = 5, Comment = "Experiência premium verdadeira!", CreatedAt = now.AddDays(-6) },
            new Review { Id = 9, UserId = 1, BarbershopId = 4, Rating = 4, Comment = "Ambiente relaxante!", CreatedAt = now.AddDays(-16) },
            new Review { Id = 10, UserId = 7, BarbershopId = 5, Rating = 5, Comment = "Rapidez e qualidade!", CreatedAt = now.AddDays(-5) },
            new Review { Id = 11, UserId = 8, BarbershopId = 5, Rating = 4, Comment = "Bom custo-benefício!", CreatedAt = now.AddDays(-11) }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, BarbershopId = 1, Name = "Pomada Matte Premium", Description = "Fixação forte, acabamento mate", Price = 18.90M, ImageUrl = "https://images.unsplash.com/photo-1621607512214-68297480165e?w=400", Stock = 25, IsActive = true, CreatedAt = now.AddMonths(-2) },
            new Product { Id = 2, BarbershopId = 1, Name = "Óleo para Barba Excellence", Description = "Hidratação profunda e brilho natural", Price = 22.50M, ImageUrl = "https://images.unsplash.com/photo-1585747860715-2ba37e788b70?w=400", Stock = 18, IsActive = true, CreatedAt = now.AddMonths(-2) },
            new Product { Id = 3, BarbershopId = 2, Name = "Kit Barba Completo Pro", Description = "Óleo + Bálsamo + Pente", Price = 45.00M, ImageUrl = "https://images.unsplash.com/photo-1493256338651-d82f7acb2b38?w=400", Stock = 12, IsActive = true, CreatedAt = now.AddMonths(-1) },
            new Product { Id = 4, BarbershopId = 2, Name = "Cera Modeladora High Shine", Description = "Brilho intenso e fixação duradora", Price = 16.90M, ImageUrl = "https://images.unsplash.com/photo-1599351431202-1e0f0137899a?w=400", Stock = 30, IsActive = true, CreatedAt = now.AddMonths(-1) },
            new Product { Id = 5, BarbershopId = 3, Name = "Spray Texturizador Urban", Description = "Volume e textura instantâneos", Price = 19.90M, ImageUrl = "https://images.unsplash.com/photo-1605497788044-5a32c7078486?w=400", Stock = 20, IsActive = true, CreatedAt = now.AddDays(-45) }
        );

        modelBuilder.Entity<Comment>().HasData(
            new Comment { Id = 1, PostId = 1, UserId = 7, Content = "Trabalho incrível! Ficou perfeito!", CreatedAt = now.AddHours(-10) },
            new Comment { Id = 2, PostId = 1, UserId = 8, Content = "Esse degradê está top demais!", CreatedAt = now.AddHours(-8) },
            new Comment { Id = 3, PostId = 1, UserId = 1, Content = "Qualidade impecável como sempre!", CreatedAt = now.AddHours(-5) },
            new Comment { Id = 4, PostId = 4, UserId = 7, Content = "É por isso que és campeão!", CreatedAt = now.AddHours(-15) },
            new Comment { Id = 5, PostId = 4, UserId = 8, Content = "Já marquei horário!", CreatedAt = now.AddHours(-12) },
            new Comment { Id = 6, PostId = 6, UserId = 1, Content = "Criatividade no ponto!", CreatedAt = now.AddHours(-6) },
            new Comment { Id = 7, PostId = 6, UserId = 7, Content = "Quero fazer um igual!", CreatedAt = now.AddHours(-4) },
            new Comment { Id = 8, PostId = 8, UserId = 8, Content = "Vale cada cêntimo!", CreatedAt = now.AddHours(-3) },
            new Comment { Id = 9, PostId = 12, UserId = 7, Content = "Como faço para me inscrever?", CreatedAt = now.AddHours(-20) },
            new Comment { Id = 10, PostId = 12, UserId = 8, Content = "Preço do workshop?", CreatedAt = now.AddHours(-18) },
            new Comment { Id = 11, PostId = 14, UserId = 1, Content = "Já marquei para sábado!", CreatedAt = now.AddHours(-2) },
            new Comment { Id = 12, PostId = 14, UserId = 7, Content = "Promoção top!", CreatedAt = now.AddHours(-1) }
        );
    }
}