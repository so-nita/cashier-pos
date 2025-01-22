using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.Brand
{
    public class BrandCreateReq : ICreateReq
    {
        public string Name { get; set; } = "";
        public string? Description { get; set; }
    }
}
