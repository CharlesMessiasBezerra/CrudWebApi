using Microsoft.EntityFrameworkCore;
using Usuario.Domain.CidadeContext;
using Usuario.Domain.EstadoContext;
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
        public virtual DbSet<CidadeDB> CidadeDB { get; set; }

        public virtual DbSet<EstadoDB> EstadoDB { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}

