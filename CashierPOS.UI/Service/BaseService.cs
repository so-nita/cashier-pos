using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Response;
using Newtonsoft.Json;
using System.Text;

namespace CashierPOS.UI.Service;

public abstract class BaseService
{
    protected readonly HttpClient _httpClient;
    //--protected string BaseUrl { get; set; } = "http://172.20.10.51:8055/api/";
    protected string BaseUrl { get; set; } = "http://172.20.17.25:8022/api/";
    protected BaseService()
    {
        _httpClient = HttpClientManager.GetHttpClient();
    }

    protected async Task<T> GetAsync<T>(string urlEndpoint)
    {
        try
        {
            var response = await _httpClient.GetAsync(urlEndpoint);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString)!;
            }

            return default!;
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    protected async Task<TResponse> PostAsync<TRequest, TResponse>(string urlEndpoint, TRequest model)
    {
        try
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(urlEndpoint, content);
            /*if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(jsonString)!;
            }*/
            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(jsonString)!;
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    protected async Task<TResponse> PutAsync<TRequest, TResponse>(string urlEndpoint, TRequest model)
    {
        try
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(urlEndpoint, content);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(jsonString)!;
            }
            return default!;
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    protected async Task<Response<string>> DeleteAsync<T>(string urlEndpoint,T request)
    {
        try
        {
            var jsonContent = JsonConvert.SerializeObject(request);
            var requestData = new HttpRequestMessage(HttpMethod.Delete, urlEndpoint);
            var content_ = new StringContent(jsonContent, null, "application/json");

            requestData.Content = content_;

            var response = await _httpClient.SendAsync(requestData);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Response<string>>(jsonString)!;
            }
            return default!;
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    protected async Task<T> GetByIdAsync<T>(string urlEndpoint, Key key)
    {
        try
        {
            string url = $"{urlEndpoint}/{key}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString)!;
            }

            return default!;
        }
        catch (Exception ex)
        {
            //throw ex.InnerException!;
            return default;
        }
    }
}
