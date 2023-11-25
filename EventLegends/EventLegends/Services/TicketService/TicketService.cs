using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;
using EventLegends.Repositories.TicketRepository;

namespace EventLegends.Services.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<List<TicketDto>> GetAllTickets()
        {
            var ticketList = await _ticketRepository.GetAllAsync();
            return _mapper.Map<List<TicketDto>>(ticketList);
        }

        public async Task<TicketDto> GetTicketById(Guid ticketId)
        {
            var ticket = await _ticketRepository.FindByIdAsync(ticketId);
            return _mapper.Map<TicketDto>(ticket);
        }

        public async Task CreateTicket(TicketDto ticketDto)
        {
            var ticketEntity = _mapper.Map<Ticket>(ticketDto);
            _ticketRepository.Create(ticketEntity);
            await _ticketRepository.SaveAsync();
        }

        public async Task UpdateTicket(Guid ticketId, TicketDto ticketDto)
        {
            var existingTicket = await _ticketRepository.FindByIdAsync(ticketId);
            if (existingTicket == null)
            {
                throw new InvalidOperationException($"Ticket-ul cu id-ul {ticketId} nu exista!");
           
            }

            _mapper.Map(ticketDto, existingTicket);
            _ticketRepository.Update(existingTicket);
            await _ticketRepository.SaveAsync();
        }

        public async Task DeleteTicket(Guid ticketId)
        {
            var ticketToDelete = await _ticketRepository.FindByIdAsync(ticketId);
            if (ticketToDelete != null)
            {
                _ticketRepository.Delete(ticketToDelete);
                await _ticketRepository.SaveAsync();
            }
        }
    }
}
