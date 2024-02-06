using EventLegends.Models.Base;

namespace EventLegends.Models.DTOs
{
    public class EventSponsorDto
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }

    }
}
