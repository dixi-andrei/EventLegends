using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class EventParticipants :  BaseEntity
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid EventParticipantId { get; set; }
        public EventParticipant EventParticipant { get; set; }
    }
}
