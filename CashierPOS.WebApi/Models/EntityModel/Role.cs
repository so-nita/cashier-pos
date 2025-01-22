using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Role 
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        //
       //-- public ICollection<User>? Users { get; set; }
    }
}