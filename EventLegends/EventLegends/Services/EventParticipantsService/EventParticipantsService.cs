using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;
using EventLegends.Repositories.EventParticipantsRepository;

namespace EventLegends.Services.EventParticipantsService
{
    public class EventParticipantsService : IEventParticipantsService
    {
        private readonly IEventParticipantsRepository _eventParticipantsRepository;
        private readonly IMapper _mapper;

        public EventParticipantsService(IEventParticipantsRepository eventParticipantsRepository, IMapper mapper)
        {
            _eventParticipantsRepository = eventParticipantsRepository;
            _mapper = mapper;
        }

        public async Task<List<EventParticipantsDto>> GetAllEventParticipants()
        {
            var eventParticipantsList = await _eventParticipantsRepository.GetAllAsync();
            return _mapper.Map<List<EventParticipantsDto>>(eventParticipantsList);
        }

        public EventParticipantsDto GetEventParticipantById(Guid eventParticipantId)
        {
            var eventParticipant = _eventParticipantsRepository.FindById(eventParticipantId);
            return _mapper.Map<EventParticipantsDto>(eventParticipant);
        }

        public async Task CreateEventParticipant(EventParticipantsDto eventParticipantDto)
        {
            var eventParticipantEntity = _mapper.Map<EventParticipants>(eventParticipantDto);
            _eventParticipantsRepository.Create(eventParticipantEntity);
            await _eventParticipantsRepository.SaveAsync();
        }

        public async Task UpdateEventParticipant(Guid eventParticipantId, EventParticipantsDto eventParticipantDto)
        {
            var existingEventParticipant = await _eventParticipantsRepository.FindByIdAsync(eventParticipantId);
            if (existingEventParticipant == null)
            {
                throw new InvalidOperationException($"Nu exista EventParticipant cu id-ul {eventParticipantId}");
            }

            _mapper.Map(eventParticipantDto, existingEventParticipant);
            _eventParticipantsRepository.Update(existingEventParticipant);
            await _eventParticipantsRepository.SaveAsync();
        }

        public async Task DeleteEventParticipant(Guid eventParticipantId)
        {
            var eventParticipantToDelete = await _eventParticipantsRepository.FindByIdAsync(eventParticipantId);
            if (eventParticipantToDelete != null)
            {
                _eventParticipantsRepository.Delete(eventParticipantToDelete);
                await _eventParticipantsRepository.SaveAsync();
            }
        }
    }
}
