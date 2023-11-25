using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;
using EventLegends.Repositories.EventTicketsRepository;

namespace EventLegends.Services.EventTicketsService
{
    public class EventTicketsService : IEventTicketsService
    {
        private readonly IEventTicketsRepository _eventTicketsRepository;
        private readonly IMapper _mapper;

        public EventTicketsService(IEventTicketsRepository eventTicketsRepository, IMapper mapper)
        {
            _eventTicketsRepository = eventTicketsRepository;
            _mapper = mapper;
        }

        public async Task<List<EventTicketsDto>> GetAllEventTickets()
        {
            var eventTicketsList = await _eventTicketsRepository.GetAllAsync();
            return _mapper.Map<List<EventTicketsDto>>(eventTicketsList);
        }

        public EventTicketsDto GetEventTicketById(Guid eventTicketId)
        {
            var eventTicket = _eventTicketsRepository.FindById(eventTicketId);
            return _mapper.Map<EventTicketsDto>(eventTicket);
        }

        public async Task CreateEventTicket(EventTicketsDto eventTicketDto)
        {
            var eventTicketEntity = _mapper.Map<EventTickets>(eventTicketDto);
            _eventTicketsRepository.Create(eventTicketEntity);
            await _eventTicketsRepository.SaveAsync();
        }

        public async Task UpdateEventTicket(Guid eventTicketId, EventTicketsDto eventTicketDto)
        {
            var existingEventTicket = await _eventTicketsRepository.FindByIdAsync(eventTicketId);
            if (existingEventTicket == null)
            {
                throw new InvalidOperationException($"Nu exista EventTicket cu id-ul {eventTicketId}");
            }

            _mapper.Map(eventTicketDto, existingEventTicket);
            _eventTicketsRepository.Update(existingEventTicket);
            await _eventTicketsRepository.SaveAsync();
        }

        public async Task DeleteEventTicket(Guid eventTicketId)
        {
            var eventTicketToDelete = await _eventTicketsRepository.FindByIdAsync(eventTicketId);
            if (eventTicketToDelete != null)
            {
                _eventTicketsRepository.Delete(eventTicketToDelete);
                await _eventTicketsRepository.SaveAsync();
            }
        }
    }
}
