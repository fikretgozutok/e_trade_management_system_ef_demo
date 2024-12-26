namespace Core.Utilities.Response.Abstract
{
    public interface IResponse
    {
        bool IsSuccess { get; set; }
        string Message {  get; set; }
    }
}
