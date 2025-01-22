namespace CashierPOS.WebApi.Test
{
    public class RolePermissions
    {
        public static Dictionary<UserRole, HashSet<UserPermission>> RolePermissionMap = new Dictionary<UserRole, HashSet<UserPermission>>
        {
            { 
                UserRole.Admin, new HashSet<UserPermission> 
                { 
                    UserPermission.CanApproveReturn, UserPermission.CanApplyDiscount 
                } 
            },
            {
                UserRole.SuperAdmin, new HashSet<UserPermission>
                {
                    UserPermission.CanApproveReturn, UserPermission.CanApplyDiscount
                }
            },
        };
    }

    public enum UserRole
    {
        Admin,
        SuperAdmin,
        Cashier
    }

    // Define permissions
    public enum UserPermission
    {
        CanApproveReturn,
        CanApplyDiscount
    }

}
