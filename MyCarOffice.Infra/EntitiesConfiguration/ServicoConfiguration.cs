using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntitiesConfiguration
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            // Id
            builder.HasKey(x => x.Id);

            // Area
            builder.Property(x => x.Area)
                .IsRequired();

            // Nome
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(Constants.ServicoNomeMaxLength);

            // Valor
            builder.Property(x => x.Valor)
                .IsRequired()
                .HasPrecision(18, 2);

            // Tempo médio
            builder.Property(x => x.TempoMedio)
                .IsRequired();
        }
    }
}
