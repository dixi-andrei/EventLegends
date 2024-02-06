using EventLegends.Models.DTOs;
using EventLegends.Services.SponsorService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SponsorsController : ControllerBase
    {
        private readonly ISponsorService _sponsorService;

        public SponsorsController(ISponsorService sponsorService)
        {
            _sponsorService = sponsorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSponsors()
        {
            var sponsors = await _sponsorService.GetAllSponsors();
            return Ok(sponsors);
        }

        [HttpGet("{sponsorId}")]
        public async Task<IActionResult> GetSponsorById([FromRoute] Guid sponsorId)
        {
            var sponsor = await _sponsorService.GetSponsorById(sponsorId);

            if (sponsor == null)
            {
                return NotFound();
            }

            return Ok(sponsor);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSponsor([FromBody] SponsorDTO sponsorDto)
        {
            await _sponsorService.CreateSponsor(sponsorDto);
            return Ok();
        }

        [HttpPut("{sponsorId}")]
        public async Task<IActionResult> UpdateSponsor([FromRoute] Guid sponsorId, [FromBody] SponsorDTO sponsorDto)
        {
            await _sponsorService.UpdateSponsor(sponsorId, sponsorDto);
            return Ok();
        }

        [HttpDelete("{sponsorId}")]
        public async Task<IActionResult> DeleteSponsor([FromRoute] Guid sponsorId)
        {
            await _sponsorService.DeleteSponsor(sponsorId);
            return Ok();
        }
    }
}
