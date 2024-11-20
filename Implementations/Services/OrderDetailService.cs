using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.OrderDetail;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class OrderDetailService: IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailService;

        public OrderDetailService(IOrderDetailRepository orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        public OrderDetailDto Create(CreateOrderDetailDto createOrderDetailDto)
        {
            var orderDetail = _orderDetailService.Create(createOrderDetailDto);
            var orderDetailDto = new OrderDetailDto
            {
                // Mapeo de propiedades por completar
                OrderDetailId = orderDetail.OrderDetailId,
                ProductId = orderDetail.ProductId,
                OrderId = orderDetail.OrderId,
                OrderDetailQuantity = orderDetail.OrderDetailQuantity,
                CreatedDateTime = orderDetail.CreatedDateTime,
                ModifiedDateTime = orderDetail.ModifiedDateTime
            };
            return orderDetailDto;
        }

        public void Delete(int id)
        {
            _orderDetailService.Delete(id);
        }

        public List<OrderDetailDto> Get()
        {
            var orderDetails = _orderDetailService.Get();
            var orderDetailDtos = new List<OrderDetailDto>();

            foreach (OrderDetail orderDetail in orderDetails)
            {
                var dto = new OrderDetailDto
                {
                    // Mapeo de propiedades por completar
                    OrderDetailId = orderDetail.OrderDetailId,
                    ProductId = orderDetail.ProductId,
                    OrderId = orderDetail.OrderId,
                    OrderDetailQuantity = orderDetail.OrderDetailQuantity,
                    CreatedDateTime = orderDetail.CreatedDateTime,
                    ModifiedDateTime = orderDetail.ModifiedDateTime
                };
                orderDetailDtos.Add(dto);
            }
            return orderDetailDtos;
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailService.GetById(id);
        }

        public OrderDetailDto Update(int id, UpdateOrderDetailDto updateOrderDetailDto)
        {
            var orderDetail = _orderDetailService.Update(id, updateOrderDetailDto);
            var orderDetailDto = new OrderDetailDto
            {
                // Mapeo de propiedades por completar
                OrderDetailId = orderDetail.OrderDetailId,
                ProductId = orderDetail.ProductId,
                OrderId = orderDetail.OrderId,
                OrderDetailQuantity = orderDetail.OrderDetailQuantity,
                CreatedDateTime = orderDetail.CreatedDateTime,
                ModifiedDateTime = orderDetail.ModifiedDateTime
            };
            return orderDetailDto;
        }

    }
}
