using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.Repository.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Cpf)
                .IsRequired()
                .HasColumnType("varchar(11)"); 
            
            builder.Property(prop => prop.Email)
                .HasColumnType("varchar(100)");
        }
    }
}
