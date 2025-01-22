using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class ReturnOrderConfig : IEntityTypeConfiguration<ReturnOrder>
    {
        public void Configure(EntityTypeBuilder<ReturnOrder> builder)
        {
            builder.HasKey(e=>e.Id);

            builder.Property(e=>e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);

            //--builder.Property(e=>e.Pos_Id).IsRequired().HasColumnType("int");

            builder.Property(e=>e.OrderId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e=>e.InvoiceNo).IsRequired(false).HasColumnType("varchar").HasMaxLength(36);
            //builder.Property(e=>e.ReturnReasonId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e=>e.ReturnReasonCode).IsRequired().HasColumnType("varchar").HasMaxLength(36);

            builder.Property(e => e.ApprovedBy).IsRequired(false).HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.ApprovedByUserName).IsRequired(false).HasColumnType("varchar").HasMaxLength(36);

            builder.Property(e => e.Sub_Total).IsRequired().HasColumnType("decimal(10,4)");
            builder.Property(e => e.Total_Discount).IsRequired(false).HasColumnType("decimal(10,4)");
            builder.Property(e => e.Grand_Total).IsRequired().HasColumnType("decimal(10,4)");

            builder.Property(e => e.ReturnDate).IsRequired().HasColumnType("datetime");

            builder.HasOne(e=>e.User)
                   .WithMany(e=>e.ReturnOrders)
                   .HasForeignKey(e=>e.ApprovedBy)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
