using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.CategoryRepository;
using EventLegends.Repositories.EventRepository;

namespace EventLegends.Services.EventService
{
    public class EventService : IEventService
    {

        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
       
        public async Task<List<EventDto>> GetAllEvents()
        {
            var events = await _eventRepository.GetAllAsync();
            return _mapper.Map<List<EventDto>>(events);

        }

        public async Task<EventDto> GetEventById(Guid eventId)
        {
            var events = await _eventRepository.FindByIdAsync(eventId);
            return _mapper.Map<EventDto>(events);
        }

        public async Task CreateEvent(EventDto eventDto)
        {
            var eventEntity = _mapper.Map<Event>(eventDto);
            _eventRepository.Create(eventEntity);
            await _eventRepository.SaveAsync();
        }

        public async Task UpdateEvent(Guid eventId, EventDto eventDto)
        {
            var existingEvent = await _eventRepository.FindByIdAsync(eventId);
            if (existingEvent == null)
            {
                throw new InvalidOperationException($"Eventul cu ID-ul {eventId} nu există.");
               
            }

            _mapper.Map(eventDto, existingEvent);
            _eventRepository.Update(existingEvent);
            await _eventRepository.SaveAsync();
        }

        public async Task DeleteEvent(Guid eventId)
        {
            var eventEntity = await _eventRepository.FindByIdAsync(eventId);
            if (eventEntity != null)
            {
                _eventRepository.Delete(eventEntity);
                await _eventRepository.SaveAsync();
            }
        }
    }
}
