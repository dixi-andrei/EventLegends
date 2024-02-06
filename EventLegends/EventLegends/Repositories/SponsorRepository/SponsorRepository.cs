using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Models.Base;
using EventLegends.Repositories.CategoryRepository;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.SponsorRepository
{
    public class SponsorRepository : GenericRepository<Sponsor>, ISponsorRepository
    {
        public SponsorRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
