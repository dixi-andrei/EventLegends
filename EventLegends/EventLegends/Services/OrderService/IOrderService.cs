using EventLegends.Models.DTOs;

namespace EventLegends.Services.OrderService
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllOrders();
        Task<OrderDto> GetOrderById(Guid orderId);
      
        Task CreateOrder(OrderDto orderDto);
        Task DeleteOrder(Guid orderId);
        Task UpdateOrder(Guid orderId,OrderDto orderDto);
    }
}
