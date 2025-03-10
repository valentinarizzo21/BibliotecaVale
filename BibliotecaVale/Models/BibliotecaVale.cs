using Microsoft.EntityFrameworkCore;

public class BibliotecaValeContext : DbContext
{
    public BibliotecaValeContext(DbContextOptions<BibliotecaValeContext> options) : base(options) { }

    public DbSet<Libro> Libri { get; set; }
    public DbSet<Prestito> Prestiti { get; set; }
}
