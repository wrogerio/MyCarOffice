using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

public class OficinaConfiguration : IEntityTypeConfiguration<Oficina>
{
    public void Configure(EntityTypeBuilder<Oficina> builder)
    {
        // Id
        builder.HasKey(x => x.Id);

        // Nome Fantasia
        builder.Property(x => x.NomeFantasia)
            .IsRequired()
            .HasMaxLength(Constants.OficinaNomeFantasiaMaxLength);

        // CNPJ
        builder.Property(x => x.Cnpj)
            .IsRequired()
            .HasMaxLength(Constants.OficinaCnpjMaxLength);

        // Nome Responsável
        builder.Property(x => x.NomeResponsavel)
            .IsRequired()
            .HasMaxLength(Constants.OficinaNomeResponsavelMaxLength);

        // Email
        builder.Property(x => x.Email)
            .HasMaxLength(Constants.OficinaEmailMaxLength);

        // Site
        builder.Property(x => x.Site)
            .HasMaxLength(Constants.OficinaSiteMaxLength);

        // Telefone
        builder.Property(x => x.Telefone)
            .IsRequired()
            .HasMaxLength(Constants.OficinaTelefoneMaxLength);

        // Logradouro
        builder.Property(x => x.Logradouro)
            .IsRequired()
            .HasMaxLength(Constants.OficinaLogradouroMaxLength);

        // Número
        builder.Property(x => x.Numero)
            .HasMaxLength(Constants.OficinaNumeroMaxLength);

        // Complemento
        builder.Property(x => x.Complemento)
            .HasMaxLength(Constants.OficinaComplementoMaxLength);

        // Bairro
        builder.Property(x => x.Bairro)
            .HasMaxLength(Constants.OficinaBairroMaxLength);

        // Cep
        builder.Property(x => x.Cep)
            .HasMaxLength(Constants.OficinaCepMaxLength);

        // CreatedAt
        builder.Property(x => x.CreatedAt).HasDefaultValueSql(Constants.DatetimeDefault);
    }
}