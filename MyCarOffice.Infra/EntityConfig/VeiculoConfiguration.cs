using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
{
    public void Configure(EntityTypeBuilder<Veiculo> builder)
    {
        // Id
        builder.HasKey(x => x.Id);

        // Marca
        builder.Property(x => x.Marca)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoMarcaMaxLength);

        // Modelo
        builder.Property(x => x.Modelo)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoModeloMaxLength);

        // Placa
        builder.Property(x => x.Placa)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoPlacaMaxLength);

        // Ano
        builder.Property(x => x.Ano)
            .IsRequired();
        
        // Cor
        builder.Property(x => x.Cor)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoCorMaxLength);
        
        // Observacao
        builder.Property(x => x.Observacao)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoObservacaoMaxLength);

        // CreatedAt
        builder.Property(x => x.CreatedAt).HasDefaultValueSql(Constants.DatetimeDefault);
    }
}