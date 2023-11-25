using EventLegends.Models.DTOs;

namespace EventLegends.Services.TicketService
{
    public interface ITicketService
    {
        Task<List<TicketDto>> GetAllTickets();
        Task<TicketDto> GetTicketById(Guid ticketId);
        Task CreateTicket(TicketDto ticketDto);
        Task UpdateTicket(Guid ticketId, TicketDto ticketDto);
        Task DeleteTicket(Guid ticketId);
    }
}
