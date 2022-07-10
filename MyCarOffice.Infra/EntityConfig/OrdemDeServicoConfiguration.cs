using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

public class OrdemDeServicoConfiguration : IEntityTypeConfiguration<OrdemDeServico>
{
    public void Configure(EntityTypeBuilder<OrdemDeServico> builder)
    {
        // Id
        builder.HasKey(x => x.Id);

        // DataHoraInicio
        builder.Property(x => x.DataHoraInicio)
            .IsRequired();

        // Cliente Nome
        builder.Property(x => x.ClienteNome)
            .IsRequired()
            .HasMaxLength(Constants.ClienteNomeMaxLength);

        // Cliente CPF
        builder.Property(x => x.ClienteCPF)
            .IsRequired()
            .HasMaxLength(Constants.ClienteCpfMaxLength);

        // Cliente Email
        builder.Property(x => x.ClienteEmail)
            .IsRequired()
            .HasMaxLength(Constants.ClienteEmailMaxLength);

        // Cliente Telefone
        builder.Property(x => x.ClienteTelefone)
            .IsRequired()
            .HasMaxLength(Constants.TelefoneMaxLength);

        // Veiculo Marca
        builder.Property(x => x.VeiculoMarca)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoMarcaMaxLength);

        // Veiculo Modelo
        builder.Property(x => x.VeiculoModelo)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoModeloMaxLength);

        // Veiculo Placa
        builder.Property(x => x.VeiculoPlaca)
            .IsRequired()
            .HasMaxLength(Constants.VeiculoPlacaMaxLength);

        // Veiculo Ano
        builder.Property(x => x.VeiculoAno)
            .IsRequired();

        // Servico Area
        builder.Property(x => x.ServicoArea)
            .IsRequired();

        // Serviço Nome
        builder.Property(x => x.ServicoNome)
            .IsRequired()
            .HasMaxLength(Constants.ServicoNomeMaxLength);

        // Serviço Valor
        builder.Property(x => x.ServicoValor)
            .IsRequired()
            .HasPrecision(18, 2);

        // Profissional Nome
        builder.Property(x => x.ProfissionalNome)
            .IsRequired()
            .HasMaxLength(Constants.ProfissionalNomeMaxLength);

        // Profissional CPF
        builder.Property(x => x.ProfissionalCPF)
            .IsRequired()
            .HasMaxLength(Constants.ProfissionalCpfMaxLength);

        // Oficina Nome Fantasia
        builder.Property(x => x.OficinaNomeFantasia)
            .IsRequired()
            .HasMaxLength(Constants.OficinaNomeFantasiaMaxLength);

        // Oficina CPNJ
        builder.Property(x => x.OficinaCNPJ)
            .IsRequired()
            .HasMaxLength(Constants.OficinaCnpjMaxLength);

        // Oficina Telefone
        builder.Property(x => x.OficinaFone)
            .IsRequired()
            .HasMaxLength(Constants.TelefoneMaxLength);

        // Oficina Nome Responsável
        builder.Property(x => x.OficinaNomeResponsavel)
            .IsRequired()
            .HasMaxLength(Constants.OficinaNomeResponsavelMaxLength);
    }
}