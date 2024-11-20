using MyStore.Dtos.Member;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface IMemberService
    {
        List<MemberDto> Get();

        Member GetById(int id);

        MemberDto Create(CreateMemberDto createMemberDto);

        MemberDto Update(int id, UpdateMemberDto updateMemberDto);

        void Delete(int id);
    }
}
