using MyStore.Dtos.Member;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface IMemberRepository
    {
        List<Member> Get();

        Member GetById(int id);

        Member Create(CreateMemberDto createMemberDto);

        Member Update(int id, UpdateMemberDto updateMemberDto);

        void Delete(int id);
    }
}
