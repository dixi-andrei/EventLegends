using EventLegends.Models.DTOs;

namespace EventLegends.Services.SponsorService
{
    public interface ISponsorService
    {
        Task<List<SponsorDTO>> GetAllSponsors();
        Task<SponsorDTO> GetSponsorById(Guid sponsorId);
        Task CreateSponsor(SponsorDTO sponsorDto);
        Task UpdateSponsor(Guid sponsorId, SponsorDTO sponsorDto);
        Task DeleteSponsor(Guid sponsorId);
    }
}
