using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Infra.Mappings
{
    public class SalaMap : IEntityTypeConfiguration<Sala>
    {

        void IEntityTypeConfiguration<Sala>.Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.HasKey(k => k.SalaId);

            builder.Property(p => p.NomeSala)
                .IsRequired();

            builder.Property(p => p.TipoSala)
                .IsRequired();

            builder.HasOne(h => h.Filial)
                .WithMany(w => w.Salas)
                .HasForeignKey(k => k.FilialId);
        }
    }
}
