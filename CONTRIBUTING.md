# 🤝 Guia de Contribuição

Obrigado por se interessar em contribuir! 🚀

---

## Código de Conduta

Este projeto segue um Código de Conduta respeitoso. Valorizamos inclusão e profissionalismo.

---

## Como Começar

### Tipos de Contribuições

- 🐛 **Bug Reports** — Encontrou um erro?
- ✨ **Feature Requests** — Tem uma ideia?
- 📖 **Documentação** — Melhorias em README
- 🧪 **Testes** — Testes automatizados
- 🎨 **UI/UX** — Melhorias visuais
- 🔧 **Refatoração** — Limpeza de código

---

## Reportando Bugs

Use este template:

```markdown
## 🐛 Descrição

[Explicar o problema]

## 📋 Como Reproduzir

1. Faça isto...
2. Depois aquilo...

## 📸 Ambiente

- .NET Version: [dotnet --version]
- Sistema: [Windows/macOS/Linux]
```

---

## Sugerindo Features

```markdown
## ✨ Descrição

[Explicar a feature]

## 💡 Motivação

Por que seria útil?

## 📝 Implementação

[Sua sugestão]
```

---

## Como Fazer Pull Request

### 1. Fork & Clone

```bash
git clone https://github.com/SEU-USUARIO/ASP.NET-Core-Web-App-MVC.git
cd ASP.NET-Core-Web-App-MVC
```

### 2. Crie uma Branch

```bash
git checkout -b feature/descricao-curta
```

### 3. Faça Suas Mudanças

```bash
dotnet build
dotnet watch run
```

### 4. Commit com Mensagens Claras

```bash
git commit -m "feat: adiciona nova funcionalidade"
```

### 5. Push e Abra um PR

```bash
git push origin feature/descricao-curta
```

---

## Padrões de Código

### C# Conventions

```csharp
// ✅ Classes públicas em PascalCase
public class MovieController : Controller { }

// ✅ Propriedades em PascalCase
public List<Movie> Movies { get; set; }

// ✅ Métodos async com CancellationToken
public async Task<IActionResult> IndexAsync()
{
    var movies = await _context.Movies.ToListAsync();
    return View(movies);
}

// ✅ Validação com Data Annotations
[Required(ErrorMessage = "Título é obrigatório")]
[StringLength(100)]
public string Title { get; set; }
```

---

## Dúvidas?

- 📖 Veja [DEVELOPMENT.md](DEVELOPMENT.md)
- 💬 Abra uma [Discussion](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-App-MVC/discussions)

---

**Obrigado por contribuir!** 🙏
