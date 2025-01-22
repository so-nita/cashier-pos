using CashierPOS.Model.Models.Constant;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ChangeShift
    {
        //public string Id { get; set; } = "";
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  
        public int Pos_Id { get; set; } 
        public int UserLogId { get; set; } 
        public DateTime Start_Shift { get; set; }
        public DateTime? End_Shift { get; set; }
        public decimal Start_Balance { get; set; }
        public decimal Start_Balance_Kh { get; set; }
        public decimal? End_Balance { get; set; }
        public decimal? Total_Sale { get; set; } = 0;
        public decimal? Total_Discount { get; set; } = 0;
        public decimal? Total_Tax { get; set; } = 0;
        public decimal? Total_Changed { get; set; } = 0;
        public decimal? Net_Sale { get; set; } = 0;
        public string Change_Shift_By { get; set; } = string.Empty;
        public string Company_Id { get; set; } = string.Empty;
        public string Company_Name { get; set; } = string.Empty;
        public DateTime? Print_Date { get; set; }
        public ShiftStatus Shift_Status { get; set; }
        // 
        public UserLog UserLog { get; set; } = null!; 
        public Company Company { get; set; } = null!;
        public User User { get; set; } = null!;
        public ICollection<ChangeShiftDetail>? ChangeShiftDetails { get; set; }   
        public ICollection<Order>? Orders { get; set; }
    }
}
