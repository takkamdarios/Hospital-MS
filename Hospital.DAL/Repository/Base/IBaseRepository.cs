using Hospital.BO.Entities;

namespace Hospital.DAL.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        static  IList<TEntity>? Databases { get; set; }
        
        Task<TEntity> Add(TEntity model);
        
        Task<TEntity> Update(TEntity model);
        
        Task<bool> Delete(int Id);
        
        Task<TEntity> FindById(int Id);
        
        Task<IList<TEntity>> FindAll();
    }
}
