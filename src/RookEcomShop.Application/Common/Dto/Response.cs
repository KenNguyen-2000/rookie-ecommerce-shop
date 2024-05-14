using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Common.Dto
{
    public class Response
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.InternalServerError;
        public string Message { get; set; } = null!;
    }
    public sealed class Response<T>
    {
        public T? Data { get; set; }
    }
}
