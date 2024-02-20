namespace Shared.Repositories
{
    public interface IProductRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
