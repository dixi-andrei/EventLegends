using EventLegends.Models.DTOs;

namespace EventLegends.Services.OrganizerService
{
    public interface IOrganizerService
    {
        Task<List<OrganizerDto>> GetAllOrganizers();
        Task<OrganizerDto> GetOrganizerById(Guid id);
        Task CreateOrganizer(OrganizerDto organizer);
        Task DeleteOrganizer(Guid id);
        Task UpdateOrganizer(Guid id,OrganizerDto organizer);
    }
}
