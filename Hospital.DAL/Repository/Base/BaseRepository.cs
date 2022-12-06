using Hospital.BO.Entities;

namespace Hospital.DAL.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> 
        where TEntity : BaseEntity
    {
        static IList<TEntity> Databases { get; set; } = new List<TEntity>();
        public Task<TEntity> Add(TEntity model)
        {
            Databases.Add(model);
            return Task.Run(() => model);
        }

        public Task<bool> Delete(int Id)
        {
            var model = Databases.FirstOrDefault(m => m.Id == Id);
            if (model != null)
            {
                Databases.Remove(model);
            }
            return Task.FromResult(model != null);
        }

        public Task<IList<TEntity>> FindAll()
        {
            return Task.FromResult(Databases);
        }

        public Task<TEntity> FindById(int Id)
        {
            var model = Databases.FirstOrDefault(m => m.Id == Id);
            return Task.FromResult(model);
        }

        public Task<TEntity> Update(TEntity model)
        {
            var index = Databases.Select(m => m.Id).ToList().IndexOf(model.Id);
            Databases.RemoveAt(index);
            Databases.Insert(index, model);

            return Task.FromResult(model);
        }
    }
}
