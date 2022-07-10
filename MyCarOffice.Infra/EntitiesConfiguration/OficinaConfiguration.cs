using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntitiesConfiguration
{
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
            builder.Property(x => x.CNPJ)
                .IsRequired()
                .HasMaxLength(Constants.OficinaCnpjMaxLength);

            // Nome Responsável
            builder.Property(x => x.NomeResponsavel)
                .IsRequired()
                .HasMaxLength(Constants.OficinaNomeResponsavelMaxLength);

            // Telefone
            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasMaxLength(Constants.OficinaTelefoneMaxLength);

            // Logradouro
            builder.Property(x => x.Logradouro)
                .IsRequired()
                .HasMaxLength(Constants.EnderecoLogradouroMaxLength);

            // Número
            builder.Property(x => x.Numero)
                .IsRequired()
                .HasMaxLength(Constants.EnderecoNumeroMaxLength);
        }
    }
}
