namespace Shared.Repositories
{
    public interface IMediaRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
