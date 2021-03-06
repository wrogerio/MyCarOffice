using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

public class OrdemDeServicoConfiguration : IEntityTypeConfiguration<OrdemDeServico>
{
    public void Configure(EntityTypeBuilder<OrdemDeServico> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.OficinaNomeFantasia)
            .IsRequired()
            .HasMaxLength(Constants.OficinaNomeFantasiaMaxLength);

        builder.Property(x => x.OficinaCnpj)
            .IsRequired()
            .HasMaxLength(Constants.OficinaCnpjMaxLength);

        builder.Property(x => x.OficinaNomeResponsavel)
            .IsRequired()
            .HasMaxLength(Constants.OficinaNomeResponsavelMaxLength);

        builder.Property(x => x.OficinaTelefone)
            .IsRequired()
            .HasMaxLength(Constants.OficinaTelefoneMaxLength);

        builder.Property(x => x.OficinaEmail)
            .HasMaxLength(Constants.OficinaEmailMaxLength);

        builder.Property(x => x.OficinaSite)
            .HasMaxLength(Constants.OficinaSiteMaxLength);

        builder.Property(x => x.OficinaLogradouro)
            .IsRequired()
            .HasMaxLength(Constants.OficinaLogradouroMaxLength);

        builder.Property(x => x.OficinaNumero)
            .HasMaxLength(Constants.OficinaNumeroMaxLength);

        builder.Property(x => x.OficinaComplemento)
            .HasMaxLength(Constants.OficinaComplementoMaxLength);

        builder.Property(x => x.OficinaBairro)
            .HasMaxLength(Constants.OficinaBairroMaxLength);

        builder.Property(x => x.OficinaCep)
            .HasMaxLength(Constants.OficinaCepMaxLength);

        builder.Property(x => x.ProfissionalNome)
            .IsRequired()
            .HasMaxLength(Constants.ProfissionalNomeMaxLength);

        builder.Property(x => x.ProfissionalCpf)
            .IsRequired()
            .HasMaxLength(Constants.ProfissionalCpfMaxLength);

        builder.Property(x => x.ProfissionalDataNasc)
            .IsRequired();

        builder.Property(x => x.ProfissionalArea)
            .IsRequired();

        builder.Property(x => x.ClienteNome)
            .IsRequired()
            .HasMaxLength(Constants.ClienteNomeMaxLength);

        builder.Property(x => x.ClienteCpf)
            .IsRequired()
            .HasMaxLength(Constants.ClienteCpfMaxLength);

        builder.Property(x => x.ClienteDataNasc)
            .IsRequired();

        builder.Property(x => x.ClienteEmail)
            .HasMaxLength(Constants.ClienteEmailMaxLength);

        builder.Property(x => x.ClienteTelefone)
            .IsRequired()
            .HasMaxLength(Constants.ClienteTelefoneMaxLength);

        builder.Property(x => x.ClienteSexo)
            .IsRequired()
            .HasMaxLength(Constants.ClienteSexoMaxLength);

        builder.Property(x => x.ClienteLogradouro)
            .IsRequired()
            .HasMaxLength(Constants.ClienteLogradouroMaxLength);

        builder.Property(x => x.ClienteNumero)
            .HasMaxLength(Constants.ClienteNumeroMaxLength);

        builder.Property(x => x.ClienteComplemento)
            .HasMaxLength(Constants.ClienteComplementoMaxLength);

        builder.Property(x => x.ClienteBairro)
            .HasMaxLength(Constants.ClienteBairroMaxLength);

        builder.Property(x => x.ClienteCep)
            .HasMaxLength(Constants.ClienteCepMaxLength);

        builder.Property(x => x.VeiculoMarca)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoMarcaMaxLength);

        builder.Property(x => x.VeiculoModelo)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoModeloMaxLength);

        builder.Property(x => x.VeiculoPlaca)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoPlacaMaxLength);

        builder.Property(x => x.VeiculoAno)
            .IsRequired();

        builder.Property(x => x.VeiculoCor)
            .HasMaxLength(Constants.VeiculoCorMaxLength);

        builder.Property(x => x.VeiculoObservacao)
            .HasMaxLength(Constants.VeiculoObservacaoMaxLength);

        builder.Property(x => x.ServicoArea)
            .IsRequired();

        builder.Property(x => x.ServicoNome)
            .IsRequired()
            .HasMaxLength(Constants.ServicoNomeMaxLength);

        builder.Property(x => x.ServicoValor)
            .IsRequired();

        builder.Property(x => x.ServicoTempoMedio)
            .IsRequired();

        builder.Property(x => x.Concluida)
            .HasDefaultValue(false);

        // CreatedAt
        builder.Property(x => x.CreatedAt).HasDefaultValueSql(Constants.DatetimeDefault);
    }
}