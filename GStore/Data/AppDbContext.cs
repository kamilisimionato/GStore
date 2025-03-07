using GStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GStore.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoFoto> ProdutoFotos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                base.OnModelCreating(builder);
                AppDbSeed seed = new(builder);

                #region Definindo nomes do Identity
                builder.Entity<IdentityUser>().ToTable("usuario");
                builder.Entity<IdentityRole>().ToTable("perfil");
                builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
                builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regra");
                builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
                builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");
                builder.Entity<IdentityRoleClaim<string>>().ToTable("usuario_regra");
                #endregion
        }
}



