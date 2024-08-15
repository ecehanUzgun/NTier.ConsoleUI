using NTier.BLL.Abstracts;
using NTier.DAL.Context;
using NTier.DAL.Entity;

namespace NTier.BLL.Concretes
{
    public class CategoryService : ICategoryRepository
    {
        ProjectContext context = new ProjectContext();
        public void CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }
    }
}
