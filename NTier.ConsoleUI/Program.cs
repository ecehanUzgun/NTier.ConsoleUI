using NTier.DAL.Entity;
using NTier.BLL.Concretes;

namespace NTier.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DAL katmanında Entity
            Category category = new Category
            {
                CategoryName = "Test Kategori"
            };

            //BLL katmanında bulunan görev
            CategoryService categoryService = new CategoryService();
            categoryService.Create(category);

            //Product
            Product product = new Product();
            product.ProductName = "Product1";
            product.UnitPrice = 100;

            ProductService productService = new ProductService();
            productService.Create(product);

            productService.Read();

        }
    }
}
