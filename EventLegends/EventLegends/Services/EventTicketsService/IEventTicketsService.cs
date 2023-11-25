using EventLegends.Models.DTOs;

namespace EventLegends.Services.EventTicketsService
{
    public interface IEventTicketsService
    {
        Task<List<EventTicketsDto>> GetAllEventTickets();
        EventTicketsDto GetEventTicketById(Guid eventTicketId);
        Task CreateEventTicket(EventTicketsDto eventTicketDto);
        Task UpdateEventTicket(Guid eventTicketId, EventTicketsDto eventTicketDto);
        Task DeleteEventTicket(Guid eventTicketId);
    }
}
