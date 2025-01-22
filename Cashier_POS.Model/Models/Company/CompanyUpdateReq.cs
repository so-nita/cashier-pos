using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.RequestModel.Company;

public class CompanyUpdateReq : IUpdateReq
{
    public string Id { get; set; } = null!;
    public string? Name { get; set; } = null!;
    public string? Email { get; set; } = null!;
    public string? Contact { get; set; } = null!;
    public string? System_Id { get; set; } = null!;
    public string? Image { get; set; } = null!;
    public string? Website { get; set; }
    public string? Address { get; set; } = null!;
    public Status? Status { get; set; }
}
