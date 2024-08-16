using NTier.BLL.Abstracts;
using NTier.DAL.Context;
using NTier.DAL.Entity;

namespace NTier.BLL.Concretes
{
    //Interface
    public class CategoryService : ICategoryRepository
    {
        ProjectContext context = new ProjectContext();

        public string Create(Category entity)
        {
            try
            {
                context.Categories.Add(entity);
                context.SaveChanges();
                return "Category Created";
            }
            catch(Exception ex) 
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            Category deleted = Find(id);
            if (deleted != null) 
            { 
                context.Categories.Remove(deleted);
                context.SaveChanges();
                return "Category Deleted";
            }
            else
            {
                return "Category can not find!";
            }
        }

        public Category Find(int id)
        {
            Category category = context.Categories.Find(id);
            if (category != null) 
            { 
                return category;
            }
            else 
            {
                return category;
            }
        }

        public List<Category> Read()
        {
            return context.Categories.ToList();
        }
        //Update Category
        public string Update(Category category)
        {
            try
            { 
                Category updated = Find(category.ID);
                if (updated != null)
                {
                    updated.CategoryName = category.CategoryName;
                    context.SaveChanges();
                    return "Category Updated";
                }
                else
                {
                    return "Category can not find!";
                }
            }
            catch(Exception ex) 
            {
                return ex.Message;
            }
        }
    }
}
