namespace EventLegends.Models.DTOs
{
    public class EventParticipantsDto
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid EventParticipantId { get; set; }
        public EventParticipant EventParticipant { get; set; }
    }
}
