using Microsoft.EntityFrameworkCore;
using NTier.BLL.Abstracts;
using NTier.DAL.Context;
using NTier.DAL.Entity;

namespace NTier.BLL.Concretes
{
    public class BaseService<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ProjectContext context = new ProjectContext();

        //field
        private readonly DbSet<TEntity> _object;

        public BaseService()
        {
            _object = context.Set<TEntity>();
        }

        public string Create(TEntity entity)
        {
            try
            { 
                _object.Add(entity);
                context.SaveChanges();
                return "Category Created.";
            }
            catch (Exception ex) 
            {
                return "Category can not created!";
            }
        }

        public string Delete(int id)
        {
            TEntity deleted = Find(id);
            if (deleted != null)
            {
                _object.Remove(deleted);
                context.SaveChanges();
                return "Category Deleted";
            }
            else
            {
                return "Category can not find!";
            }
        }

        public TEntity Find(int id)
        {
            TEntity entity = _object.Find(id);
            if (entity != null) 
            { 
                return entity;
            }
            else 
            {
                return entity;
            }
        }

        public List<TEntity> Read()
        {
            return _object.ToList();
        }

        //public string Update(TEntity entity)
        //{
            //try
            //{
            //    TEntity updated = Find(entity);
            //    if (updated != null)
            //    {
            //        updated.CategoryName = category.CategoryName;
            //        context.SaveChanges();
            //        return "Category Updated";
            //    }
            //    else
            //    {
            //        return "Category can not find!";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}
        //}
    }
}
