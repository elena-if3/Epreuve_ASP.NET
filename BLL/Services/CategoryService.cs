using BLL.Entities;
using BLL.Mappers;
using Shared.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class CategoryService : ICategoryRepository<Category>
    {
        private readonly ICategoryRepository<DAL.Entities.Category> _categoryRepository;
        private readonly IProductRepository<Product> _productRepository;

        public CategoryService(ICategoryRepository<DAL.Entities.Category> categoryRepository, IProductRepository<Product> productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> Get()
        {
            return _categoryRepository.Get().Select(d => d.ToBLL());
        }

        public Category Get(int id)
        {
            Category entity = _categoryRepository.Get(id).ToBLL();
            IEnumerable<Product> product = _productRepository.GetByCategory(id);
            entity.AddProducts(product);
            return entity;
        }

        public int Insert(Category data)
        {
            return _categoryRepository.Insert(data.ToDAL());
        }

        public void Update(Category data)
        {
            _categoryRepository.Update(data.ToDAL());
        }
    }
}
