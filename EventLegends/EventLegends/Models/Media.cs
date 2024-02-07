using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class Media : BaseEntity
    {
        public string MediaType { get; set; }
        public int MediaFiles { get; set; }

        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}
