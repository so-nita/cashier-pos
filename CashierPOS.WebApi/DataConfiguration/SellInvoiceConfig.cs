using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class SellInvoiceConfig : IEntityTypeConfiguration<SellInvoice>
    {
        public void Configure(EntityTypeBuilder<SellInvoice> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.InvoiceNo);

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.InvoiceNo).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);

            builder.Property(e => e.OrderId).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            /*builder.Property(e => e.Pos_Id).IsRequired()
                                        .HasColumnType("int");*/

            builder.Property(e => e.ShiftId).IsRequired()
                                        .HasColumnType("int");

            builder.Property(e => e.OrderReturnId).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.OldInvoiceNo).IsRequired(false)
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);

            builder.Property(e => e.PrintDate).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.IsPaid).IsRequired(false).HasColumnType("bit");

            builder.Property(e => e.IsDeleted).IsRequired(false).HasColumnType("bit");

            builder.Property(e => e.Status).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            //
            builder.HasOne(e => e.Order)
               .WithMany(e => e.SellInvoices)
               .HasForeignKey(x => x.OrderId)
               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
