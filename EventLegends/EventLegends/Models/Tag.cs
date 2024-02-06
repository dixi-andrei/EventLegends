namespace EventLegends.Models.Base;

public class Tag : BaseEntity
{
    public string TagName { get; set; }

    public Guid EventId { get; set; }
    public Event Event { get; set; }

}
