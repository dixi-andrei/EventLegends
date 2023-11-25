using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;
using EventLegends.Repositories.EventCategoriesRepository;

namespace EventLegends.Services.EventCategoriesService
{
    public class EventCategoriesService : IEventCategoriesService
    {
        private readonly IEventCategoriesRepository _eventCategoriesRepository;
        private readonly IMapper _mapper;

        public EventCategoriesService(IEventCategoriesRepository eventCategoriesRepository, IMapper mapper)
        {
            _eventCategoriesRepository = eventCategoriesRepository;
            _mapper = mapper;
        }

        public async Task<List<EventCategoriesDto>> GetAllEventCategories()
        {
            var eventCategoriesList = await _eventCategoriesRepository.GetAllAsync();
            return _mapper.Map<List<EventCategoriesDto>>(eventCategoriesList);
        }

        public async Task<EventCategoriesDto> GetEventCategoryById(Guid eventCategoryId)
        {
            var eventCategory = await _eventCategoriesRepository.FindByIdAsync(eventCategoryId);
            return _mapper.Map<EventCategoriesDto>(eventCategory);
        }

        public async Task CreateEventCategory(EventCategoriesDto eventCategoryDto)
        {
            var eventCategoryEntity = _mapper.Map<EventCategories>(eventCategoryDto);
            _eventCategoriesRepository.Create(eventCategoryEntity);
            await _eventCategoriesRepository.SaveAsync();
        }

        public async Task UpdateEventCategory(Guid eventCategoryId, EventCategoriesDto eventCategoryDto)
        {
            var existingEventCategory = await _eventCategoriesRepository.FindByIdAsync(eventCategoryId);
            if (existingEventCategory == null)
            {
                throw new InvalidOperationException($"Nu exista EventCategories cu id-ul {eventCategoryId}!");
            }

            _mapper.Map(eventCategoryDto, existingEventCategory);
            _eventCategoriesRepository.Update(existingEventCategory);
            await _eventCategoriesRepository.SaveAsync();
        }

        public async Task DeleteEventCategory(Guid eventCategoryId)
        {
            var eventCategoryToDelete = await _eventCategoriesRepository.FindByIdAsync(eventCategoryId);
            if (eventCategoryToDelete != null)
            {
                _eventCategoriesRepository.Delete(eventCategoryToDelete);
                await _eventCategoriesRepository.SaveAsync();
            }
        }
    }
}
