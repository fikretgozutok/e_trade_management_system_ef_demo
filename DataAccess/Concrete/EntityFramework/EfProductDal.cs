using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductRepository
    {
        public void Add(Product entity)
        {
            using (var context = new EfDbContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new EfDbContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Id == id);

                if (product != null)
                {
                    context.Remove(product);
                    context.SaveChanges();
                }
            }
        }

        public Product? Get(int id)
        {
            using (var context = new EfDbContext())
            {
                var product = context.Products.FirstOrDefault(p=>p.Id == id);

                return product;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (var context = new EfDbContext())
            {
                var products = context.Products.ToList();

                return products;
            }
        }

        public void Update(Product entity)
        {
            using (var context = new EfDbContext())
            {
                var product = context.Products.FirstOrDefault(p=>p.Id == entity.Id);

                if (product != null)
                {
                    product.CategoryId = entity.CategoryId;
                    product.UpdatedDate = DateTime.Now;
                    product.Name = entity.Name;
                    product.Description = entity.Description;
                    product.Price = entity.Price;
                    product.UnitsOfStock = entity.UnitsOfStock;

                    context.SaveChanges();
                }
            }
        }
    }
}
