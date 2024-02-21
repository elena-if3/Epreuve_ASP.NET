using System.Collections.Generic;

namespace Shared.Repositories
{
    public interface IProductRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        public IEnumerable<TEntity> GetByName(string name);
        public IEnumerable<TEntity> GetByCategory(int id);
        public IEnumerable<TEntity> GetByEcoScore(string ecoScore);
    }
}
