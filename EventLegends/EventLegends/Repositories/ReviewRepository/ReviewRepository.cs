using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.ReviewRepository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
