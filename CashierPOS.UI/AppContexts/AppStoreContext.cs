using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.User;

namespace CashierPOS.UI.AppContexts
{
    public static class AppStoreContext
    {
        //public static UserLogResponse CurrentUser { get; private set; } = null!;

        public static UserLogResponse CurrentUserApprove { get; private set; } = null!;

        public static void SetCurrentUser(UserLogResponse user)
        {
            //CurrentUser = user;
        }

        public static void ClearCurrentUser()
        {
            //CurrentUser = null!;
        }

        public static void SetUserApprove(UserLogResponse user)
        {
            CurrentUserApprove = user;
        }

        public static void ClearCurrentUserApprove()
        {
            CurrentUserApprove = null!;
        }

        public static UserLogResponse CurrentUser
        {
            get =>
                new UserLogResponse()
                {   
                    ShiftId = 42,
                    PosId = 3,
                    CompanyId = "1",
                    ExchangeRate = 4150,
                    SaleExchangeRate = 4050,
                    Name = "RAE665",
                    UserId = "665",
                    UserName = "665",
                    ShiftStatus = ShiftStatus.Open,
                };
        }
    }
}
