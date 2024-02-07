namespace EventLegends.Models.Base;

public class Rating : BaseEntity
{
    public int RatingScore { get; set; }

    public ICollection<Event> Events { get; set; }

    public ICollection<User> Users { get; set; }
}
