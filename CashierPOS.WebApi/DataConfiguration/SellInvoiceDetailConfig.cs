using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class SellInvoiceDetailConfig : IEntityTypeConfiguration<SellInvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<SellInvoiceDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(x => x.InvoiceId).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(x => x.InvoiceNo).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(x => x.Version).IsRequired()
                                        .HasColumnType("int");

           /* builder.Property(x => x.Data).IsRequired()
                                        .HasColumnType("varchar").HasMaxLength();*/

            builder.Property(x => x.PosId).IsRequired()
                                        .HasColumnType("int");

            builder.Property(x => x.ByUserId).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            /*builder.Property(x => x.ApproveBy).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(x => x.ReasonTypeCode).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);*/

            builder.Property(x => x.PrintDate).IsRequired()
                                       .IsRequired()
                                       .HasColumnType("datetime");

            // 
            builder.HasOne(e=>e.Invoice)
                   .WithMany(e=>e.InvoiceDetails)
                   .HasForeignKey(e=>e.InvoiceId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
