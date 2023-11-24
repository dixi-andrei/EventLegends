using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.EventTicketsRepository
{
    public class EventTicketsRepository : GenericRepository<EventTickets>, IEventTicketsRepository
    {
        public EventTicketsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
