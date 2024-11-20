using MyStore.Dtos.User;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface IUserRepository
    {
        List<User> Get();

        User GetById(int id);

        User Create(CreateUserDto createUserDto);

        User Update(int id, UpdateUserDto updateUserDto);

        void Delete(int id);
    }
}
