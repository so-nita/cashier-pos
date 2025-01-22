using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.Brand
{
    public class BrandResponse : IResponse
    {
        public string Id { get; set; }  = string.Empty;
        public int Code { get; set; }   
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
