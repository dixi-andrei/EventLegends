using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.OrderRepository;

namespace EventLegends.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Mapper _mapper;

        public OrderService(IOrderRepository orderRepository, Mapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task CreateOrder(OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            _orderRepository.Create(order);
            await _orderRepository.SaveAsync();

        }

        public async Task DeleteOrder(Guid orderId)
        {
            var order = await _orderRepository.FindByIdAsync(orderId);
            if (order != null)
            {
                _orderRepository.Delete(order);
                await _orderRepository.SaveAsync();
            }
        }

        public async Task<List<OrderDto>> GetAllOrders()
        {
            var orders = await _orderRepository.GetAllAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }

        public async Task<OrderDto> GetOrderById(Guid orderId)
        {
            var order = await _orderRepository.FindByIdAsync(orderId);
            return _mapper.Map<OrderDto>(order);
        }

        public async Task UpdateOrder(Guid orderId,OrderDto orderDto)
        {
            var existingOrder = _orderRepository.FindById(orderDto.Id);
            if (existingOrder == null)
            {
                throw new InvalidOperationException($"Orderul cu id-ul {orderId} nu exista");
            }

            _mapper.Map(orderDto, existingOrder);
            _orderRepository.Update(existingOrder);
            await _orderRepository.SaveAsync();

        }
    }
}
