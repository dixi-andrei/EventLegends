using EventLegends.Models.DTOs;
using EventLegends.Services.VenueService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenuesController : ControllerBase
    {
        private readonly IVenueService _venueService;

        public VenuesController(IVenueService venueService)
        {
            _venueService = venueService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVenues()
        {
            var venues = await _venueService.GetAllVenues();
            return Ok(venues);
        }

        [HttpGet("{venueId}")]
        public async Task<IActionResult> GetVenueById([FromRoute] Guid venueId)
        {
            var venue = await _venueService.GetVenueById(venueId);

            if (venue == null)
            {
                return NotFound();
            }

            return Ok(venue);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVenue([FromBody] VenueDto venueDto)
        {
            await _venueService.CreateVenue(venueDto);
            return Ok();
        }

        [HttpPut("{venueId}")]
        public async Task<IActionResult> UpdateVenue([FromRoute] Guid venueId, [FromBody] VenueDto venueDto)
        {
            await _venueService.UpdateVenue(venueId, venueDto);
            return Ok();
        }

        [HttpDelete("{venueId}")]
        public async Task<IActionResult> DeleteVenue([FromRoute] Guid venueId)
        {
            await _venueService.DeleteVenue(venueId);
            return Ok();
        }
    }

}
