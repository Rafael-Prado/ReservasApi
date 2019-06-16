using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Entities;

namespace Reserva.Infra.Mappings
{
    public class FilialMap : IEntityTypeConfiguration<Filial>
    {
        void IEntityTypeConfiguration<Filial>.Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasKey(k => k.FilialId);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.QuantidadeSala);
            

        }
    }
}
