# ✂️ The Chop Club/ Final Project

Platform that connects professional barbers with clients in an authentic community.

## 🚀 TECH STACK

- **ASP.NET Core 10** - Main Framework
- **Razor Pages** - Web Interface
- **Entity Framework Core** - ORM
- **SQLite** - Database
- **Bootstrap 5.3** - Responsive Design
- **BCrypt** - Password Encryption
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

Open:  `https://localhost:5001`

## 🔐 Test Credentials

### Admin/Client
- **Email:** `admin@chopclub.com`
- **Password:** `Admin123!`

### Barber
- **Email:** `joao@classiccuts.com`
- **Password:** `Barber123!`

### Other Users
- `ricardo@mastercuts.com` / `Barber123!` (Barber - Lisbon)
- `carlos@urbanbarbershop.com` / `Barber123!` (Barber - Braga)
- `pedro@email.com` / `Cliente123!` (Client
## ✨ Features

### Implemented (Phase 1)
- ✅ Complete authentication system (Client/Barber)
- ✅ Feed with 15 work posts
- ✅ Functional comment system
- ✅ Barber shop rankings by rating
- ✅ Premium design with a unique palette (red/gold/black)
- ✅ Responsive interface (mobile-first)
- ✅ 5 pre-configured barber shops
- ✅ 8 test users
- ✅ 12 example comments
  
## 📁 Project structure

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

## 📊DATABASE

### Schema
- **Users** - Users (Clients and Barbers)
- **Barbershops** - Barbershops (1:1 with User type Barber)
- **Posts** - Posts in the feed
- **Comments** - Comments on posts
- **Reviews** - Barbershop reviews
- **Products** - Products for sale

### Seed Data
- 8 users (1 admin, 5 barbers, 2 clients)
- 5 complete barbershops
- 15 posts with images from Unsplash
- 12 distributed comments
- 11 reviews (ratings 4-5 stars)
- 5 example products
  
#🔒 Security

- **BCrypt** for password hashing
- **Input validation** in all forms
- **SQL Injection Protection** via EF Core
- **Session-based authentication**
- **HTTPS** required in production


