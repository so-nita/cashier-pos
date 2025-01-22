using CashierPOS.Model.Models.Constant;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class UserLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  
        /*[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pos_Id { get; set; }*/
        public int PosId { get; set; }
        public string User_Id { get; set; } = "";
        public string User_Name { get; set; } = "";
        public string User_Role { get; set; } = "";
        public ActionLog Action { get; set; }  
        public DateTime LoginAt { get; set; } 
        public DateTime? LogoutAt { get; set; } 
        //
        public User User { get; set; } = null!;
        public ICollection<ChangeShift>? ChangShifts { get; set; }
    }
}


