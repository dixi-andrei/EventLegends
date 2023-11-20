namespace EventLegends.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int TicketPrice { get; set; }

        //Relatie Many-to-One
        public int EventId { get; set; }
        public Event Event { get; set; }

        //Relatie One-to-One
        public EventParticipant EventParticipant { get; set; }

        //Relatie One-to-Many
        public List<Order> Orders { get; set; }

        public Ticket()
        {
            Orders = new List<Order>();
        }

       public Ticket(int ticketId, int ticketPrice,Event Event, EventParticipant EventParticipant) : this()
        {
            TicketId = ticketId;
            TicketPrice = ticketPrice;
            this.Event = Event;
            this.EventParticipant = EventParticipant;
        }

        public void AddOrders(Order order) { 
            Orders.Add(order);
        }
    }
 } 
