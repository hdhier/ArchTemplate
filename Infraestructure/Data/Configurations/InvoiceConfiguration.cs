using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            // Configuración de la clave primaria
            builder.HasKey(i => i.Id);

            // Configuración de las propiedades
            builder.Property(i => i.Id)
                .IsRequired()
                .HasColumnType("uniqueidentifier"); // Tipo de dato

            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar(100)"); // Tipo de dato

            builder.Property(i => i.CreationDate)
                .IsRequired()
                .HasColumnType("datetime2"); // Tipo de dato

            builder.Property(i => i.CustomerId)
                .IsRequired()
                .HasColumnType("uniqueidentifier"); // Tipo de dato

            // Configuración de la relación con Customer
            builder.HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerId);

            // Nombre de la tabla
            builder.ToTable("INVOICES");
        }
    }
}
