using CobranCM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CobranCM.Infrastructure.Persistence.Configurations;

public class ParcelaConfiguration : IEntityTypeConfiguration<Parcela>
{
    public void Configure(EntityTypeBuilder<Parcela> builder)
    {
        builder.ToTable("Parcelas");

        builder.HasKey(parcela => parcela.IDParcela);

        builder.Property(parcela => parcela.ValorOriginal)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(parcela => parcela.ValorPago)
            .HasPrecision(18, 2);

        builder.Property(parcela => parcela.Status)
            .IsRequired();
    }
}
