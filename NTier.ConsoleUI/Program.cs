using NTier.DAL.Entity;
using NTier.BLL.Concretes;

namespace NTier.ConsoleUI
{
    internal class Program
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
            categoryService.CreateCategory(category);

            Console.Read();
        }
    }
}
