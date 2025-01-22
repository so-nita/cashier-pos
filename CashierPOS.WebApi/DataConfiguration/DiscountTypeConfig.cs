using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class DiscountTypeConfig : IEntityTypeConfiguration<DiscountType>
    {
        public void Configure(EntityTypeBuilder<DiscountType> builder)
        {
            builder.HasKey(e => e.Id);
            //builder.HasIndex(e => e.Code).IsUnique();

            builder.Property(e => e.Id).IsRequired()
                           .HasColumnType("varchar")
                           .HasMaxLength(36);

            /*builder.Property(e => e.Code)
                           .HasColumnType("int")
                           .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/

            builder.Property(e => e.Name).IsRequired()
                           .HasColumnType("varchar")
                           .HasMaxLength(100);

            builder.Property(e => e.DiscountPercent).IsRequired()
                          .HasColumnType("decimal");

            builder.Property(e => e.StartAt)
                           .IsRequired()
                           .HasColumnType("datetime");

            builder.Property(e => e.EndAt)
                           .IsRequired(false)
                           .HasColumnType("datetime");

            builder.Property(e => e.Description)
                           .IsRequired(false)
                           .HasColumnType("varchar")
                           .HasMaxLength(255);

            builder.Property(e => e.CreateAt)
                           .IsRequired()
                           .HasColumnType("datetime");

            builder.Property(e => e.Status)
                           .IsRequired()
                           .HasColumnType("int")
                           .HasConversion<int>();

            builder.Property(e => e.IsDeleted)
                           .IsRequired()
                           .HasColumnType("bit");
        }
    }
}
