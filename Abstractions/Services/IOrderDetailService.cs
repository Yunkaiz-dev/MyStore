using MyStore.Dtos.OrderDetail;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface IOrderDetailService
    {
        List<OrderDetailDto> Get();

        OrderDetail GetById(int id);

        OrderDetailDto Create(CreateOrderDetailDto createOrderDetailDto);

        OrderDetailDto Update(int id, UpdateOrderDetailDto updateOrderDetailDto);

        void Delete(int id);
    }
}
