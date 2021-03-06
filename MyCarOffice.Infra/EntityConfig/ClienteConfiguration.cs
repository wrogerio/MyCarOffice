using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        // Id
        builder.HasKey(x => x.Id);

        // Nome
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(Constants.ClienteNomeMaxLength);

        // CPF
        builder.Property(x => x.Cpf)
            .IsRequired()
            .HasMaxLength(Constants.ClienteCpfMaxLength);

        // DataNasc
        builder.Property(x => x.DataNasc)
            .IsRequired();

        // Email
        builder.Property(x => x.Email)
            .HasMaxLength(Constants.ClienteEmailMaxLength);

        // Sexo
        builder.Property(x => x.Sexo)
            .IsRequired()
            .HasMaxLength(Constants.ClienteSexoMaxLength);

        // Logradouro
        builder.Property(x => x.Logradouro)
            .IsRequired()
            .HasMaxLength(Constants.ClienteLogradouroMaxLength);

        // Número
        builder.Property(x => x.Numero)
            .HasMaxLength(Constants.ClienteNumeroMaxLength);

        // Telefone
        builder.Property(x => x.Telefone)
            .IsRequired()
            .HasMaxLength(Constants.ClienteTelefoneMaxLength);

        // Complemento
        builder.Property(x => x.Complemento)
            .HasMaxLength(Constants.ClienteComplementoMaxLength);

        // Bairro
        builder.Property(x => x.Bairro)
            .HasMaxLength(Constants.ClienteBairroMaxLength);

        // Cep
        builder.Property(x => x.Cep)
            .HasMaxLength(Constants.ClienteCepMaxLength);

        // CreatedAt
        builder.Property(x => x.CreatedAt).HasDefaultValueSql(Constants.DatetimeDefault);

        // Relacionamento
        builder
            .HasMany(x => x.Veiculos)
            .WithOne(x => x.Cliente)
            .HasForeignKey(x => x.ClienteId);
    }
}