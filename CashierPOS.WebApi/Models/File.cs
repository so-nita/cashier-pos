using System.ComponentModel.DataAnnotations;

namespace CashierPOS.WebApi.Models
{
    public class FileModel
    {
        [Required]
        public string FileName { get; set; } = "";
    }
}
