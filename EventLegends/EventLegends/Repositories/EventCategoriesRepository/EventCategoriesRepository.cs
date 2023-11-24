using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.EventCategoriesRepository
{
    public class EventCategoriesRepository : GenericRepository<EventCategories>, IEventCategoriesRepository
    {
        public EventCategoriesRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
