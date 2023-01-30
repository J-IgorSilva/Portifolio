using Microsoft.EntityFrameworkCore;
using MiniApiCatalogo.Models;

namespace MiniApiCatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base (options)
        {
        }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //instancia da entidade categoria na proprieda Nome com valor maximo de 100caract sera obrigatoria
            modelBuilder.Entity<Categoria>().HasKey(propriedade=>propriedade.CategoriaId);
            modelBuilder.Entity<Categoria>().Property(propriedade=>propriedade.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Categoria>().Property(proprieddade=>proprieddade.Descricao).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Produto>().HasKey(propriedade => propriedade.ProdutoId);
            modelBuilder.Entity<Produto>().Property(propriedade => propriedade.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Produto>().Property(propriedade => propriedade.Descricao).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Produto>().Property(propriedade => propriedade.ImgUrl).HasMaxLength(100);
            modelBuilder.Entity<Produto>().Property(propriede => propriede.Preco).HasPrecision(14, 2);

            modelBuilder.Entity<Produto>().HasOne<Categoria>(propriedade=>propriedade.Categorias)
                .WithMany(propriedade=>propriedade.Produtos).HasForeignKey(c => c.CategoriaId);

        }
    }
}
