using EventLegends.Models.DTOs;
using EventLegends.Services.EventService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : Controller
    {
        private readonly IEventService eventService;

        public EventsController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            var eventEntity = await eventService.GetAllEvents();
            return Ok(eventEntity);
        }
        [HttpGet("{eventId}")]
        public async Task<IActionResult> GetEventById([FromRoute] Guid id) {

            var evententity = await eventService.GetEventById(id);
            if (evententity == null)
            {
                return NotFound();
            }
            return Ok(evententity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] EventDto eventDto)
        {
            await eventService.CreateEvent(eventDto);
            return Ok();
        }

        [HttpPut("{eventId}")]
        public async Task<IActionResult> UpdateEvent([FromRoute] Guid id,[FromBody]EventDto eventDto) {

            await eventService.UpdateEvent(id,eventDto);
            return Ok();
        }

        [HttpDelete("{eventId}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] Guid id)
        {
            await eventService.DeleteEvent(id);
            return Ok();
        }

    }
}
