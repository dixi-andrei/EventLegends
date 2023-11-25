using EventLegends.Models.DTOs;

namespace EventLegends.Services.EventCategoriesService
{
    public interface IEventCategoriesService
    {
        Task<List<EventCategoriesDto>> GetAllEventCategories();
        Task<EventCategoriesDto> GetEventCategoryById(Guid eventCategoryId);
        Task CreateEventCategory(EventCategoriesDto eventCategoryDto);
        Task UpdateEventCategory(Guid eventCategoryId, EventCategoriesDto eventCategoryDto);
        Task DeleteEventCategory(Guid eventCategoryId);
    }
}
