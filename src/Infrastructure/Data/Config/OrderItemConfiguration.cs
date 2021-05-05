using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.Property(x => x.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
        }
    }
}
