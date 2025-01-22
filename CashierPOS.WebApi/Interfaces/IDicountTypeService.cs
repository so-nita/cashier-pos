using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.DiscountType;
using CashierPOS.WebApi.Services;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IDicountTypeService : IService<DicountTypeResponse, DicountTypeCreateReq, DicountTypeUpdateReq, Key>
    {
    }
}
