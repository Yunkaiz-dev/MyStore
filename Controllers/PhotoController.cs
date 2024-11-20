using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Photo;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _photoService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreatePhotoDto createPhotoDto)
        {
            var result = _photoService.Create(createPhotoDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdatePhotoDto updatePhotoDto)
        {
            var result = _photoService.Update(id, updatePhotoDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _photoService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _photoService.GetById(id);
            return Ok(result);
        }

    }
}
