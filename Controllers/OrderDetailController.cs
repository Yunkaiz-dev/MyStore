using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.OrderDetail;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _orderDetailService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderDetailDto createOrderDetailDto)
        {
            var result = _orderDetailService.Create(createOrderDetailDto);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(int id, UpdateOrderDetailDto updateOrderDetailDto)
        {
            var result = _orderDetailService.Update(id, updateOrderDetailDto);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _orderDetailService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _orderDetailService.GetById(id);
            return Ok(result);
        }
    }
}
