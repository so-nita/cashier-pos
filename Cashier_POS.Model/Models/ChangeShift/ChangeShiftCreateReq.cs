using CashierPOS.Model.Interface;

namespace CashierPOS.WebApi.Models.RequestModel.ChangeShift
{
    public class ChangeShiftCreateReq : ICreateReq
    {
        public int UserLogId { get; set; }
        public decimal Start_Balance { get; set; }
        public decimal? Start_Balance_Kh { get; set; }
        //public int? Pos_Id { get; set; } 
    }
}
