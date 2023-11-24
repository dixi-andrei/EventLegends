using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.EventParticipantsRepository
{
    public class EventParticipantsRepository : GenericRepository<EventParticipants>, IEventParticipantsRepository
    {
        public EventParticipantsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
