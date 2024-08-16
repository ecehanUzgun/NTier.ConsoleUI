using NTier.DAL.Entity;

namespace NTier.BLL.Abstracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        //TEntity Generic Repository
        //Read (List)
        List<TEntity> Read();
        //Create 
        string Create(TEntity entity);
        //Update
        string Update(TEntity entity);
        //Delete
        string Delete(int id);
        //Find
        TEntity Find(int id);
    }
}
