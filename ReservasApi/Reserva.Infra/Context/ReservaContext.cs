
using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Entities;
using Reserva.Infra.Mappings;
using Reserva.Shared;

namespace Reserva.Infra.Context
{
    public class ReservaContext: DbContext
    {
       
        public ReservaContext(DbContextOptions<ReservaContext> options)
        : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Filial> Filia { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Sala> Sala { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new FilialMap());
            modelBuilder.ApplyConfiguration(new ReservasMap());
            modelBuilder.ApplyConfiguration(new SalaMap());

        }

    }
}
