using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Constants
{
    public enum CustomerTypes
    {
        /*General= 1,
        Online = 2,
        Loyalty = 3*/
        [Display(Name = "General Customer")]
        General,

        [Display(Name = "Online Customer")]
        Online,

        [Display(Name = "Loyality Customer")]
        Loyality
    }
}
