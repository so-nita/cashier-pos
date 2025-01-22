using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.Model.Models.PaymentType;
using CashierPOS.Model.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Service
{
    public class PaymentTypeService : BaseService
    {
        private string _getUrl => BaseUrl + _endPoint;
        private string _endPoint { get; set; } = "paymentType";

        public async Task<List<PaymentTypeResponse>> GetAll()
        {
            var data = await GetAsync<Response<List<PaymentTypeResponse>>>(_getUrl);
            if(data?.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return null!;
        }
    }
}
