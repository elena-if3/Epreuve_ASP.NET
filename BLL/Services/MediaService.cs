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

        public MediaService(IMediaRepository<DAL.Entities.Media>
            mediaRepository)
        {
            _mediaRepository = mediaRepository;
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
    }
}
