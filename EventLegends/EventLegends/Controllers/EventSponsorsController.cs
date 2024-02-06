using EventLegends.Models.DTOs;
using EventLegends.Services.EventSponsorService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventSponsorsController : ControllerBase
    {
        private readonly IEventSponsorService _eventSponsorService;

        public EventSponsorsController(IEventSponsorService eventSponsorService)
        {
            _eventSponsorService = eventSponsorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEventSponsors()
        {
            var eventSponsors = await _eventSponsorService.GetAllEventSponsors();
            return Ok(eventSponsors);
        }

        [HttpGet("{eventSponsorId}")]
        public async Task<IActionResult> GetEventSponsorById([FromRoute] Guid eventSponsorId)
        {
            var eventSponsor = await _eventSponsorService.GetEventSponsorById(eventSponsorId);

            if (eventSponsor == null)
            {
                return NotFound();
            }

            return Ok(eventSponsor);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEventSponsor([FromBody] EventSponsorDto eventSponsorDto)
        {
            await _eventSponsorService.CreateEventSponsor(eventSponsorDto);
            return Ok();
        }

        [HttpPut("{eventSponsorId}")]
        public async Task<IActionResult> UpdateEventSponsor([FromRoute] Guid eventSponsorId, [FromBody] EventSponsorDto eventSponsorDto)
        {
            await _eventSponsorService.UpdateEventSponsor(eventSponsorId, eventSponsorDto);
            return Ok();
        }

        [HttpDelete("{eventSponsorId}")]
        public async Task<IActionResult> DeleteEventSponsor([FromRoute] Guid eventSponsorId)
        {
            await _eventSponsorService.DeleteEventSponsor(eventSponsorId);
            return Ok();
        }
    }
}
