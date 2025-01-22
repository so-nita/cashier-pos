using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.RequestModel.ChangeShift
{
    public class ChangeShiftResponse : IResponse
    {
        public int Id { get; set; }  
        public int UserLogId { get; set; }  
        public DateTime Start_Shift { get; set; }
        public DateTime? End_Shift { get; set; }
        public decimal Start_Balance { get; set; }
        public decimal Start_Balance_Kh { get; set; }
        public decimal? End_Balance { get; set; }
        public decimal? Total_Sale { get; set; } = 0;
        public decimal? Total_Discount { get; set; } = 0;
        public decimal? Total_Tax { get; set; } = 0;
        public decimal? Net_Sale { get; set; } = 0;
        public string Change_Shift_By { get; set; } = string.Empty;
        public string Change_Shift_Name { get; set; } = string.Empty;
        public string Company_Id { get; set; } = string.Empty;
        public string Company_Name { get; set; } = string.Empty;
        public DateTime? Print_Date { get; set; }
        public string Shift_Status { get; set; } = "";
    }
}
