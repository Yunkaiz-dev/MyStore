using MyStore.Abstractions.Repositories;
using MyStore.Dtos.User;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreDbContext _dbContext;

        public UserRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Create(CreateUserDto createUserDto)
        {
            var result = new User()
            {
                // Mapeo por completar
                UserFirstName = createUserDto.UserFirstName,
                UserLastName = createUserDto.UserLastName,
                UserEmail = createUserDto.UserEmail,
                IsMember = createUserDto.IsMember,
                CreatedDateTime = createUserDto.CreatedDateTime,
                ModifiedDateTime = createUserDto.ModifiedDateTime
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public User Update(int id, UpdateUserDto updateUserDto)
        {
            var userExist = GetById(id);

            // Mapeo por completar
            userExist.UserFirstName = updateUserDto.UserFirstName ?? userExist.UserFirstName;
            userExist.UserLastName = updateUserDto.UserLastName ?? userExist.UserLastName;
            userExist.UserEmail = updateUserDto.UserEmail ?? userExist.UserEmail;
            userExist.IsMember = updateUserDto.IsMember ?? userExist.IsMember;
            userExist.CreatedDateTime = updateUserDto.CreatedDateTime ?? userExist.CreatedDateTime;
            userExist.ModifiedDateTime = updateUserDto.ModifiedDateTime ?? userExist.ModifiedDateTime;

            _dbContext.Update(userExist);
            _dbContext.SaveChanges();

            var updatedUser = GetById(id);
            return updatedUser;
        }

        public void Delete(int id)
        {
            User user = GetById(id);
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        public List<User> Get()
        {
            return _dbContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return _dbContext.Users.Where(u => u.UserId == id).FirstOrDefault();
        }

    }
}
