using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ChangeShiftDetailConfig : IEntityTypeConfiguration<ChangeShiftDetail>
    {
        public void Configure(EntityTypeBuilder<ChangeShiftDetail> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

            /*builder.Property(e => e.ChangeShift_Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);*/

            builder.Property(e => e.ChangeShift_Id).IsRequired()
                                   .HasColumnType("int");
                                   
            builder.Property(e => e.PaymentMethod_Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

            builder.Property(e => e.Create_At).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.Amount).IsRequired()
                                        .HasColumnType("decimal(10,2)");

            //
            builder.HasOne(e => e.ChangShift)
               .WithMany(e => e.ChangeShiftDetails)
               .HasForeignKey(x => x.ChangeShift_Id)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.PaymentMethod)
                   .WithMany(e => e.ChangeShiftDetails)
                   .HasForeignKey(x => x.PaymentMethod_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
