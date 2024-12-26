using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Core.Utilities.Response.Abstract;
using Core.Utilities.Response.Concrete;

namespace Core.Business.Abstract
{
    public abstract class BaseEntityService<T> : IEntityService<T> where T : class, IBaseEntity, new()
    {
        protected readonly IRepository<T> _repository;

        protected BaseEntityService(IRepository<T> repository) => _repository = repository;
        public IResponse Add(T entity)
        {
            try
            {
                _repository.Add(entity);

                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                return new ErrorResponse(ex.Message);
            }
        }

        public IResponse Delete(int id)
        {
            try
            {
                _repository.Delete(id);

                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                return new ErrorResponse(ex.Message);
            }
        }

        public IDataResponse<IEnumerable<T>> GetAll()
        {
            try
            {
                var data = _repository.GetAll();

                return new SuccessDataResponse<IEnumerable<T>>(data);
            }
            catch (Exception ex)
            {
                return new ErrorDataResponse<IEnumerable<T>>(null, message : ex.Message);
            }
        }

        public IDataResponse<T?> GetById(int id)
        {
            try
            {
                var data = _repository.Get(id);

                return new SuccessDataResponse<T?>(data);
            }
            catch (Exception ex)
            {
                return new ErrorDataResponse<T?>(null, message: ex.Message);
            }
        }

        public IResponse Update(T entity)
        {
            try
            {
                _repository.Update(entity);

                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                return new ErrorResponse(ex.Message);
            }
        }
    }
}
