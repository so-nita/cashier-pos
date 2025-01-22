using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Constants
{
    public enum SellType
    {
        [Display(Name = "walk-in")]
        InStored = 1,
        [Display(Name = "online")] 
        Online = 2,
    }
}
