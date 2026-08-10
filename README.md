# ✂️ The Chop Club

**A plataforma que conecta barbeiros profissionais com clientes numa comunidade autêntica.**

## 🎯 Sobre o Projeto

O **The Chop Club** é uma plataforma web que liga barbeiros profissionais a clientes através de um feed de trabalhos, sistema de avaliações, rankings e (brevemente) marcação de horários — tudo numa experiência com identidade visual própria.

---

## 🛠️ Tecnologias

| Tecnologia | Função |
| --- | --- |
| **ASP.NET Core 10** | Framework principal |
| **Razor Pages** | Interface web (MVVM) |
| **Entity Framework Core** | ORM / acesso a dados |
| **SQLite** | Base de dados |
| **Bootstrap 5.3** | Design responsivo |
| **BCrypt** | Encriptação de passwords |

---

## 🚀 Instalação

### Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code ou Visual Studio 2022

### Passos

# 1. Clonar o repositório

git clone <https://github.com/FranciscoMonteiro23/TheChopClub.git>

# 2. Entrar na pasta do projeto

cd TheChopClub

# 3. Restaurar dependências

dotnet restore

# 4. Aplicar migrações da base de dados

dotnet ef database update

# 5. Executar a aplicação

dotnet run

Abrir no browser: **`https://localhost:5001`**

---

## 🔐 Credenciais de Teste

| Perfil | Email | Password |
| --- | --- | --- |
| Admin / Cliente | `admin@chopclub.com` | `Admin123!` |
| Barbeiro (Porto) | `joao@classiccuts.com` | `Barber123!` |
| Barbeiro (Lisboa) | `ricardo@mastercuts.com` | `Barber123!` |
| Barbeiro (Braga) | `carlos@urbanbarbershop.com` | `Barber123!` |
| Cliente | `pedro@email.com` | `Cliente123!` |

---

## ✨ Funcionalidades

### ✅ Implementadas

- Sistema de autenticação completo (Cliente / Barbeiro)
- Feed dinâmico com posts de trabalhos
- Sistema de comentários funcional
- Rankings de barbearias por avaliação
- Design premium com paleta própria (vermelho / dourado / preto)
- Interface responsiva (mobile-first)
- Barbearias, utilizadores e comentários pré-configurados (seed data)

### 🔜 Roadmap

- [ ] Upload de imagens real (Cloudinary / AWS S3)
- [ ] Dashboard de barbeiro com analytics
- [ ] Sistema de avaliações detalhado
- [ ] **Marcação de horários com calendário** *(em desenvolvimento)*
- [ ] Loja virtual de produtos
- [ ] Chat entre utilizadores

---

## 🎨 Design System

### Paleta de Cores

| Nome | Cor | Uso |
| --- | --- | --- |
| Barber Red | `#D32F2F` | Destaque principal |
| Barber Dark | `#0D0D0D` | Background escuro |
| Barber Gold | `#D4AF37` | Acentos premium |
| Barber Cream | `#F5F1E8` | Background claro |

### Tipografia

| Estilo | Fonte | Uso |
| --- | --- | --- |
| Display | *Bebas Neue* | Títulos impactantes |
| Elegant | *Playfair Display* | Subtítulos sofisticados |
| Body | *Montserrat* | Texto corrido |

---

## 📊 Base de Dados

### Schema

| Tabela | Descrição |
| --- | --- |
| `Users` | Utilizadores (Clientes e Barbeiros) |
| `Barbershops` | Barbearias (relação 1:1 com User do tipo Barber) |
| `Posts` | Publicações no feed |
| `Comments` | Comentários nos posts |
| `Reviews` | Avaliações das barbearias |
| `Products` | Produtos para venda |
| `Bookings` | Marcações de horário |

### Seed Data

- 8 utilizadores (1 admin, 5 barbeiros, 2 clientes)
- 5 barbearias completas
- 15 posts com imagens do Unsplash
- 12 comentários distribuídos
- 11 reviews (ratings 4–5 estrelas)
- 5 produtos de exemplo

---

## 📁 Estrutura do Projeto

TheChopClub/
├── Models/                 # Modelos de dados
│   ├── User.cs
│   ├── Barbershop.cs
│   ├── Post.cs
│   ├── Comment.cs
│   ├── Review.cs
│   ├── Product.cs
│   └── Booking.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Services/                # Lógica de negócio
│   ├── AuthService.cs
│   ├── ProfileService.cs
│   ├── PostService.cs
│   ├── CommentService.cs
│   └── BookingService.cs
├── Pages/                   # Páginas Razor
│   ├── Index.cshtml
│   ├── Login.cshtml
│   ├── Register.cshtml
│   ├── Premium.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── Migrations/               # Migrações do Entity Framework
├── wwwroot/                  # Assets estáticos
│   ├── css/
│   │   └── site.css
│   └── js/
│       └── site.js
├── Program.cs                # Configuração da aplicação
└── appsettings.json           # Configurações

---

## 🔒 Segurança

- **BCrypt** para hashing de passwords
- **Validação de inputs** em todos os formulários
- **Proteção contra SQL Injection** via Entity Framework Core
- **Autenticação baseada em sessão**
- **HTTPS** obrigatório em produção

---

## 🛠️ Desenvolvimento

### Executar em modo desenvolvimento (hot reload)

dotnet watch run

### Limpar e reconstruir

dotnet clean
dotnet build

### Recriar a base de dados do zero

# Apagar a base de dados existente

rm thechopclub.db      # macOS/Linux
del thechopclub.db     # Windows

# As migrações recriam-na automaticamente

dotnet ef database update

### Criar uma nova migração

dotnet ef migrations add NomeDaMigracao
dotnet ef database update

```
