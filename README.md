<div align="center">

# ✂️ The Chop Club

**A plataforma que conecta barbeiros profissionais com clientes numa comunidade autêntica.**

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-Razor_Pages-512BD4?style=flat)](https://dotnet.microsoft.com/apps/aspnet)
[![Entity Framework](https://img.shields.io/badge/EF_Core-ORM-512BD4?style=flat)](https://learn.microsoft.com/ef/core/)
[![SQLite](https://img.shields.io/badge/SQLite-Database-003B57?style=flat&logo=sqlite)](https://www.sqlite.org/)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=flat&logo=bootstrap)](https://getbootstrap.com/)

</div>

---

## 📋 Índice

- [Sobre o Projeto](#-sobre-o-projeto)
- [Tecnologias](#️-tecnologias)
- [Instalação](#-instalação)
- [Credenciais de Teste](#-credenciais-de-teste)
- [Funcionalidades](#-funcionalidades)
- [Design System](#-design-system)
- [Base de Dados](#-base-de-dados)
- [Estrutura do Projeto](#-estrutura-do-projeto)
- [Segurança](#-segurança)
- [Desenvolvimento](#️-desenvolvimento)
- [Roadmap](#-roadmap)

---

## 🎯 Sobre o Projeto

O **The Chop Club** é uma plataforma web que liga barbeiros profissionais a clientes através de um feed de trabalhos, sistema de avaliações, rankings e (brevemente) marcação de horários — tudo numa experiência com identidade visual própria.

---

## 🛠️ Tecnologias

| Tecnologia | Função |
|---|---|
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
- Editor: Visual Studio Code, Visual Studio 2022, ou JetBrains Rider
- Git

---

### 🪟 Windows (

# 1. Clonar o repositório
git clone https://github.com/FranciscoMonteiro23/TheChopClub.git

# 2. Entrar na pasta do projeto
cd TheChopClub

# 3. Restaurar dependências
dotnet restore

# 4. Aplicar migrações da base de dados
dotnet ef database update

# 5. Executar a aplicação
dotnet run
```

---

### 🍎 macOS (Terminal)

`
# 1. Confirmar que tem o .NET 10 SDK instalado
dotnet --version
# Se não tiver, instale com: brew install --cask dotnet-sdk
# ou descarregue em https://dotnet.microsoft.com/download

# 2. Clonar o repositório
git clone https://github.com/FranciscoMonteiro23/TheChopClub.git

# 3. Entrar na pasta do projeto
cd TheChopClub

# 4. Restaurar dependências
dotnet restore

# 5. Confiar no certificado de desenvolvimento HTTPS (só é preciso na primeira vez)
dotnet dev-certs https --trust

# 6. Instalar as ferramentas do Entity Framework (só é preciso na primeira vez)
dotnet tool install --global dotnet-ef

# 7. Aplicar migrações da base de dados
dotnet ef database update

# 8. Executar a aplicação
dotnet run
```


### ✅ Confirmar que está a funcionar

Depois de `dotnet run`, o terminal mostra algo como:

```
Now listening on: https://localhost:5001
Now listening on: http://localhost:5000
```

Abrir no browser: **`https://localhost:5001`**

> ⚠️ Se a porta estiver ocupada (erro `AddressBinder.BindAsync` ou "address already in use"), feche outras instâncias do projeto a correr, ou altere a porta em `Properties/launchSettings.json`.

---

## 🔐 Credenciais de Teste

| Perfil | Email | Password |
|---|---|---|
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
|---|---|---|
| Barber Red | `#D32F2F` | Destaque principal |
| Barber Dark | `#0D0D0D` | Background escuro |
| Barber Gold | `#D4AF37` | Acentos premium |
| Barber Cream | `#F5F1E8` | Background claro |

### Tipografia

| Estilo | Fonte | Uso |
|---|---|---|
| Display | *Bebas Neue* | Títulos impactantes |
| Elegant | *Playfair Display* | Subtítulos sofisticados |
| Body | *Montserrat* | Texto corrido |

---

## 📊 Base de Dados

### Schema

| Tabela | Descrição |
|---|---|
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

-

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
```

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

```bash
# Apagar a base de dados existente
rm thechopclub.db      # macOS/Linux
del thechopclub.db     # Windows

# As migrações recriam-na automaticamente
dotnet ef database update
```

### Criar uma nova migração

```bash
dotnet ef migrations add NomeDaMigracao
dotnet ef database update
```

---

<div align="center">

Desenvolvido por **Francisco Monteiro**

</div>
