using Microsoft.EntityFrameworkCore;
using Usuario.Domain.UsuarioContext;

namespace Usuario.Infrastructure.Model
{
    public class Banco : DbContext
    {
        public Banco(DbContextOptions<Banco> options)
            : base(options)
        {
        }

        public virtual DbSet<UsuarioDB> UsuarioDB { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}

