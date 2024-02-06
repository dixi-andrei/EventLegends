using EventLegends.Models.DTOs;

namespace EventLegends.Services.EventSponsorService
{
    public interface IEventSponsorService
    {
        Task<List<EventSponsorDto>> GetAllEventSponsors();
        Task<EventSponsorDto> GetEventSponsorById(Guid eventSponsorId);
        Task CreateEventSponsor(EventSponsorDto eventSponsorDto);
        Task UpdateEventSponsor(Guid eventSponsorId, EventSponsorDto eventSponsorDto);
        Task DeleteEventSponsor(Guid eventSponsorId);
    }
}
