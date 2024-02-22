using System.Collections.Generic;
using System.Linq;
using BLL.Mappers;
using Product = BLL.Entities.Product;
using Shared.Repositories;
using Media = BLL.Entities.Media;

namespace BLL.Services
{
    public class ProductService : IProductRepository<Product>
    {
        private readonly IProductRepository<DAL.Entities.Product> _productRepository;
        private readonly IMediaRepository<Media> _mediaRepository;

        public ProductService(IProductRepository<DAL.Entities.Product> productRepository, IMediaRepository<Media> mediaRepository)
        {
            _productRepository = productRepository;
            _mediaRepository = mediaRepository;
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
            Product entity = _productRepository.Get(id).ToBLL();
            IEnumerable<Media> media = _mediaRepository.GetByProduct(id);
            entity.AddMedias(media);
            return entity;
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
