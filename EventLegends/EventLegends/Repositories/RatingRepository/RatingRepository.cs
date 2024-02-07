using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Models.Base;
using EventLegends.Repositories.CategoryRepository;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.RatingRepository
{
    public class RatingRepository : GenericRepository<Rating>, IRatingRepository
    {
        public RatingRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
