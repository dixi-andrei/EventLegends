using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.EventParticipantRepository;

namespace EventLegends.Services.EventParticipantService
{
    public class EventParticipantService : IEventParticipantService
    {
        private readonly IEventParticipantRepository _eventParticipantRepository;
        private readonly Mapper _mapper;

        public EventParticipantService(IEventParticipantRepository eventParticipantRepository, Mapper mapper)
        {
            _eventParticipantRepository = eventParticipantRepository;
            _mapper = mapper;
        }

        public async Task CreateEventParticipant(EventParticipantDto eventParticipant)
        {
            var eventpart = _mapper.Map<EventParticipant>(eventParticipant);
            if (eventpart != null)
            {
                _eventParticipantRepository.Create(eventpart);
                await _eventParticipantRepository.SaveAsync();
            }
        }

        public async Task DeleteEventParticipant(Guid id)
        {
            var eventpart = await _eventParticipantRepository.FindByIdAsync(id);
            if (eventpart != null)
            {
                _eventParticipantRepository.Delete(eventpart);
                await _eventParticipantRepository.SaveAsync();
            }
        }

        public async Task<List<EventParticipantDto>> GetAllEventParticipants()
        {
            var eventparts = await _eventParticipantRepository.GetAllAsync();
            return _mapper.Map<List<EventParticipantDto>>(eventparts);
        }

        public async Task<EventParticipantDto> GetEventParticipantById(Guid id)
        {
            var eventpart = await _eventParticipantRepository.FindByIdAsync(id);
            return _mapper.Map<EventParticipantDto>(eventpart);
        }

        public async Task UpdateEventParticipant(Guid id, EventParticipantDto eventParticipant)
        {
            var existpart = await _eventParticipantRepository.FindByIdAsync(id);
            if (existpart == null)
            {
                throw new InvalidOperationException($"EventParticipant-ul cu ID-ul {id} nu există.");
                
            }

            _mapper.Map(eventParticipant, existpart);

            _eventParticipantRepository.Update(existpart);
            await _eventParticipantRepository.SaveAsync();

        }
    }
}
