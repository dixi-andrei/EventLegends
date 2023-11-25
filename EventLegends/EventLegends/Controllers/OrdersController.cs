using EventLegends.Models.DTOs;
using EventLegends.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrders();
            return Ok(orders);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderById([FromRoute]Guid orderId)
        {
            var order = await _orderService.GetOrderById(orderId);
            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDto orderDto)
        {
            await _orderService.CreateOrder(orderDto);
            return Ok();
        }

        [HttpPut("{orderId}")]
        public async Task<IActionResult> UpdateOrder([FromRoute]Guid orderId, [FromBody] OrderDto orderDto)
        {
            await _orderService.UpdateOrder(orderId, orderDto);
            return NoContent();
        }

        [HttpDelete("{orderId}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid orderId)
        {
            await _orderService.DeleteOrder(orderId);
            return NoContent();
        }
    }
}
