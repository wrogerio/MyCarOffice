using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntitiesConfiguration
{
    public class ProfissionalConfiguration : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            // Id
            builder.HasKey(x => x.Id);

            // Nome
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(Constants.ProfissionalNomeMaxLength);

            // CPF
            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(Constants.ProfissionalCpfMaxLength);

            // DataNasc
            builder.Property(x => x.DataNasc)
                .IsRequired();

            // Área
            builder.Property(x => x.Area)
                .IsRequired();
        }
    }
}
