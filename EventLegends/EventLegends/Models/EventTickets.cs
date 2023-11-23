using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class EventTickets : BaseEntity
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
