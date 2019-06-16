using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Entities;

namespace Reserva.Infra.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        
        void IEntityTypeConfiguration<Usuario>.Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(k => k.UsuarioId);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Email);

            builder.Property(p => p.Senha)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(p => p.User)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.AccessKey)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
