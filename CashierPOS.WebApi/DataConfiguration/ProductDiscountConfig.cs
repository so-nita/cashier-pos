using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class ProductDiscountConfig : IEntityTypeConfiguration<ProductDiscount>
    {
        public void Configure(EntityTypeBuilder<ProductDiscount> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e=>e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);

            builder.Property(e => e.ProductId).IsRequired().HasColumnType("varchar").HasMaxLength(36);

            builder.Property(e => e.DiscountId).IsRequired().HasColumnType("varchar").HasMaxLength(36);

            builder.Property(e => e.StartDate).IsRequired().HasColumnType("datetime");

            builder.Property(e => e.EndDate).IsRequired().HasColumnType("datetime");

            builder.Property(e => e.Description).IsRequired(false).HasColumnType("varchar").HasMaxLength(36);

            builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                    .HasColumnType("int")
                                    .HasConversion<int>();

            builder.Property(e => e.IsDeleted).IsRequired().HasColumnType("bit");

            builder.HasOne(e => e.Product)
                   .WithMany(e => e.ProductDiscounts)
                   .HasForeignKey(x => x.ProductId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.DiscountType)
                   .WithMany(e => e.ProductDiscounts)
                   .HasForeignKey(x => x.DiscountId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
