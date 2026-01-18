using Microsoft.EntityFrameworkCore;
using Livraria.Entities;
namespace Livraria.Infrastructure;

public class LivrariaDbContext : DbContext
{
    public LivrariaDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}
