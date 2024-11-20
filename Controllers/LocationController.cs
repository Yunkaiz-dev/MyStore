using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Location;
using MyStore.Models;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _locationService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreateLocationDto createLocationDto)
        {
            var result = _locationService.Create(createLocationDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateLocationDto updateLocationDto)
        {
            var result = _locationService.Update(id, updateLocationDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _locationService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _locationService.GetById(id);
            return Ok(result);
        }

    }
}
