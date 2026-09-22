using CobranCM.Domain.Entities;
using CobranCM.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CobranCM.Infrastructure.Persistence.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");

        builder.HasKey(cliente => cliente.IDCliente);

        builder.Property(cliente => cliente.Nome)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(cliente => cliente.Email)
            .HasConversion(
                email => email.Valor,
                valor => new EnderecoEmail(valor))
            .HasMaxLength(254)
            .IsRequired();

        builder.Property(cliente => cliente.Documento)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(cliente => cliente.Telefone)
            .HasMaxLength(20)
            .IsRequired();
    }
}
