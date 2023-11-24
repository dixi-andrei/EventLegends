namespace EventLegends.Models.DTOs
{
    public class VenueDto
    {
        public Guid Id { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public int VenueCapacity { get; set; }
    }
}
