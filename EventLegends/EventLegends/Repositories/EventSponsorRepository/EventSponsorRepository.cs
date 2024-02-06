using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Models.Base;
using EventLegends.Repositories.CategoryRepository;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.EventSponsorRepository
{
    public class EventSponsorRepository : GenericRepository<EventSponsor>, IEventSponsorRepository
    {
        public EventSponsorRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
