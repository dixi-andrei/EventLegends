using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.MediaRepository
{
    public class MediaRepository : GenericRepository<Media>, IMediaRepository
    {
        public MediaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}

