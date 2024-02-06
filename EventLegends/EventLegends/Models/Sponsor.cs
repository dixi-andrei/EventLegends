namespace EventLegends.Models;
using EventLegends.Models.Base;

public class Sponsor : BaseEntity
{
    public string SponsorName { get; set; }

    public ICollection<EventSponsor> EventSponsors { get; set; }
}
