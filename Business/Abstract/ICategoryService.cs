using Core.Business.Abstract;
using Core.Utilities.Response.Abstract;
using Core.Utilities.Response.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService : IEntityService<Category> 
    {
        IDataResponse<bool> IsCategoryNameExists(string name);
        IDataResponse<bool> IsCategoryExists(Category entity);
    }
}
