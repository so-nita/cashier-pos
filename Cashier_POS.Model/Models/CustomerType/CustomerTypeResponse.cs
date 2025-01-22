using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.CustomerType
{
    public class CustomerTypeResponse : IResponse
    {
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
    }
}
