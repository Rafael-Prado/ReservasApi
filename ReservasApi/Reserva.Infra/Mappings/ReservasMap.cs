using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Infra.Mappings
{
    public class ReservasMap : IEntityTypeConfiguration<Reservas>
    {

        void IEntityTypeConfiguration<Reservas>.Configure(EntityTypeBuilder<Reservas> builder)
        {
            builder.HasKey(k => k.ReservaId);

            builder.Property(p => p.DataInicio)
                .IsRequired();
            builder.Property(p => p.HoraInicio)
               .IsRequired();
            builder.Property(p => p.DataFim)
               .IsRequired();
            builder.Property(p => p.HoraFim)
               .IsRequired();
            builder.Property(p => p.Café)
               .IsRequired();
            builder.Property(p => p.QuantidadePessoa)
               .IsRequired();

            builder.Property(p => p.SalaId)
              .IsRequired();
        }
    }
}
