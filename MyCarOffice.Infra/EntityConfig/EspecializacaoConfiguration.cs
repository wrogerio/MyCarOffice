using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Infra.EntityConfig;

public class EspecializacaoConfiguration : IEntityTypeConfiguration<Especializacao>
{
    public void Configure(EntityTypeBuilder<Especializacao> builder)
    {
        // Id
        builder.HasKey(x => x.Id);

        // Nome
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(Constants.EspecializacaoNomeMaxLength);

        // Since
        builder.Property(x => x.Since)
            .IsRequired();
        
        // CreatedAt
        builder.Property(x => x.CreatedAt).HasDefaultValueSql(Constants.DatetimeDefault);
    }
}