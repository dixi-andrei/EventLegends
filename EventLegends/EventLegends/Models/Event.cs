namespace EventLegends.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; } 
        public DateTime EventTime { get; set; }

        // Relație Many-to-One cu Organizer
        public int OrganizerId { get; set; }    
        public Organizer Organizer { get; set; }

        //Relatie One-to-Many 
        public List<Review> Reviews { get; set; }   

        //Relatie Many-to-Many cu Category
        public List<EventCategories> EventCategories { get; set; }

        //Reltie One-to-One
        public Venue Venue { get; set; }

        //Relatie One-to-Many
        public List<Ticket> Tickets { get; set; }

        public Event()
        {
            Reviews = new List<Review>();
            EventCategories = new List<EventCategories>();
            Tickets = new List<Ticket>();
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

        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
