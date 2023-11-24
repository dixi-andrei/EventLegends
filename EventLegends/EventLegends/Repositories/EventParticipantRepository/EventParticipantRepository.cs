using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;
namespace EventLegends.Repositories.EventParticipantRepository
{
    public class EventParticipantRepository : GenericRepository<EventParticipant>, IEventParticipantRepository
    {
        public EventParticipantRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
