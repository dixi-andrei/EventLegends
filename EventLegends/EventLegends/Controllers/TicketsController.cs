using EventLegends.Models.DTOs;
using EventLegends.Services.TicketService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTickets()
        {
            var tickets = await _ticketService.GetAllTickets();
            return Ok(tickets);
        }

        [HttpGet("{ticketId}")]
        public async Task<IActionResult> GetTicketById([FromRoute] Guid ticketId)
        {
            var ticket = await _ticketService.GetTicketById(ticketId);

            if (ticket == null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket([FromBody] TicketDto ticketDto)
        {
            await _ticketService.CreateTicket(ticketDto);
            return Ok();
        }

        [HttpPut("{ticketId}")]
        public async Task<IActionResult> UpdateTicket([FromRoute] Guid ticketId, [FromBody] TicketDto ticketDto)
        {
            await _ticketService.UpdateTicket(ticketId, ticketDto);
            return Ok();
        }

        [HttpDelete("{ticketId}")]
        public async Task<IActionResult> DeleteTicket([FromRoute] Guid ticketId)
        {
            await _ticketService.DeleteTicket(ticketId);
            return Ok();
        }
    }

}
