using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Category;

namespace CashierPOS.Model.Interface
{
    public interface ICategoryService : IService<CategoryResponse,CategoryCreateReq,CategoryUpdateReq,Key>
    {

    }
}
