using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.SubCategory;

namespace CashierPOS.WebApi.Interface.ISubCategory
{
    public interface ISubCategoryService : IService<SubCategoryResponse, SubCategoryCreateReq, SubCategoryUpdateReq, Key>
    {
    }
}
