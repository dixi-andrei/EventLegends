using EventLegends.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventLegends.Models
{
    public class Event : BaseEntity
    {
        public string EventName { get; set; } 
        public DateTime EventTime { get; set; }

        public Guid RatingId { get; set; }
        public Rating Rating { get; set; }

        // Relație Many-to-One cu Organizer
        public Guid OrganizerId { get; set; }    
        public Organizer Organizer { get; set; }

        //Relatie One-to-Many 
        public ICollection<Review> Reviews { get; set; }   

        //Relatie Many-to-Many cu Category
        public ICollection<EventCategories> EventCategories { get; set; }
        //relatie Many-to-many cu eventparticipants
        public ICollection<EventParticipants> EventParticipants { get; set; }

        //Reltie One-to-One
        public Venue Venue { get; set; }

        //Relatie Many-to-Many cu Ticket
        public ICollection<EventTickets> EventTickets { get; set; }


        /*
        public Event()
        {
            Reviews = new List<Review>();
            EventCategories = new List<EventCategories>();
            EventParticipants = new List<EventParticipant>();
            
        }

        public Event(string EventName, DateTime DateTime, Organizer Organizer) : this()
        {
            this.EventName = EventName;
            this.EventTime = DateTime;
            this.Organizer = Organizer;
        }
        
        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }

        public void AddCategory(EventCategories category)
        {
            EventCategories.Add(category);
        }

        public void AddEventParticipant(EventParticipant participant)
        {
            EventParticipants.Add(participant);
        }
        
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        */
    }
}
