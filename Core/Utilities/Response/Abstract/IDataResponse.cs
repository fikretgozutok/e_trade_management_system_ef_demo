namespace Core.Utilities.Response.Abstract
{
    public interface IDataResponse<T> : IResponse
    {
        T Data { get; set; }
    }
}
