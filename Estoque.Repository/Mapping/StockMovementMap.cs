using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.Repository.Mapping
{
    public class StockMovementMap : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> builder)
        {
            builder.ToTable("StockMovement");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Date)
                .IsRequired();

            builder.Property(prop => prop.Type)
                .IsRequired();

            builder.Property(prop => prop.Quantity)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.HasOne(prop => prop.Product)
                .WithMany()
                .HasForeignKey("ProductId");

            builder.HasOne(prop => prop.User)
                .WithMany()
                .HasForeignKey("UserId");

            builder.HasOne(prop => prop.Supplier)
                .WithMany()
                .HasForeignKey("SupplierId")
                .IsRequired(false);

            builder.HasOne(prop => prop.Customer)
                .WithMany()
                .HasForeignKey("CustomerId")
                .IsRequired(false);
        }
    }
}