using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

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
        builder.Property(x => x.Cpf)
            .IsRequired()
            .HasMaxLength(Constants.ProfissionalCpfMaxLength);

        // DataNasc
        builder.Property(x => x.DataNasc)
            .IsRequired();

        // Área
        builder.Property(x => x.Area)
            .IsRequired();

        // Relacionamentos
        builder
            .HasMany(x => x.Especializacoes)
            .WithOne(x => x.Profissional)
            .HasForeignKey(x => x.ProfissionalId);
        
        // CreatedAt
        builder.Property(x => x.CreatedAt).HasDefaultValueSql(Constants.DatetimeDefault);
    }
}