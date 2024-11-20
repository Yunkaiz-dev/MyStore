
using MyStore.Dtos.Order;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface IOrderRepository
    {
        List<Order> Get();

        Order GetById(int id);

        Order Create(CreateOrderDto createOrderDto);

        Order Update(int id, UpdateOrderDto updateOrderDto);

        void Delete(int id);
    }
}
