using MyStore.Abstractions.Repositories;
using MyStore.Dtos.Order;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly StoreDbContext _dbContext;

        public OrderRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Order Create(CreateOrderDto createOrderDto)
        {
            var result = new Order()
            {
                // Mapeo por completar
                UserId = createOrderDto.UserId,
                OrderTotal = createOrderDto.OrderTotal,
                CreatedDateTime = DateTime.Now,
                ModifiedDateTime = DateTime.Now,
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public Order Update(int id, UpdateOrderDto updateOrderDto)
        {
            var orderExist = GetById(id);

            // Mapeo por completar
            orderExist.UserId = updateOrderDto.UserId ?? orderExist.OrderId;
            orderExist.OrderTotal = updateOrderDto.OrderTotal ?? orderExist.OrderTotal;
            orderExist.CreatedDateTime = updateOrderDto?.CreatedDateTime ?? DateTime.Now;
            orderExist.ModifiedDateTime = updateOrderDto?.ModifiedDateTime ?? DateTime.Now;


            _dbContext.Update(orderExist);
            _dbContext.SaveChanges();

            var updatedOrder = GetById(id);
            return updatedOrder;
        }

        public void Delete(int id)
        {
            Order order = GetById(id);
            _dbContext.Remove(order);
            _dbContext.SaveChanges();
        }

        public List<Order> Get()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _dbContext.Orders.Where(o => o.OrderId == id).FirstOrDefault();
        }
    }
}
