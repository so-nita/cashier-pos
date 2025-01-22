using CashierPOS.Model.Constants;
using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Customer
{
    public class CustomerCreateReq : ICreateReq
    {
        public string Name { get; set; } = "";
        public string Contact { get; set; } = "";
        public Gender Gender {  get; set; }
        public Nationality Nationality { get; set; }
        public CustomerTypes CustomerTypeCode { get; set; }  
    }
}
