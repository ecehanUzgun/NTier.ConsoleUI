using NTier.DAL.Entity;
using NTier.BLL.Concretes;

namespace NTier.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region DAL katmanında Entity
            //Category category = new Category
            //{
            //    CategoryName = "Test Kategori"
            //}; 
            #endregion

            //BLL katmanında bulunan görev
            #region CREATE Category
            CategoryService categoryService = new CategoryService();
            //categoryService.Create(category); 
            #endregion

            //Delete Category
            //categoryService.Delete(2);

            #region UPDATE Category
            //Category category1 = new Category();
            //category1.ID = 1;
            //category1.CategoryName = "Clothes";
            //categoryService.Update(category1); 
            #endregion

            #region List Category
            List<Category> categories = categoryService.Read();
            Console.WriteLine("Category List");
            foreach (Category category in categories)
            {
                Console.WriteLine(category.ID);
                Console.WriteLine(category.CategoryName);
                Console.WriteLine(category.CreatedDate);
            }
            #endregion


            //Product
            ProductService productService = new ProductService();
            #region CreateProduct
            //Product product = new Product();
            //product.ProductName = "Product1";
            //product.UnitPrice = 100;
            //productService.Create(product); 
            #endregion

            #region READ Product
            //List<Product> products = productService.Read();
            //Console.WriteLine("\nProduct List");
            //foreach (Product productOne in products)
            //{
            //    Console.WriteLine(productOne.ID);
            //    Console.WriteLine(productOne.ProductName);
            //    Console.WriteLine(productOne.UnitPrice);
            //    Console.WriteLine(productOne.CreatedDate);
            //} 
            #endregion
        }
    }
}
