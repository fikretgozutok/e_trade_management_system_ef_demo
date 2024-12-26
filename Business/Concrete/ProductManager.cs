using Business.Abstract;
using Core.Business.Abstract;
using Core.Utilities.Response.Abstract;
using Core.Utilities.Response.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : BaseEntityService<Product>, IProductService
    {
        public ProductManager(IProductRepository repository) : base(repository) { }

        public IDataResponse<bool> IsProductNameExists(string name)
        {
            try
            {
                var products = _repository.GetAll().FirstOrDefault(p=>p.Name == name);

                bool isProductExists = products != null;

                return new SuccessDataResponse<bool>(isProductExists);
            }
            catch (Exception ex)
            {
                return new ErrorDataResponse<bool>(default, message: ex.Message);
            }
        }
    }
}
