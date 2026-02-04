# ✂️ The Chop Club

Plataforma que conecta barbeiros profissionais com clientes numa comunidade autêntica.

## 🚀 Tecnologias

- **ASP.NET Core 10** - Framework principal
- **Razor Pages** - Interface web
- **Entity Framework Core** - ORM
- **SQLite** - Base de dados
- **Bootstrap 5.3** - Design responsivo
- **BCrypt** - Encriptação de passwords

## 📦 Instalação

### Requisitos
- .NET 10 SDK
- Visual Studio Code ou Visual Studio 2022

### Passos

```bash
# Clonar repositório
git clone https://github.com/FranciscoMonteiro23/TheChopClub.git

# Entrar na pasta
cd TheChopClub

# Restaurar dependências
dotnet restore

# Executar aplicação
dotnet run
```

Abrir no browser: `https://localhost:5001`

## 🔐 Credenciais de Teste

### Admin/Cliente
- **Email:** `admin@chopclub.com`
- **Password:** `Admin123!`

### Barbeiro
- **Email:** `joao@classiccuts.com`
- **Password:** `Barber123!`

### Outros Utilizadores
- `ricardo@mastercuts.com` / `Barber123!` (Barbeiro - Lisboa)
- `carlos@urbanbarbershop.com` / `Barber123!` (Barbeiro - Braga)
- `pedro@email.com` / `Cliente123!` (Cliente)

## ✨ Funcionalidades

### Implementadas (Fase 1)
- ✅ Sistema de autenticação completo (Cliente/Barbeiro)
- ✅ Feed com 15 posts de trabalhos
- ✅ Sistema de comentários funcional
- ✅ Rankings de barbearias por rating
- ✅ Design premium com paleta única (vermelho/dourado/preto)
- ✅ Interface responsiva (mobile-first)
- ✅ 5 barbearias pré-configuradas
- ✅ 8 utilizadores de teste
- ✅ 12 comentários de exemplo

### Próximas Fases
- 🔜 Upload de imagens real
- 🔜 Dashboard de barbeiro com analytics
- 🔜 Sistema de avaliações detalhado
- 🔜 Marcação de horários
- 🔜 Loja virtual de produtos
- 🔜 Chat entre utilizadores

## 📁 Estrutura do Projeto

```
TheChopClub/
├── Models/                 # Modelos de dados
│   ├── User.cs
│   ├── Barbershop.cs
│   ├── Post.cs
│   ├── Comment.cs
│   ├── Review.cs
│   ├── Product.cs
│   └── ApplicationDbContext.cs
├── Services/               # Lógica de negócio
│   ├── AuthService.cs
│   ├── ProfileService.cs
│   ├── PostService.cs
│   └── CommentService.cs
├── Pages/                  # Páginas Razor
│   ├── Index.cshtml
│   ├── Login.cshtml
│   ├── Register.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/                # Assets estáticos
│   ├── css/
│   │   └── site.css        # 700+ linhas de CSS custom
│   └── js/
│       └── site.js
├── Program.cs              # Configuração da app
└── appsettings.json        # Configurações
```

## 🎨 Design System

### Paleta de Cores
- **Barber Red:** `#D32F2F` - Destaque principal
- **Barber Dark:** `#0D0D0D` - Background escuro
- **Barber Gold:** `#D4AF37` - Acentos premium
- **Barber Cream:** `#F5F1E8` - Background claro

### Tipografia
- **Display:** Bebas Neue - Títulos impactantes
- **Elegant:** Playfair Display - Subtítulos sofisticados
- **Body:** Montserrat - Texto legível

## 📊 Base de Dados

### Schema
- **Users** - Utilizadores (Clientes e Barbeiros)
- **Barbershops** - Barbearias (1:1 com User tipo Barber)
- **Posts** - Publicações no feed
- **Comments** - Comentários nos posts
- **Reviews** - Avaliações das barbearias
- **Products** - Produtos para venda

### Seed Data
- 8 utilizadores (1 admin, 5 barbeiros, 2 clientes)
- 5 barbearias completas
- 15 posts com imagens do Unsplash
- 12 comentários distribuídos
- 11 reviews (ratings 4-5 estrelas)
- 5 produtos de exemplo

## 🔒 Segurança

- **BCrypt** para hash de passwords
- **Validação de input** em todos os formulários
- **SQL Injection Protection** via EF Core
- **Session-based authentication**
- **HTTPS** obrigatório em produção

## 📸 Screenshots

(Adicionar screenshots do projeto aqui)

## 🛠️ Desenvolvimento

### Executar em modo desenvolvimento
```bash
dotnet watch run
```

### Limpar e reconstruir
```bash
dotnet clean
dotnet build
```

### Recriar base de dados
```bash
# Apagar BD antiga
del thechopclub.db

# Executar (cria automaticamente)
dotnet run
```

## 👥 Autores

- **Francisco Monteiro** - [FranciscoMonteiro23](https://github.com/FranciscoMonteiro23)
- **[Nome do Colega]** - Contribuidor

## 🎓 Projeto Académico

Desenvolvido para [Nome da Disciplina/Curso]  
[Nome da Instituição]  
Ano Letivo 2024/2025

## 📄 Licença

Este projeto é de uso académico.

## 🙏 Agradecimentos

- Imagens: [Unsplash](https://unsplash.com)
- Ícones: [Font Awesome](https://fontawesome.com)
- Framework: [ASP.NET Core](https://dotnet.microsoft.com)
- CSS Framework: [Bootstrap](https://getbootstrap.com)

---

⭐ Se gostaste do projeto, dá uma estrela no GitHub!

📧 Contacto: [teu@email.com]
