namespace Shared.Repositories
{
    public interface ICategoryRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
