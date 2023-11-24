namespace EventLegends.Models.DTOs
{
    public class EventParticipantDto
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
