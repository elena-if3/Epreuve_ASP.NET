using System.Collections.Generic;

namespace Shared.Repositories
{
    public interface IMediaRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        public IEnumerable<TEntity> GetByProduct(int id);
    }
}
