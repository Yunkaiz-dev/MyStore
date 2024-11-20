using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Order;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderService;

        public OrderService(IOrderRepository orderService)
        {
            _orderService = orderService;
        }

        public OrderDto Create(CreateOrderDto createOrderDto)
        {
            var order = _orderService.Create(createOrderDto);
            var orderDto = new OrderDto
            {
                // Mapeo de propiedades por completar
                OrderId = order.OrderId,
                UserId = order.UserId,
                OrderTotal = order.OrderTotal,
                CreatedDateTime = order.CreatedDateTime,
                ModifiedDateTime = order.ModifiedDateTime
            };
            return orderDto;
        }

        public void Delete(int id)
        {
            _orderService.Delete(id);
        }

        public List<OrderDto> Get()
        {
            var orders = _orderService.Get();
            var orderDtos = new List<OrderDto>();

            foreach (Order order in orders)
            {
                var dto = new OrderDto
                {
                    // Mapeo de propiedades por completar
                    OrderId = order.OrderId,
                    UserId = order.UserId,
                    OrderTotal = order.OrderTotal,
                    CreatedDateTime = order.CreatedDateTime,
                    ModifiedDateTime = order.ModifiedDateTime
                };
                orderDtos.Add(dto);
            }
            return orderDtos;
        }

        public Order GetById(int id)
        {
            return _orderService.GetById(id);
        }

        public OrderDto Update(int id, UpdateOrderDto updateOrderDto)
        {
            var order = _orderService.Update(id, updateOrderDto);
            var orderDto = new OrderDto
            {
                // Mapeo de propiedades por completar
                OrderId = order.OrderId,
                UserId = order.UserId,
                OrderTotal = order.OrderTotal,
                CreatedDateTime = order.CreatedDateTime,
                ModifiedDateTime = order.ModifiedDateTime
            };
            return orderDto;
        }

    }
}
