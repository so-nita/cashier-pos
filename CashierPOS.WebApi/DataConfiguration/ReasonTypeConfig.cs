using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class ReasonTypeConfig : IEntityTypeConfiguration<ReasonType>
    {
        public void Configure(EntityTypeBuilder<ReasonType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

            /* builder.Property(e => e.Code).IsRequired()
                                     .HasColumnType("varchar")
                                     .HasMaxLength(36);*/

            builder.Property(x => x.Reason_Type).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(20);

            builder.Property(x => x.Name).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(100);

            builder.Property(e => e.Status).IsRequired()
                                    .HasColumnType("int")
                                    .HasConversion<int>();

            builder.Property(e => e.Create_At).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.Is_Deleted).IsRequired().HasColumnType("bit");
        }
    }
}
