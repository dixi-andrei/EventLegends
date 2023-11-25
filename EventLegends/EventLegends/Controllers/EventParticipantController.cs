using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Services.EventParticipantService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventParticipantController : Controller
    {
        private readonly IEventParticipantService eventParticipantService;

        public EventParticipantController(IEventParticipantService eventParticipantService)
        {
            this.eventParticipantService = eventParticipantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEventParticipants()
        {
            var eventparts = await eventParticipantService.GetAllEventParticipants();
            return Ok(eventparts);
        }

        [HttpGet("{eventparticipantId}")]
        public async Task<IActionResult> GetEventParticipantbyId([FromRoute]Guid id)
        {
            var eventpart = await eventParticipantService.GetEventParticipantById(id);
            if (eventpart == null)
            {
                return NotFound();
            }

            return Ok(eventpart);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEventParticipant([FromBody]EventParticipantDto eventParticipantDto)
        {
            await eventParticipantService.CreateEventParticipant(eventParticipantDto);
            return Ok();
        }

        [HttpDelete("{eventparticipantId}")]
        public async Task<IActionResult> DeleteEventParticipant([FromRoute] Guid id)
        {
            await eventParticipantService.DeleteEventParticipant(id);
            return Ok();
        }

        [HttpPut("{eventparticipantId}")]
        public async Task<IActionResult> UpdateEventParticipant([FromRoute] Guid id,[FromBody]EventParticipantDto eventParticipantDto)
        {
            await eventParticipantService.UpdateEventParticipant(id,eventParticipantDto);
            return Ok();
        }


    }
}
