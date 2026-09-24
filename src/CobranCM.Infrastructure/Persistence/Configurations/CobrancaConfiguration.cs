using CobranCM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CobranCM.Infrastructure.Persistence.Configurations;

public class CobrancaConfiguration : IEntityTypeConfiguration<Cobranca>
{
    public void Configure(EntityTypeBuilder<Cobranca> builder)
    {
        builder.ToTable("Cobrancas");

        builder.HasKey(cobranca => cobranca.IDCobranca);

        builder.Property(cobranca => cobranca.ValorOriginal)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(cobranca => cobranca.ValorPago)
            .HasPrecision(18, 2);

        builder.Property(cobranca => cobranca.Desconto)
            .HasPrecision(18, 2);

        builder.Property(cobranca => cobranca.JurosMulta)
            .HasPrecision(18, 2);

        builder.Property(cobranca => cobranca.DataEmissao)
            .IsRequired();

        builder.Property(cobranca => cobranca.DataVencimento)
            .IsRequired();

        builder.HasOne<Cliente>()
            .WithMany()
            .HasForeignKey(cobranca => cobranca.IDCliente)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
