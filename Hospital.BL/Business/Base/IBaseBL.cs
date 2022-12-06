using Hospital.BL.DTO.In;
using Hospital.BL.DTO.Out;
using Hospital.BO.Entities;

namespace Hospital.BL.Business.Base
{
    public interface IBaseBL< TEntity> 
    {
        static  IList<TEntity>? Databases { get; set; }
        
        Task<TEntity> Add(TEntity model);
        
        Task<TEntity> Update(TEntity model);
        
        Task<bool> Delete(int Id);
        
        Task<TEntity> FindById(int Id);
        
        Task<IList<TEntity>> FindAll();
    }
}
