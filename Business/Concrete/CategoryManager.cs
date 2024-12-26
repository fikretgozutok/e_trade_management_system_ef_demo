using Business.Abstract;
using Core.Business.Abstract;
using Core.Utilities.Response.Abstract;
using Core.Utilities.Response.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;

namespace Business.Concrete
{
    public class CategoryManager : BaseEntityService<Category>, ICategoryService
    {
        
        public CategoryManager(ICategoryRepository repository) : base(repository) { }

        public IDataResponse<bool> IsCategoryExists(Category entity)
        {
            try
            {
                var category = _repository.GetAll().FirstOrDefault(c => c.Id == entity.Id);

                bool isCategoryExists = category != null;

                return new SuccessDataResponse<bool>(isCategoryExists);
            }
            catch (Exception ex) 
            {
                return new ErrorDataResponse<bool>(data: default!, message: ex.Message);
            }
        }

        public IDataResponse<bool> IsCategoryNameExists(string name)
        {
            try
            {
                var category = _repository.GetAll().FirstOrDefault(c => c.Name.ToLower() == name.ToLower());

                bool isCategoryExists = category != null;

                return new SuccessDataResponse<bool>(isCategoryExists);
            }
            catch (Exception ex) 
            { 
                return new ErrorDataResponse<bool>(default, ex.Message);
            }
        }
    }
}
