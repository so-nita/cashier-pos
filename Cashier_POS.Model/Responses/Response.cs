using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Response
{
    public class Response<T>
    {
        public int Status { get; set; }
        public string? Message { get; set; }
        public int Total { get; set; }
        public T? Result { get; set; } = default(T?);

        public static Response<T> Success(T? data = default, int total = 0, string _message = null!)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatus.Success,
                Total = total,
                Message = _message ?? string.Empty,
                Result = data,
            };
        }

        public static Response<T> NotFound(string _message = null!, T? data = default, int total = 0)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatus.NotFound,
                Total = total,
                Message = _message,
                Result = data
            };
        }
        public static Response<T> Conflict(string _message = null!, T? data = default, int total = 0)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatus.Fail,
                Total = total,
                Message = _message,
                Result = data
            };
        }
        public static Response<T> Fail(string _message = null!, T? data = default, int total = 0)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatus.Fail,
                Total = total,
                Message = _message,
                Result = data
            };
        }

    }
}
