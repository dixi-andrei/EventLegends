using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.TicketRepository
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
