using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.DiscountProduct
{
    public class DicountProductUpdateReq : IUpdateReq
    {
        public string UserId { get; set; } = "";
        public string? DiscountId { get; set; } = "";
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public string? ProductId { get; set;}
    }
}
