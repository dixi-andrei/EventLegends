using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class EventCategories : BaseEntity
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }  

        /*
        public EventCategories() { }
        public EventCategories(int EventCategoriesId,Event Event, Category Category) {
            this.EventCategoriesId = EventCategoriesId;
            this.Event = Event;
            this.Category = Category;
        }
        */
    }
}
