using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.DiscountProduct
{
    public class DiscountProductResponse : IResponse
    {
        public string Id { get; set; }  = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public decimal Discount {  get; set; }  
        public string DiscountName { get; set; } = string.Empty;    
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public string? Description { get; set; }
    }
}
