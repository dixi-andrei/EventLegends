namespace EventLegends.Models.Base
{
    public class EventSponsor : BaseEntity
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }
    }
}
