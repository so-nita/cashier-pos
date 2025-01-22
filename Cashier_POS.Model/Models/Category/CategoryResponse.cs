﻿using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Category
{
    public class CategoryResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Image { get; set; }
        //--public string? Description { get; set; }  
        public DateTime Create_At { get; set; }
        public string Status { get; set; } = "";
        public bool Is_Deleted { get; set; }
    }
}
