using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.DiscountType
{
    public class DicountTypeCreateReq : ICreateReq
    {
        public string UserId { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal DiscountPercent { get; set; }    
    }
}
