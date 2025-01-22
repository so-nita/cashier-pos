using CashierPOS.Model.Interface;

namespace CashierPOS.WebApi.Models.RequestModel.Receipt
{
    /*public class OrderPaymentResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string Code { get; set; } = string.Empty;    
        public string Reference_Id { get; set; } = "";
        public string Reference_Name { get; set; } = "";
        public string Order_Id { get; set; } = "";
        public decimal? Tax { get; set; }
        public decimal? Tax_Kh { get; set; }
        public decimal? Discount { get; set; } = 0.00m;
        public decimal Total { get; set; }
        public decimal Total_Kh { get; set; }
        public decimal? Received { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? Change { get; set; }
        public decimal? Exchange_Rate { get; set; }
        public string Paymentype { get; set; } = "";
        public string Reference { get; set; } = "";
        public string Company_Id { get; set; } = null!;
        public string Company_Address { get; set; } = null!;    
        public string Company_Contact { get; set; } = null!;
        public string CustomerType { get; set; } = null!;

        *//* public string Customer_Id { get; set; } = null!;
         public string Customer_Name { get; set; } = null!;*//*
        public DateTime Print_Date { get; set; }
    }
*/
    public class OrderPaymentResponse : IResponse
    {
        public string OrderPaymentId { get; set; } = "";
        public int Code { get; set; }  
        public int PosId { get; set; }  
        public string OrderId { get; set; } = "";
        public decimal Total { get; set; }
        public decimal TotalKh { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Tax_Kh { get; set; }
        public DateTime Transaction_Date { get; set; }
    }
}
