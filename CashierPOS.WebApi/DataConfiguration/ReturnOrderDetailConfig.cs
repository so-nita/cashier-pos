using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class ReturnOrderDetailConfig : IEntityTypeConfiguration<ReturnOrderDetail>
    {
        public void Configure(EntityTypeBuilder<ReturnOrderDetail> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.ReturnId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.ProductId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Total).IsRequired().HasColumnType("decimal(8,2)");
            
            builder.Property(e => e.Qty).IsRequired().HasColumnType("int");

            builder.Property(e => e.ProductCode).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            /*builder.Property(e => e.ProductName).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);*/

            /*builder.Property(e => e.Size).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);*/

            builder.Property(e => e.Price).IsRequired()
                                        .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Qty).IsRequired()
                                        .HasColumnType("int");

            builder.Property(e => e.Sub_Amount).IsRequired()
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Discount_Percent).IsRequired(false)
                                        .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Total_Discount).IsRequired(false)
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Discount_Amount).IsRequired(false)
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Reason_Id).IsRequired(false)
                                       .HasColumnType("int");
            // 
            builder.HasOne(e => e.ReturnOrder)
              .WithMany(e => e.Details)
              .HasForeignKey(x => x.ReturnId)
              .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
