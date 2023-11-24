namespace EventLegends.Models.DTOs
{
    public class EventTicketsDto
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
