namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Division
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string? CompanyId { get; set; }
        //public int Code { get; set; } 
        public string Status { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set;}
        public bool IsDeleted { get; set; }
        //
        public Company? Company { get; set; }
        public ICollection<Menu>? Menus { get; set; }   
    }
}
