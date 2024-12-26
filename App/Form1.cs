using Business.Abstract;
using Entities.Concrete;

namespace App
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;
        private ICollection<Category>? _categories;
        private Category? _category;
        public Form1(IProductService productManager, ICategoryService categoryManager)
        {
            InitializeComponent();

            _productManager = productManager;
            _categoryManager = categoryManager;

            GetCategories();

            if (_categories != null) ListCategories(_categories);

        }

        private void ListCategories(IEnumerable<Category> categories)
        {
            cmbBoxCategory.DataSource = categories.ToList();
            cmbBoxCategory.DisplayMember = "Name";
            cmbBoxCategory.ValueMember = "Id";

            if (categories.Count() == 0)
            {
                cmbBoxCategory.Text = string.Empty;
                cmbBoxCategory.SelectedValue = 0;
            }
        }

        private void GetCategories()
        {
            var categories = _categoryManager.GetAll();
            if (categories.IsSuccess)
            {
                _categories = categories.Data.ToList();
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategory.Text;

            var categoryNameExists = _categoryManager.IsCategoryNameExists(categoryName);

            if (categoryNameExists.IsSuccess && !categoryNameExists.Data)
            {

                var categoryToAdd = new Category { Name = categoryName, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };

                var response = _categoryManager.Add(categoryToAdd);

                if (response.IsSuccess)
                {
                    MessageBox.Show("Added!");

                    GetCategories();

                    ListCategories(_categories!);
                }
            }


        }

        private void cmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? comboBox = sender as ComboBox;

            _category = comboBox?.SelectedItem as Category;

            txtCategory.Text = _category?.Name;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            var isCategoryExists = _categoryManager.IsCategoryExists(_category!);

            if (isCategoryExists.IsSuccess && isCategoryExists.Data)
            {
                var categoryToUpdate = new Category
                {
                    Id = _category!.Id,
                    Name = txtCategory.Text,
                    CreatedDate = _category!.CreatedDate
                };

                _categoryManager.Update(categoryToUpdate);

                MessageBox.Show("Updated!");

                GetCategories();
                ListCategories(_categories!);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var isCategoryExists = _categoryManager.IsCategoryExists(_category!);

            if (isCategoryExists.IsSuccess && isCategoryExists.Data)
            {
                _categoryManager.Delete(_category!.Id);

                MessageBox.Show("Deleted!");

                GetCategories();
                ListCategories(_categories!);

                txtCategory.Text = string.Empty;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;

            var isProductExists = _productManager.IsProductNameExists(productName);

            if (isProductExists.IsSuccess && !isProductExists.Data)
            {
                var productToAdd = new Product
                {
                    Category = _category,
                    Name = productName,
                    Description = txtDescription.Text.ToString(),
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Price = Convert.ToInt32(txtPrice.Text),
                    UnitsOfStock = Convert.ToInt32(txtStock.Text)
                };
                _productManager.Add(productToAdd);
            }
        }
    }
}
