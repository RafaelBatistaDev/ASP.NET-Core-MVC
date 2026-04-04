# 🎬 ASP.NET Core MVC Movie Application

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0%2B-blue)](https://dotnet.microsoft.com)
[![C#](https://img.shields.io/badge/C%23-12-green)](https://docs.microsoft.com/dotnet/csharp)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20MVC-purple)](https://www.asp.net)
[![GitHub](https://img.shields.io/badge/GitHub-Public-black)](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC)
[![Linux](https://img.shields.io/badge/Linux-Fedora-red)](https://getfedora.org)

Aplicação web **profissional** desenvolvida com **ASP.NET Core MVC** e **.NET 8+** em ambiente **Linux (Fedora)**. Gerenciamento completo de filmes com validação, pesquisa e persistência de dados usando Entity Framework Core.

**Licença:** MIT — Open source, use livremente! 📜

---

## 📋 Sobre o Projeto

**ASP.NET Core MVC Movie Application** é um projeto educacional e profissional que demonstra:

✅ **MVC moderno** (Model-View-Controller pattern)  
✅ **Entity Framework Core** com banco de dados SQLite  
✅ **CRUD completo** (Criar, Ler, Atualizar, Deletar)  
✅ **Validação de dados** robusta  
✅ **Pesquisa e filtragem** avançadas  
✅ **C# moderno** (.NET 8+, nullable reference types)  
✅ **Design responsivo** com CSS/Bootstrap  
✅ **Desenvolvido 100% em Linux** (Fedora)  

### Funcionalidades Principais

- 🎞️ **CRUD de Filmes** — Gerenciamento completo com validação
- 🔍 **Busca avançada** — Por título, gênero, ano e preço
- 📋 **Validação de entrada** — Dados seguros e consistentes
- 💾 **Persistência** — SQLite + Entity Framework Core
- 🎨 **Interface responsiva** — Bootstrap 5 integrado
- ⚡ **Performance otimizada** — Lazy loading e caching

---

## 🛠️ Requisitos

- **.NET SDK 8.0** ou superior ([Download](https://dotnet.microsoft.com/download))
- **Git** (para versionamento)
- **Browser moderno** (Chrome, Firefox, Edge)
- **(Opcional) Visual Studio Code** + C# DevKit

**Verificar instalação:**
```bash
dotnet --version
```

---

## ⚡ Quick Start

### 1️⃣ Clone o Repositório
```bash
git clone https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC.git
cd ASP.NET-Core-Web-App-MVC
```

### 2️⃣ Restaure Dependências
```bash
dotnet restore
```

### 3️⃣ Execute em Watch Mode
```bash
dotnet watch run
```

A aplicação estará disponível em: **http://localhost:5000**

---

## 🚀 Como Usar

### Executar em Desenvolvimento
```bash
# Com recarga automática
dotnet watch run

# Modo debug tradicional
dotnet run

# Compilar e executar (Release)
dotnet run -c Release
```

### Criar Banco de Dados
```bash
# Aplicar migrações do EF Core
dotnet ef database update

# Ver migrações disponíveis
dotnet ef migrations list
```

### Acessar a Aplicação
- **URL local:** http://localhost:5000
- **Banco SQLite:** `MvcMovie.db`

---

## 🔧 Configuração

### appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  },
  "ConnectionStrings": {
    "MvcMovieContext": "Data Source=MvcMovie.db"
  }
}
```

---

## 🧪 Testing

### Teste Manual
1. Acesse http://localhost:5000
2. Navegue para "Create New"
3. Preencha os campos obrigatórios
4. Submeta o formulário
5. Verifique se o item aparece na listagem

---

## 🐧 Desenvolvimento em Linux (Fedora)

### Instalação do .NET em Fedora

#### Fedora Imutável (Silverblue/Kinoite)
```bash
# Via rpm-ostree layer
sudo rpm-ostree install dotnet-sdk-8.0

# Ou via Toolbox
toolbox create --distro fedora dotnet-dev
toolbox enter dotnet-dev
sudo dnf install dotnet-sdk-8.0
```

#### Fedora Workstation
```bash
sudo dnf install dotnet-sdk-8.0
```

---

## 🔐 Segurança

### O que Já Está Implementado
✅ Validação de entrada (Data annotations)  
✅ CSRF Token em formulários (automático em MVC)  
✅ Encoding de output (proteção XSS)  
✅ HTTPS em produção  

### Recomendações para Produção
- Use **HTTPS obrigatório**
- Implemente **autenticação** (ASP.NET Identity)
- Configure **rate limiting**
- Adicione **logging e monitoramento**

---

## 📝 Estrutura de Arquivos

```
ASP.NET-Core-Web-App-MVC/
├── MVC.sln                      # Solução Visual Studio
│
├── MvcMovie/                    # Projeto principal
│   ├── MvcMovie.csproj
│   ├── Program.cs               # Entry point e configuração
│   │
│   ├── Controllers/             # Controladores MVC
│   │   └── MoviesController.cs
│   │
│   ├── Models/                  # Modelos de dados
│   │   ├── Movie.cs
│   │   └── ErrorViewModel.cs
│   │
│   ├── Views/                   # Visualizações (razor)
│   │   ├── Movies/
│   │   ├── Home/
│   │   ├── Shared/
│   │   └── _ViewImports.cshtml
│   │
│   ├── Data/                    # Contexto do EF
│   │   └── MvcMovieContext.cs
│   │
│   ├── Properties/
│   │   └── launchSettings.json
│   │
│   ├── wwwroot/                 # Arquivos estáticos
│   │   ├── css/
│   │   ├── js/
│   │   └── lib/                 # Bootstrap, jQuery
│   │
│   ├── appsettings.json
│   └── appsettings.Development.json
│
├── README.md
├── CHANGELOG.md
├── CONTRIBUTING.md
├── DEVELOPMENT.md
├── GITHUB-CONFIG.md
├── LICENSE
└── .gitignore
```

---

## 📚 Referências

### Documentação Oficial
- [ASP.NET Core MVC](https://learn.microsoft.com/aspnet/core/mvc/overview)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [.NET 8 Release Notes](https://github.com/dotnet/core/releases)

### Comunidade
- [Stack Overflow - ASP.NET Core](https://stackoverflow.com/questions/tagged/asp.net-core)
- [GitHub Discussions](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC/discussions)

---

## 🤝 Contribuindo

Contribuições são bem-vindas! Veja [CONTRIBUTING.md](CONTRIBUTING.md) para mais detalhes.

---

## 📞 Suporte

- 🐛 **Bugs:** Abra uma [issue no GitHub](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC/issues)
- 💬 **Discussões:** [GitHub Discussions](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC/discussions)

---

## 📄 Licença

Este projeto está licenciado sob a **MIT License** — veja [LICENSE](LICENSE) para detalhes.

---

**Versão:** 1.0.0  
**Status:** ✅ Production Ready  
**Última atualização:** 4 de abril de 2026  
**Desenvolvido em:** Fedora Linux 
