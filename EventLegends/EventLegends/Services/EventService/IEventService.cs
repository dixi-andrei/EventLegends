using EventLegends.Models.DTOs;

namespace EventLegends.Services.EventService
{
    public interface IEventService
    {
        Task<List<EventDto>> GetAllEvents();
        Task<EventDto> GetEventById(Guid eventId);
        Task CreateEvent(EventDto eventDto);
        Task UpdateEvent(Guid eventId, EventDto eventDto);
        Task DeleteEvent(Guid eventId);
    }
}
