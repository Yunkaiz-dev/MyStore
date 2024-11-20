
using MyStore.Dtos.OrderDetail;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> Get();

        OrderDetail GetById(int id);

        OrderDetail Create(CreateOrderDetailDto createOrderDetailDto);

        OrderDetail Update(int id, UpdateOrderDetailDto updateOrderDetailDto);

        void Delete(int id);
    }
}
