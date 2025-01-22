using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Product_Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Order_Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Product_Code).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            /*builder.Property(e => e.Product_Name).IsRequired()
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
                                        .HasColumnType("decimal(8,4)");

            builder.Property(e => e.Discount_Amount).IsRequired(false)
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Total_Discount).IsRequired(false)
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Grand_Amount).IsRequired()
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Create_At).IsRequired()
                                        .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                                .HasColumnType("varchar(30)")
                                                .HasConversion<string>();

            builder.Property(e => e.ReasonId).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.TaxType).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            builder.Property(e => e.TaxAmount).IsRequired()
                                        .HasColumnType("decimal(10,4)");

            builder.Property(e => e.SynData_At).IsRequired(false)
                                        .HasColumnType("datetime");
            //
            builder.HasOne(e=>e.Order)
                   .WithMany(e=>e.OrderDetails)
                   .HasForeignKey(x => x.Order_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Product)
                   .WithMany(e => e.OrderDetails)
                   .HasForeignKey(x => x.Product_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
