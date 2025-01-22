using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class ExchangeRateConfig : IEntityTypeConfiguration<ExchangeRate>
    { 
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired()
                                       .HasColumnType("varchar")
                                       .HasMaxLength(36);

            builder.Property(x => x.Value).IsRequired()
                                          .HasColumnType("decimal(8,2)");

            builder.Property(x => x.Last_Updated).IsRequired(false)
                                        .HasColumnType("datetime");

            builder.Property(e => e.Create_At).IsRequired()
                                        .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                       .HasColumnType("int")
                                       .HasConversion<int>();

            builder.Property(e => e.Is_Deleted).IsRequired()
                                       .HasColumnType("bit");
        }
    }
}
