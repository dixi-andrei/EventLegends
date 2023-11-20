namespace EventLegends.Models
{
    public class Organizer
    {
        public string OrganizerId { get; set; }

        // Relație One-to-Many cu Event
        public List<Event> Events { get; set; }

        public Organizer() { 
            Events = new List<Event> { };
        }

        public Organizer(string organizerId) : this()
        {
            OrganizerId = organizerId;
        }

        public void AddEvents(Event Event) { 
            Events.Add(Event);
        }
    }
}
