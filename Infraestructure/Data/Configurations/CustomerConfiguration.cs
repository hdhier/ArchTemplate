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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Configuración de la clave primaria
            builder.HasKey(c => c.Id);

            // Configuración de las propiedades
            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100); // Ejemplo de longitud máxima

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50); // Ejemplo de longitud máxima

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50); // Ejemplo de longitud máxima

            // Configuración de la relación con Invoices
            // Esto es para una relacion de uno a muchos donde un customer tiene muchas invoices y una invoice solo pertenece a un customer
            builder.HasMany(c => c.Invoices)
                .WithOne(i => i.Customer)
                .HasForeignKey(i => i.CustomerId);

            // Nombre de la tabla
            builder.ToTable("CUSTOMERS");
        }
    }
}
