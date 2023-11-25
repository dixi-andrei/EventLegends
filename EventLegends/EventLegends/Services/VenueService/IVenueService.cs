using EventLegends.Models.DTOs;

namespace EventLegends.Services.VenueService
{
    public interface IVenueService
    {
        Task<List<VenueDto>> GetAllVenues();
        Task<VenueDto> GetVenueById(Guid venueId);
        Task CreateVenue(VenueDto venueDto);
        Task UpdateVenue(Guid venueId, VenueDto venueDto);
        Task DeleteVenue(Guid venueId);
    }
}
