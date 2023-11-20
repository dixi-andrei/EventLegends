namespace EventLegends.Models
{
    public class EventCategories
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }  

        public EventCategories() { }
        public EventCategories(Event Event, Category Category) {
            this.Event = Event;
            this.Category = Category;
        }
    }
}
