using apiagenciadeviagens.Model;
using Microsoft.EntityFrameworkCore;

namespace apiagenciadeviagens.Database
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options){

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable("usuario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.Idade).HasColumnName("idade").IsRequired();
            usuario.Property(x => x.Email).HasColumnName("email").IsRequired();
            usuario.Property(x => x.Senha).HasColumnName("senha").IsRequired();
        }
    }
}