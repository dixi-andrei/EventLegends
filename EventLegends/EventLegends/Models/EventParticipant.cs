namespace EventLegends.Models
{
    public class EventParticipant
    {
        public int EventParticipantId { get; set; }

        //Relatie Many-to-One
        public int UserId { get; set; }
        public User User { get; set; }

        //Relatie Many-to-One
        public int EventId { get; set; }
        public Event Event { get; set; }

        //Relatie One-to-One
        public Ticket Ticket { get; set; }

        public EventParticipant() { }

        public EventParticipant(int eventParticipantId, User user,Event Event, Ticket ticket)
        {
            EventParticipantId = eventParticipantId;
            User = user;
            Event = Event;
            Ticket = ticket;
        }
    }
}
