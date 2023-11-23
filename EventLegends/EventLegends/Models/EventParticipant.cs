using EventLegends.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventLegends.Models
{
    public class EventParticipant : BaseEntity
    {
        //Relatie Many-to-One
        public Guid UserId { get; set; }
        public User User { get; set; }

        //Relatie Many-to-Many cu event
      
        public ICollection<EventParticipants> EventParticipants { get; set; }

        
        //relatie one-to-many cu tickets
        public ICollection<Ticket> Tickets { get; set; }

        /*
        public EventParticipant() { 
          //  Tickets = new List<Ticket>();

        }

        public EventParticipant(int eventParticipantId, User user,Event Event) : this()
        {
            this.EventParticipantId = eventParticipantId;
            this.User = user;
            Event = Event;
           
        }
        
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        */
    }
}
