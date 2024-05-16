using System.Net;

namespace RookEcomShop.ViewModels.Api
{
    public class Response<T>
    {
        public bool Succeeded { get; set; } = false;
        public string Message { get; set; } = null!;
        public T? Data { get; set; }
        public IEnumerable<T>? Datas { get; set; }
        public int Count { get; set; } = 0;
        public HttpStatusCode Status { get; set; } = HttpStatusCode.InternalServerError;

        public Response(string message, bool success = false, HttpStatusCode status = default)
        {
            Succeeded = success;
            Message = message;
            Status = status;
        }
        public Response(IEnumerable<T> datas, string message, int count = 0, HttpStatusCode status = HttpStatusCode.OK)
        {
            Succeeded = true;
            Message = message;
            Datas = datas;
            Count = count != 0 ? count : Datas.Count();
            Status = status;
        }
        public Response(T data, string message, HttpStatusCode status = HttpStatusCode.OK)
        {
            Succeeded = true;
            Message = message;
            Data = data;
            Status = status;
        }
    }
}
