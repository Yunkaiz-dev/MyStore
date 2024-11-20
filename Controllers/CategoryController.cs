using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Category;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _categoryService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDto createCategoryDto)
        {
            var result = _categoryService.Create(createCategoryDto);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,UpdateCategoryDto updateCategoryDto)
        {
            var result = _categoryService.Update(id, updateCategoryDto);
            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _categoryService.GetById(id);
            return Ok(result);
        }
        
    }
}
