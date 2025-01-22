using CashierPOS.Model.Interface;

namespace CashierPOS.WebApi.Models.RequestModel.ChangeShift
{
    public class ChangeShiftUpdateReq : IUpdateReq
    {
        public string Id { get; set; } = "";
        public DateTime? End_Shift { get; set; }
        public decimal Start_Balance { get; set; }
        public decimal Start_Balance_Kh { get; set; }
        public decimal? End_Balance { get; set; }
    }
}
