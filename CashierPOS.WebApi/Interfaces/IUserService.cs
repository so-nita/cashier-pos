using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.User;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.WebApi.Interface
{
    public interface IUserService : IService<UserResponse, UserCreateReq, UserUpdateReq, Key>
    {
        //Response<UserResponse?> GetLogin(UserLoginReq request);
        Response<UserLogResponse?> GetLogin(UserLoginReq request);
        Response<string> GetLogout(UserLogoutReq request);
        Response<UserLogResponse> GetUserApproved(UserLoginReq request);
       // Response<UserLogResponse> GetUserReOpenShift(UserReponseShiftReq request);
    }
    
}
