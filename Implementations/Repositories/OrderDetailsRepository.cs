using MyStore.Abstractions.Repositories;
using MyStore.Dtos.OrderDetail;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class OrderDetailsRepository:IOrderDetailRepository
    {
        private readonly StoreDbContext _dbContext;

        public OrderDetailsRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public OrderDetail Create(CreateOrderDetailDto createOrderDetailDto)
        {
            var result = new OrderDetail()
            {
                // Mapeo por completar
                ProductId = createOrderDetailDto.ProductId,
                OrderId = createOrderDetailDto.OrderId,
                OrderDetailQuantity = createOrderDetailDto.OrderDetailQuantity,
                CreatedDateTime = createOrderDetailDto.CreatedDateTime,
                ModifiedDateTime = createOrderDetailDto.ModifiedDateTime,
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public OrderDetail Update(int id, UpdateOrderDetailDto updateOrderDetailsDto)
        {
            var orderDetailsExist = GetById(id);

            // Mapeo por completar
            orderDetailsExist.ProductId = updateOrderDetailsDto.ProductId ?? orderDetailsExist.ProductId;
            orderDetailsExist.OrderId = updateOrderDetailsDto?.OrderId ?? orderDetailsExist.OrderId;
            orderDetailsExist.OrderDetailQuantity = updateOrderDetailsDto?.OrderDetailQuantity ?? orderDetailsExist.OrderDetailQuantity;
            orderDetailsExist.CreatedDateTime = updateOrderDetailsDto?.CreatedDateTime ?? orderDetailsExist.CreatedDateTime;
            orderDetailsExist.ModifiedDateTime = updateOrderDetailsDto?.ModifiedDateTime ?? orderDetailsExist.ModifiedDateTime;

            _dbContext.Update(orderDetailsExist);
            _dbContext.SaveChanges();

            var updatedOrderDetails = GetById(id);
            return updatedOrderDetails;
        }

        public void Delete(int id)
        {
            OrderDetail orderDetail = GetById(id);
            _dbContext.Remove(orderDetail);
            _dbContext.SaveChanges();
        }

        public List<OrderDetail> Get()
        {
            return _dbContext.OrderDetails.ToList();
        }

        public OrderDetail GetById(int id)
        {
            return _dbContext.OrderDetails.Where(o => o.OrderDetailId == id).FirstOrDefault();
        }

    }
}
