using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(e => e.Id);
            //builder.HasIndex(e => e.Code).IsUnique();

            builder.Property(e => e.Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

           /* builder.Property(e => e.Code).HasColumnType("int")
                                    .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/

            builder.Property(e => e.Name).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(100);

            builder.Property(e => e.Currency).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(50);

            builder.Property(e => e.Logo).IsRequired(false)
                                    .HasColumnType("nvarchar")
                                    .HasMaxLength(500);

            builder.Property(e => e.Create_At).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            builder.Property(e => e.Is_Deleted).IsRequired().HasColumnType("bit");
        }
    }
}
