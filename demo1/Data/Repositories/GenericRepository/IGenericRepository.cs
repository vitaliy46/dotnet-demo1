namespace demo1.Data.Repositories.BaseRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Update(TEntity item);
        void Remove(TEntity item);
    }
}
