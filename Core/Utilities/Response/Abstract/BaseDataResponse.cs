namespace Core.Utilities.Response.Abstract
{
    public abstract class BaseDataResponse<T> : BaseResponse, IDataResponse<T>
    {
        public T Data { get; set; }
        protected BaseDataResponse(bool isSuccess, T data) : base(isSuccess) => Data = data;
        protected BaseDataResponse(bool isSuccess, T data, string message) : base(isSuccess, message) => Data = data;

    }
}
