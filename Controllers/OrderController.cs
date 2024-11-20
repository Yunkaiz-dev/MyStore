using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Order;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _orderService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderDto createOrderDto)
        {
            var result = _orderService.Create(createOrderDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateOrderDto updateOrderDto)
        {
            var result = _orderService.Update(id, updateOrderDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _orderService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _orderService.GetById(id);
            return Ok(result);
        }

    }
}
