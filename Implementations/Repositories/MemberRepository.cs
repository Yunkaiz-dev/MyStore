using MyStore.Abstractions.Repositories;
using MyStore.Dtos.Location;
using MyStore.Dtos.Member;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class MemberRepository:IMemberRepository
    {
        private readonly StoreDbContext _dbContext;

        public MemberRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Member Create(CreateMemberDto memberDto)
        {
            var result = new Member()
            {
                UserId = memberDto.UserId,
                MemberPassword = memberDto.MemberPassword,
                CreatedDateTime = memberDto.CreatedDateTime,
                ModifiedDateTime = memberDto.ModifiedDateTime,
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public Member Update(int id, UpdateMemberDto memberDto)
        {
            var MemberExist = GetById(id);

            MemberExist.UserId = memberDto.UserId ?? MemberExist.UserId;
            MemberExist.MemberPassword = memberDto.MemberPassword ?? MemberExist.MemberPassword;
            MemberExist.CreatedDateTime = memberDto.CreatedDateTime ?? MemberExist.CreatedDateTime; 
            MemberExist.ModifiedDateTime = memberDto.ModifiedDateTime ?? MemberExist.ModifiedDateTime;
            
            _dbContext.Update(MemberExist);
            _dbContext.SaveChanges();

            var UpdatedMember = GetById(id);
            return UpdatedMember;
        }

        public void Delete(int id)
        {
            Member member = GetById(id);
            _dbContext.Remove(member);
            _dbContext.SaveChanges();
        }

        public List<Member> Get()
        {
            return [.. _dbContext.Members];
        }

        public Member GetById(int id)
        {
            return _dbContext.Members.Where(p => p.MemberId == id).FirstOrDefault();
        }
    }
}
