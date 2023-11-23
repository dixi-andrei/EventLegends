using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class Organizer : BaseEntity
    {

        // Relație One-to-Many cu Event
        public ICollection<Event> Events { get; set; }
        /*
        public Organizer() { 
            Events = new List<Event> { };
        }

        public Organizer(int organizerId) : this()
        {
            this.OrganizerId = organizerId;
        }

        public void AddEvents(Event Event) { 
            Events.Add(Event);
        }
        */
    }
}
