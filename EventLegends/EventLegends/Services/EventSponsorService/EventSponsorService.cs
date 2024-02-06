using AutoMapper;
using EventLegends.Models.Base;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.EventSponsorRepository;

namespace EventLegends.Services.EventSponsorService
{
    public class EventSponsorService : IEventSponsorService
    {
        private readonly IEventSponsorRepository _eventSponsorRepository;
        private readonly IMapper _mapper;

        public EventSponsorService(IEventSponsorRepository eventSponsorRepository, IMapper mapper)
        {
            _eventSponsorRepository = eventSponsorRepository;
            _mapper = mapper;
        }

        public async Task<List<EventSponsorDto>> GetAllEventSponsors()
        {
            var eventSponsors = await _eventSponsorRepository.GetAllAsync();
            return _mapper.Map<List<EventSponsorDto>>(eventSponsors);
        }

        public async Task<EventSponsorDto> GetEventSponsorById(Guid eventSponsorId)
        {
            var eventSponsor = await _eventSponsorRepository.FindByIdAsync(eventSponsorId);
            return _mapper.Map<EventSponsorDto>(eventSponsor);
        }

        public async Task CreateEventSponsor(EventSponsorDto eventSponsorDto)
        {
            var eventSponsor = _mapper.Map<EventSponsor>(eventSponsorDto);
            _eventSponsorRepository.Create(eventSponsor);
            await _eventSponsorRepository.SaveAsync();
        }

        public async Task UpdateEventSponsor(Guid eventSponsorId, EventSponsorDto eventSponsorDto)
        {
            var existingEventSponsor = await _eventSponsorRepository.FindByIdAsync(eventSponsorId);
            if (existingEventSponsor == null)
            {
                throw new InvalidOperationException($"Evenimentul-Sponsor cu ID-ul {eventSponsorId} nu există.");
            }

            _mapper.Map(eventSponsorDto, existingEventSponsor);
            _eventSponsorRepository.Update(existingEventSponsor);
            await _eventSponsorRepository.SaveAsync();
        }

        public async Task DeleteEventSponsor(Guid eventSponsorId)
        {
            var eventSponsor = await _eventSponsorRepository.FindByIdAsync(eventSponsorId);
            if (eventSponsor != null)
            {
                _eventSponsorRepository.Delete(eventSponsor);
                await _eventSponsorRepository.SaveAsync();
            }
        }
    }

}
