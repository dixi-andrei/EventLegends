using EventLegends.Models.DTOs;
using EventLegends.Services.OrganizerService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizersController : ControllerBase
    {
        private readonly IOrganizerService _organizerService;

        public OrganizersController(IOrganizerService organizerService)
        {
            _organizerService = organizerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrganizers()
        {
            var organizers = await _organizerService.GetAllOrganizers();
            return Ok(organizers);
        }

        [HttpGet("{organizerId}")]
        public async Task<IActionResult> GetOrganizerById([FromRoute] Guid organizerId)
        {
            var organizer = await _organizerService.GetOrganizerById(organizerId);

            if (organizer == null)
            {
                return NotFound();
            }

            return Ok(organizer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrganizer([FromBody] OrganizerDto organizerDto)
        {
            await _organizerService.CreateOrganizer(organizerDto);
            return Ok();
        }

        [HttpPut("{organizerId}")]
        public async Task<IActionResult> UpdateOrganizer([FromRoute] Guid organizerId, [FromBody] OrganizerDto organizerDto)
        {
            await _organizerService.UpdateOrganizer(organizerId, organizerDto);
            return Ok();
        }

        [HttpDelete("{organizerId}")]
        public async Task<IActionResult> DeleteOrganizer([FromRoute] Guid organizerId)
        {
            await _organizerService.DeleteOrganizer(organizerId);
            return Ok();
        }
    }

}
