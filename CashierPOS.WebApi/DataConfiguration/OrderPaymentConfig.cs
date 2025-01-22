using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class OrderPaymentConfig : IEntityTypeConfiguration<OrderPayment>
    {
        public void Configure(EntityTypeBuilder<OrderPayment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Code).IsUnique();

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Code)
                   .HasColumnType("int")
                   .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
                   

            builder.Property(e => e.Order_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.Reference).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.Discount).IsRequired(false)
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.DiscountName).IsRequired(false)
                                                .HasColumnType("varchar").HasMaxLength(50);

            builder.Property(e => e.Total).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Total_Kh).IsRequired()
                                                .HasColumnType("decimal(12,0)");

            builder.Property(e => e.Received).IsRequired(false)
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.ReceivedKh).IsRequired(false)
                                                .HasColumnType("decimal(12,0)");

            builder.Property(e => e.Remaining).IsRequired(false)
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.RemainingKh).IsRequired(false)
                                                .HasColumnType("decimal(12,0)");

            builder.Property(e => e.Change).IsRequired(false)
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.ChangeKh).IsRequired(false)
                                                .HasColumnType("decimal(12,0)");

            builder.Property(e => e.Exchange_Rate).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Transaction_Date).IsRequired()
                                                .HasColumnType("datetime");

            builder.Property(e => e.PaymentTypeId).IsRequired()
                                               .HasColumnType("varchar")
                                               .HasMaxLength(36);

            /* builder.Property(e => e.PaymentMethod_Code).IsRequired(false)
                                                .HasColumnType("int");*/
            builder.Property(e => e.PaymentMethodId).IsRequired()
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.PaymentTypeName).IsRequired()
                                               .HasColumnType("varchar")
                                               .HasMaxLength(36);

            builder.Property(e => e.PaymentCode).IsRequired()
                                               .HasColumnType("varchar")
                                               .HasMaxLength(36);

            builder.Property(e => e.SourceId).IsRequired()
                                              .HasColumnType("varchar")
                                              .HasMaxLength(36);

            builder.Property(e => e.CustomerTypeId).IsRequired()
                                              .HasColumnType("varchar")
                                              .HasMaxLength(36);

            builder.Property(e => e.CustomerCode).IsRequired(false)
                                              .HasColumnType("varchar")
                                              .HasMaxLength(36);

            builder.Property(e => e.Status).IsRequired()
                                    .HasColumnType("int")
                                    .HasConversion<int>();

            //builder.Property(e => e.IsPaid).IsRequired().HasColumnType("bit");

            builder.HasOne(e => e.Order)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.Order_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.Reference)
                   .OnDelete(DeleteBehavior.NoAction);

            /*builder.HasOne(e => e.PaymentMethod)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.PaymentId)
                   .OnDelete(DeleteBehavior.NoAction);*/

            builder.HasOne(e => e.PaymentType)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.PaymentTypeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Source)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.SourceId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.CustomerType)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.CustomerTypeId)
                   .OnDelete(DeleteBehavior.NoAction);

            /*builder.HasOne(e => e.CustomerType)
                   .WithMany(e => e.OrderPayments)
                   .HasForeignKey(x => x.CustomerCode)
                   .OnDelete(DeleteBehavior.NoAction);*/
        }
    }
}
