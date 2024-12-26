using Core.Entities.Abstract;
using Core.Utilities.Response.Abstract;

namespace Core.Business.Abstract
{
    public interface IEntityService<T> where T : class, IBaseEntity, new()
    {
        //CRUD Operations
        IResponse Add(T entity);
        IResponse Delete(int id);
        IResponse Update(T entity);
        IDataResponse<T?> GetById(int id);
        IDataResponse<IEnumerable<T>> GetAll();
    }
}
