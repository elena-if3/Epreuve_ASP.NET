using BLL.Mappers;
using Product = BLL.Entities.Product;
using Shared.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ProductService : IProductRepository<Product>
    {
        private readonly IProductRepository<DAL.Entities.Product> _productRepository;

        public ProductService(IProductRepository<DAL.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get().Select(d => d.ToBLL());
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id).ToBLL();
        }

        public int Insert(Product data)
        {
            return _productRepository.Insert(data.ToDAL());
        }

        public void Update(Product data)
        {
            _productRepository.Update(data.ToDAL());
        }

        public IEnumerable<Product> GetByCategory(int id)
        {
            return _productRepository.GetByCategory(id).Select(d => d.ToBLL());
        }

        public IEnumerable<Product> GetByEcoScore(string ecoScore)
        {
            return _productRepository.GetByEcoScore(ecoScore).Select(d => d.ToBLL());
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _productRepository.GetByName(name).Select(d => d.ToBLL());
        }

    }
}
