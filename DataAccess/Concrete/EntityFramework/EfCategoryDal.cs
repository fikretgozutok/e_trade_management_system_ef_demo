using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryRepository
    {
        public void Add(Category entity)
        {
            using (var context = new EfDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new EfDbContext())
            {
                var category = context.Categories.FirstOrDefault(c => c.Id == id);

                if (category != null)
                {
                    context.Remove(category);
                    context.SaveChanges();
                }
            }
        }

        public Category? Get(int id)
        {
            using (var context = new EfDbContext())
            {
                var category = context.Categories.FirstOrDefault(c => c.Id == id);
                return category;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            using (var context = new EfDbContext())
            {
                var categories = context.Categories.ToList();
                return categories;
            }
        }

        public void Update(Category entity)
        {
            using (var context = new EfDbContext())
            {
                var category = context.Categories.FirstOrDefault(c => c.Id == entity.Id);

                if (category != null)
                {
                    category.Name = entity.Name;
                    category.UpdatedDate = DateTime.Now;

                    context.SaveChanges();
                }
            }
        }
    }
}
