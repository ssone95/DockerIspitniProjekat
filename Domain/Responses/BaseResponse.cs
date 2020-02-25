using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Domain.Responses
{
    public class BaseResponse<T>
    {
        public string Message { get; set; }

        public bool Success { get; set; } = true;

        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

        public T Result { get; set; }

        public int TotalItems { get; set; }
    }
}
