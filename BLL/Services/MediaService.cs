using BLL.Mappers;
using Media = BLL.Entities.Media;
using Shared.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class MediaService : IMediaRepository<Media>
    {
        private readonly IMediaRepository<DAL.Entities.Media> _mediaRepository;
        private readonly IProductRepository<DAL.Entities.Product> _productRepository;

        public MediaService(IMediaRepository<DAL.Entities.Media>
            mediaRepository, IProductRepository<DAL.Entities.Product> productRepository)
        {
            _mediaRepository = mediaRepository;
            _productRepository = productRepository;

        }

        public void Delete(int id)
        {
            _mediaRepository.Delete(id);
        }

        public IEnumerable<Media> Get()
        {
            return _mediaRepository.Get().Select(d => d.ToBLL());
        }

        public Media Get(int id)
        {
            return _mediaRepository.Get(id).ToBLL();
        }

        public int Insert(Media data)
        {
            return _mediaRepository.Insert(data.ToDAL());
        }

        public void Update(Media data)
        {
            _mediaRepository.Update(data.ToDAL());
        }

        public IEnumerable<Media> GetByProduct(int productId)
        {
            return _mediaRepository.GetByProduct(productId).Select(d =>
            {
                Media result = d.ToBLL();
                result.Product = _productRepository.Get(result.Media_Id).ToBLL();
                return result;
            });
        }
    }
}
