using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.User;
using CashierPOS.UI.AppContexts;

namespace CashierPOS.UI.Service
{
    public class UserService : BaseService
    {
        private string GetUrl => BaseUrl + _endPoint;
        private string _endPoint { get; set; } = "auth";

        public async Task<Response<UserLogResponse>> GetUserLogin(UserLoginReq request)
        {
            _endPoint += "/login";
            var data = await PostAsync<UserLoginReq, Response<UserLogResponse>>(GetUrl, request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return data!;
            }
            AppStoreContext.SetCurrentUser(data.Result!);
            return data;
        }

        public async Task<Response<string>> GetUserLogout(UserLogoutReq request)
        {
            _endPoint += "/logout";
            var data = await PostAsync<UserLogoutReq, Response<string>>(GetUrl, request);

            if (data.Status != (int)ResponseStatus.Success)
            {
                return data;
            }
            return data!;
        }

        public async Task<Response<UserLogResponse>> GetUserApprove(UserLoginReq request)
        {
            _endPoint += "/getAuth";
            var data = await PostAsync<UserLoginReq, Response<UserLogResponse>>(GetUrl, request);
             
           /* if (data.Status == (int)ResponseStatus.Success)
            {
                return data;
            }*/
            return data;
        }

        public async Task<Response<UserLogResponse>> GetUserReopenshift(UserReponseShiftReq request)
        {
            _endPoint += "/reopenShift";
            var data = await PostAsync<UserReponseShiftReq, Response<UserLogResponse>>(GetUrl, request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return data;
            }
            AppStoreContext.ClearCurrentUser();
            AppStoreContext.SetCurrentUser(data.Result!);
            return data;
        }
    }
}
