using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Member;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class MemberService:IMemberService
    {
        private readonly IMemberRepository _memberService;

        public MemberService(IMemberRepository memberService)
        {
            _memberService = memberService;
        }

        public MemberDto Create(CreateMemberDto createMemberDto)
        {
            var member = _memberService.Create(createMemberDto);
            var memberDto = new MemberDto
            {
                // Mapeo de propiedades por completar
                MemberId = member.MemberId,
                UserId = member.UserId,
                MemberPassword = member.MemberPassword,
                CreatedDateTime = member.CreatedDateTime,
                ModifiedDateTime = member.ModifiedDateTime
            };
            return memberDto;
        }

        public void Delete(int id)
        {
            _memberService.Delete(id);
        }

        public List<MemberDto> Get()
        {
            var members = _memberService.Get();
            var memberDtos = new List<MemberDto>();

            foreach (Member member in members)
            {
                var dto = new MemberDto
                {
                    // Mapeo de propiedades por completar
                    MemberId= member.MemberId,
                    UserId= member.UserId,
                    MemberPassword = member.MemberPassword,
                    CreatedDateTime = member.CreatedDateTime,
                    ModifiedDateTime = member.ModifiedDateTime
                };
                memberDtos.Add(dto);
            }
            return memberDtos;
        }

        public Member GetById(int id)
        {
            return _memberService.GetById(id);
        }

        public MemberDto Update(int id, UpdateMemberDto updateMemberDto)
        {
            var member = _memberService.Update(id, updateMemberDto);
            var memberDto = new MemberDto
            {
                // Mapeo de propiedades por completar
                MemberId = member.MemberId,
                UserId = member.UserId,
                MemberPassword = member.MemberPassword,
                CreatedDateTime = member.CreatedDateTime,
                ModifiedDateTime = member.ModifiedDateTime
            };
            return memberDto;
        }
    }
}
