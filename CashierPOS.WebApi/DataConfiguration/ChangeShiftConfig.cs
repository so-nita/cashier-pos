using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class ChangeShiftConfig : IEntityTypeConfiguration<ChangeShift>
    {
        public void Configure(EntityTypeBuilder<ChangeShift> builder)
        {
            builder.HasKey(e=>e.Id);

            /*builder.Property(e => e.Id)
                 .HasColumnType("int")
                 .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            /*builder.Property(e => e.Id).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);

            builder.Property(e => e.Pos_Id).IsRequired()
                                   .HasColumnType("int");*/

            builder.Property(e => e.UserLogId).IsRequired()
                                   .HasColumnType("int");

            builder.Property(e => e.Start_Shift).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.End_Shift).IsRequired(false)
                                    .HasColumnType("datetime");

            builder.Property(e => e.Start_Balance).IsRequired()
                                        .HasColumnType("decimal(8,4)");

            builder.Property(e => e.Start_Balance_Kh).IsRequired()
                                        .HasColumnType("decimal(12,2)");

            builder.Property(e => e.End_Balance).IsRequired(false)
                                        .HasColumnType("decimal(12,4)");

            builder.Property(e => e.Total_Sale).IsRequired(false)
                                    .HasColumnType("decimal(12,4)");

            builder.Property(e => e.Total_Discount).IsRequired(false)
                                        .HasColumnType("decimal(8,4)");

            builder.Property(e => e.Total_Tax).IsRequired(false)
                                        .HasColumnType("decimal(8,4)");

            builder.Property(e => e.Total_Changed).IsRequired(false)
                                        .HasColumnType("decimal(8,4)");

            builder.Property(e => e.Net_Sale).IsRequired(false)
                                        .HasColumnType("decimal(12,4)");

           /* builder.Property(e => e.ActionLog_Id).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);*/

            builder.Property(e => e.Change_Shift_By).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);

            builder.Property(e => e.Company_Id).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);

            builder.Property(e => e.Company_Name).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(100);

            builder.Property(e => e.Print_Date).IsRequired(false)
                                    .HasColumnType("datetime");

            builder.Property(e => e.Shift_Status).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36)
                                    .HasConversion<string>();
            //
            builder.HasOne(e => e.UserLog)
               .WithMany(e => e.ChangShifts)
               .HasForeignKey(x => x.UserLogId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.ChangShifts)
                   .HasForeignKey(x => x.Change_Shift_By)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Company)
                   .WithMany(e => e.ChangShifts)
                   .HasForeignKey(x => x.Company_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
