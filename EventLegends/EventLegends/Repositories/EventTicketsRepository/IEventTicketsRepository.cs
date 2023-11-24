using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;
using System.Reflection.Emit;

namespace EventLegends.Repositories.EventTicketsRepository
{
    public interface IEventTicketsRepository : IGenericRepository<EventTickets>
    {
    }
}
