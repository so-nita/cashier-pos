namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ChangeShiftDetail
    {
        public string Id { get; set; }  = string.Empty;
        public int ChangeShift_Id { get; set; }  
        public string PaymentMethod_Id { get; set; } = "";
        public Decimal Amount { get; set; }  
        public DateTime Create_At { get; set; }
        // 
        public ChangeShift ChangShift { get; set; } = null!;
        public PaymentMethod PaymentMethod { get; set; }=null!;
    }
}
