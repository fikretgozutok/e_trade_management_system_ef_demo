using Core.Business.Abstract;
using Core.Utilities.Response.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService : IEntityService<Product> 
    {
        IDataResponse<bool> IsProductNameExists(string name);
    }
}
