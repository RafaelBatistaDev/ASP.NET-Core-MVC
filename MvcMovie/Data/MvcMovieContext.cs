using Microsoft.EntityFrameworkCore;
using MvcMovie.Models; // <-- ESSA É A LINHA QUE VAI MATAR O ERRO CS0246

namespace MvcMovie.Data;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; } = default!;
}