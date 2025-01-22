using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.DiscountType
{
    public class DicountTypeResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal DiscountPercent { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
