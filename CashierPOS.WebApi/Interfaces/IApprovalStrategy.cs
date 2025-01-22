using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.User;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IApprovalStrategy
    {
        bool CanApprove(UserResponse user);
        bool CanApplyDiscount(UserResponse user);
        bool CanCreateDiscount(UserResponse user);
    }

    public class UserApprovalStrategy : IApprovalStrategy
    {
        public bool CanApprove(UserResponse user)
        {
            return user.User_Role.ToLower() == RoleType.Admin.ToString().ToLower() || user.User_Role.ToLower() == RoleType.SuperAdmin.ToString().ToLower();
        }


        public bool CanApplyDiscount(UserResponse user)
        {
            return user.User_Role.ToLower() == RoleType.Admin.ToString().ToLower() || user.User_Role.ToLower() == RoleType.SuperAdmin.ToString().ToLower();
        }

        
        public bool CanCreateDiscount(UserResponse user)
        {
            return user.User_Role.ToLower() == RoleType.Admin.ToString().ToLower() || user.User_Role.ToLower() == RoleType.SuperAdmin.ToString().ToLower();
        }
    }

    /*public class SuperAdminApprovalStrategy : IApprovalStrategy
    {
        public bool CanApprove(UserResponse user)
        {
            return user.Role_Type == RoleType.SuperAdmin.ToString();
        }
    }*/
}