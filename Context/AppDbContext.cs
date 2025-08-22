using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class AppDbContext : DbContext
{

  public AppDbContext(DbContextOptions options) : base(options)
  {

  }  

    public DbSet<Models.Categoria>? Categorias { get; set; }
    public DbSet<Models.Produto>? Produtos { get; set; }
}
