# 🔨 Guia de Desenvolvimento

Neste documento você encontra tudo o que precisa para configurar e desenvolver este projeto.

---

## 💻 Ambiente Recomendado

### IDE/Editor
- **Visual Studio Code** + C# DevKit
- **Visual Studio 2022** (Community gratuito)
- **JetBrains Rider** (pago)

### Requisitos
- **.NET SDK 8.0+** ([Download](https://dotnet.microsoft.com/download))
- **Git**
- **Browser moderno**

---

## 🚀 Setup Inicial

### 1. Clone o Repositório

```bash
git clone https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC.git
cd ASP.NET-Core-Web-App-MVC
```

### 2. Restaure Dependências

```bash
dotnet restore
```

### 3. Configure Banco de Dados

```bash
# Aplicar migrações
dotnet ef database update

# Verificar banco criado
ls *.db
```

### 4. Verifique Build

```bash
dotnet build
```

---

## ⚡ Desenvolvimento

### Executar em Watch Mode

```bash
# Recompila automaticamente ao salvar
dotnet watch run
```

Acesse: **http://localhost:5000**

### Debug

```bash
# VS Code: Pressione F5
# Visual Studio: Pressione F5
```

---

## 🗄️ Banco de Dados

### Criar Nova Migração

```bash
# Após modificar Models
dotnet ef migrations add NomedaMigracao

# Aplicar
dotnet ef database update
```

### Ver Migrações

```bash
dotnet ef migrations list
```

---

## 🧪 Testes

```bash
# Quando implementar
dotnet test
```

---

## 📦 Publicação

```bash
# Build para produção
dotnet publish -c Release -o ./publish

# Self-contained (sem .NET necessário)
dotnet publish -c Release --self-contained \
  -p:PublishSingleFile=true \
  -p:PublishTrimmed=true \
  -r linux-x64 \
  -o ./publish-standalone
```

---

## 🐧 Desenvolvimento em Fedora

### Setup .NET

```bash
# Fedora Workstation
sudo dnf install dotnet-sdk-8.0

# Fedora Atomic (via rpm-ostree)
sudo rpm-ostree install dotnet-sdk-8.0

# Via Toolbox
toolbox create dotnet-dev
toolbox enter dotnet-dev
sudo dnf install dotnet-sdk-8.0
```

---

## 🔒 Segurança

### User Secrets

```bash
dotnet user-secrets init
dotnet user-secrets set "DbPassword" "senha_local"
```

### HTTPS Local

```bash
dotnet dev-certs https --trust
```

---

## 🐛 Troubleshooting

### Build falha com "CS0103"
```bash
dotnet clean
dotnet restore
dotnet build
```

### Porta 5000 já em uso
```bash
# Mudar em launchSettings.json
"applicationUrl": "http://localhost:5001"
```

### Banco de dados locked
```bash
rm -f *.db
dotnet ef database update
```

---

## ✅ Checklist Antes de Commitar

```bash
☐ dotnet build (sem erros)
☐ dotnet test (se houver)
☐ Código formatado
☐ sem secrets em .json
```

---

## 📚 Referências

- [ASP.NET Core MVC Docs](https://learn.microsoft.com/aspnet/core/mvc)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [C# Documentation](https://learn.microsoft.com/dotnet/csharp/)

---

**Versão:** 1.0.0  
**Data:** 4 de abril de 2026
