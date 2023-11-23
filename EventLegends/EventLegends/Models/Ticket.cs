
using EventLegends.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventLegends.Models
{
    public class Ticket : BaseEntity
    {
        public int TicketPrice { get; set; }

        //Relatie Many-to-Many cu event
     
        public ICollection<EventTickets> EventTickets { get; set; }

       //relatie many-to-one
        public EventParticipant EventParticipant { get; set; }
        public Guid EventParticipantId { get;  set; }

        //Relatie One-to-Many
        public ICollection<Order> Orders { get; set; }
        
        /*
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
        */
    }
 } 
