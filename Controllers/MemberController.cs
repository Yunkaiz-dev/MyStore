using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Member;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _memberService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CreateMemberDto createMemberDto)
        {
            var result = _memberService.Create(createMemberDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateMemberDto updateMemberDto)
        {
            var result = _memberService.Update(id, updateMemberDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _memberService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _memberService.GetById(id);
            return Ok(result);
        }
    }
}
