namespace Shared.Repositories
{
    internal interface IPartialOrderRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
