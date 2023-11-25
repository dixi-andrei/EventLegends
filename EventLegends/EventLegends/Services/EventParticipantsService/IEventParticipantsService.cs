using EventLegends.Models.DTOs;

namespace EventLegends.Services.EventParticipantsService
{
    public interface IEventParticipantsService
    {
        Task<List<EventParticipantsDto>> GetAllEventParticipants();
        EventParticipantsDto GetEventParticipantById(Guid eventParticipantId);
        Task CreateEventParticipant(EventParticipantsDto eventParticipantDto);
        Task UpdateEventParticipant(Guid eventParticipantId, EventParticipantsDto eventParticipantDto);
        Task DeleteEventParticipant(Guid eventParticipantId);
    }
}
