namespace EventLegends.Models.DTOs
{
    public class EventCategoriesDto
    {
        public Guid Id { get; set; }
        public Event Event { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
