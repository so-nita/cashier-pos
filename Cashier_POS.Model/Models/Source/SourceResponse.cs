using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.Source
{
    public class SourceResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
    }
}
