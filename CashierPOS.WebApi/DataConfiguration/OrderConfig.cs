using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Company_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            /*builder.Property(e => e.SourceId).IsRequired(false)
                                               .HasColumnType("varchar")
                                               .HasMaxLength(36);*/

            /*--builder.Property(e => e.Pos_Id).IsRequired()
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);*/

            builder.Property(e => e.Reference_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.ShiftId).IsRequired()
                                                  .HasColumnType("int");

            builder.Property(e => e.Tax).IsRequired(false).HasColumnType("decimal(8,4)");

            builder.Property(e => e.Total_Discount).IsRequired()
                                                .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Grand_Total).IsRequired().HasColumnType("decimal(10,4)");

            builder.Property(e => e.Sub_Total).IsRequired()
                                                .HasColumnType("decimal(10,4)");

            builder.Property(e => e.Delivery).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.ExchangeRate).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Received).IsRequired(false)
                                               .HasColumnType("decimal(8,2)");

            builder.Property(e => e.ReceivedKh).IsRequired(false)
                                               .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Remaining).IsRequired(false)
                                               .HasColumnType("decimal(8,2)");

            builder.Property(e => e.RemainingKh).IsRequired(false)
                                               .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Change).IsRequired(false)
                                               .HasColumnType("decimal(8,2)");

            builder.Property(e => e.ChangeKh).IsRequired(false)
                                               .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Order_Status).IsRequired()
                                                .HasColumnType("varchar(50)")
                                                .HasConversion<string>();

            builder.Property(e => e.ReasonTypeId).IsRequired(false)
                                               .HasColumnType("varchar(36)");

            builder.Property(e => e.PaymentMethodId).IsRequired(false)
                                               .HasColumnType("varchar(36)");

            builder.Property(e => e.PaymentTypeCode).IsRequired(false)
                                               .HasColumnType("varchar(36)");

            builder.Property(e => e.SellType).IsRequired(false)
                                               .HasColumnType("varchar(36)");

            builder.Property(e => e.CustomerId).IsRequired(false)
                                               .HasColumnType("varchar(36)");

            builder.Property(e => e.DataSource).IsRequired()
                                                .HasColumnType("varchar(36)");

            /*builder.Property(e => e.CustomerTypeCode).IsRequired(false)
                                               .HasColumnType("varchar(36)");*/

            builder.Property(e => e.CustomerType).IsRequired(false)
                                               .HasColumnType("varchar(36)");

            builder.Property(e => e.Order_Date).IsRequired()
                                                .HasColumnType("datetime");

            builder.Property(e => e.Cancelled_At).IsRequired(false)
                                                .HasColumnType("datetime");

            builder.Property(e => e.Is_Deleted).IsRequired().HasColumnType("bit");


            // section
           /* builder.HasOne(e => e.Source)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.SourceId)
                   .OnDelete(DeleteBehavior.NoAction);*/

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.Reference_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ChangeShift)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.ShiftId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
