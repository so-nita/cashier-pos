using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Service
{
    public static class HttpClientManager
    {
        private static HttpClient _httpClient = new HttpClient();
        public static HttpClient GetHttpClient() => _httpClient;
    }
}
