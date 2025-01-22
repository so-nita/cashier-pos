namespace CashierPOS.Model.Models.Constant
{
    public enum OrderStatus
    {
        Close = 1,
        Cancel = 2,
        Hold = 4,
        Return = 8,
    }

    public enum OrderItemStatus
    {
        Close = 1,
        Cancel = 2,
        Return = 4,
        //Delete = 8,
    }
}
