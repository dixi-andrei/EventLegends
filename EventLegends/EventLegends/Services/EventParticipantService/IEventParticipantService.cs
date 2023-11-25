using EventLegends.Models.DTOs;

namespace EventLegends.Services.EventParticipantService
{
    public interface IEventParticipantService
    {
        Task<List<EventParticipantDto>> GetAllEventParticipants();
        Task<EventParticipantDto> GetEventParticipantById(Guid id);

        Task CreateEventParticipant(EventParticipantDto eventParticipant);
        Task DeleteEventParticipant(Guid id);
        Task UpdateEventParticipant(Guid id,EventParticipantDto eventParticipant);
    }
}
