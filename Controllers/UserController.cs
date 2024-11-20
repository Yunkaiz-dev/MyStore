using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.User;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _userService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreateUserDto createUserDto)
        {
            var result = _userService.Create(createUserDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateUserDto updateUserDto)
        {
            var result = _userService.Update(id, updateUserDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _userService.GetById(id);
            return Ok(result);
        }

    }
}
