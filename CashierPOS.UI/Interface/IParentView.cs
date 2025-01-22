using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.Product;

namespace CashierPOS.UI.Interface
{
    public interface IParentView
    {
        public List<ProductResponse> GetProducts { get; }
        public List<ProductResponse> Carts { get; set; }
        public ReturnOrderResponse ReturnOrder { get; set; }

        public void LoadDataApi();
        public HoldOrderResponse HoldOrder { get; set; }
        public int NumberHoldOrder {  get; set; }

        public void CloseView();
        public void ViewPOS_LoadingData();
        public string ProductApplyDiscount { get; set; } 
        public Task UpdateNumberOfHoldOrder();
        public void ReloadNotificationHoldOrder();
        public void UpdateProductData();
       // public void UserClosedShift();
    }
}
