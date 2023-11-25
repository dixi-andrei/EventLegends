using EventLegends.Models.DTOs;
using EventLegends.Services.EventCategoriesService;
using EventLegends.Services.EventTicketsService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    
    //[Route("api/[controller]")]
    //[ApiController]
    public class EventCategoriesController : Controller
    {
        /*
        private readonly IEventCategoriesService _eventCategoriesService;

        public EventCategoriesController(IEventCategoriesService eventCategoriesService)
        {
            _eventCategoriesService = eventCategoriesService ?? throw new ArgumentNullException(nameof(eventCategoriesService));
        }
        
        [HttpGet]
        public async Task<ActionResult<List<EventCategoriesDto>>> GetAllEventCategories()
        {
            var eventCategories = await _eventCategoriesService.GetAllEventCategories();
            return Ok(eventCategories);
        }
        
        [HttpGet("{eventId}")]
        public async Task<ActionResult<List<EventCategoriesDto>>> GetEventCategoriesByEventId([FromRoute]Guid eventId)
        {
            var eventCategories = await _eventCategoriesService.GetEventCategoryById(eventId);
            return Ok(eventCategories);
        }
        
        [HttpPost]
        public async Task<ActionResult<EventCategoriesDto>> AddEventCategory([FromRoute]EventCategoriesDto eventCategoriesDto)
        {
            var addedEventCategory = await _eventCategoriesService.CreateEventCategory(eventCategoriesDto);
            return Ok(addedEventCategory);
        }

        [HttpDelete("{eventId}/{categoryId}")]
        public async Task<IActionResult> RemoveEventCategory([FromRoute] Guid eventId, Guid categoryId)
        {
            await _eventCategoriesService.DeleteEventCategory(eventId);
            return NoContent();
        }
      */  
    }
}
