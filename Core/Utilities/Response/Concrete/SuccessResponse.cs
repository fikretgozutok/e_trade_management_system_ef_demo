using Core.Utilities.Response.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Response.Concrete
{
    public class SuccessResponse : BaseResponse
    {
        public SuccessResponse() : base(true) { }

        public SuccessResponse(string message) : base(true, message) { }
    }

    public class ErrorResponse : BaseResponse
    {
        public ErrorResponse() : base(false) { }
        public ErrorResponse(string message) : base(false, message) { }
    }

    public class SuccessDataResponse<T> : BaseDataResponse<T>
    {
        public SuccessDataResponse(T data) : base(true, data) { }
        public SuccessDataResponse(T data, string message) : base(true, data, message) { }
    }

    public class ErrorDataResponse<T> : BaseDataResponse<T>
    {
        public ErrorDataResponse(T? data) : base(false, data ?? default!) { }
        public ErrorDataResponse(T? data , string message) : base(true, data ?? default!, message) { }
    }
}
