using MyStore.Dtos.User;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface IUserService
    {
        List<UserDto> Get();

        User GetById(int id);

        UserDto Create(CreateUserDto createUserDto);

        UserDto Update(int id, UpdateUserDto updateUserDto);

        void Delete(int id);
    }
}
