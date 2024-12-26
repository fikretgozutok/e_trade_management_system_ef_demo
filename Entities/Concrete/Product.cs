using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int UnitsOfStock { get; set; }
        public Category? Category { get; set; }
    }
}
