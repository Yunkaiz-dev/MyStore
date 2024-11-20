using MyStore.Dtos.Order;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface IOrderService
    {
        List<OrderDto> Get();

        Order GetById(int id);

        OrderDto Create(CreateOrderDto createOrderDto);

        OrderDto Update(int id, UpdateOrderDto updateOrderDto);

        void Delete(int id);
    }
}
