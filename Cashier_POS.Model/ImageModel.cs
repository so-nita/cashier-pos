using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace CashierPOS.Model
{
    public class ImageModel
    {
        public IFormFile Image { get; set; }
        public string Name { get; set; }
    }

}
