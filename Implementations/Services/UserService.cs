using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.User;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userService;

        public UserService(IUserRepository userService)
        {
            _userService = userService;
        }

        public UserDto Create(CreateUserDto createUserDto)
        {
            var user = _userService.Create(createUserDto);
            var userDto = new UserDto
            {
                // Mapeo de propiedades por completar
                UserId = user.UserId,
                UserFirstName = user.UserFirstName,
                UserLastName = user.UserLastName,
                UserEmail = user.UserEmail,
                IsMember = user.IsMember,
                CreatedDateTime = user.CreatedDateTime,
                ModifiedDateTime = user.ModifiedDateTime,
            };
            return userDto;
        }

        public void Delete(int id)
        {
            _userService.Delete(id);
        }

        public List<UserDto> Get()
        {
            var users = _userService.Get();
            var userDtos = new List<UserDto>();

            foreach (User user in users)
            {
                var dto = new UserDto
                {
                    // Mapeo de propiedades por completar
                    UserId = user.UserId,
                    UserFirstName = user.UserFirstName,
                    UserLastName = user.UserLastName,
                    UserEmail = user.UserEmail,
                    IsMember = user.IsMember,
                    CreatedDateTime = user.CreatedDateTime,
                    ModifiedDateTime = user.ModifiedDateTime,
                };
                userDtos.Add(dto);
            }
            return userDtos;
        }

        public User GetById(int id)
        {
            return _userService.GetById(id);
        }

        public UserDto Update(int id, UpdateUserDto updateUserDto)
        {
            var user = _userService.Update(id, updateUserDto);
            var userDto = new UserDto
            {
                // Mapeo de propiedades por completar
                UserId = user.UserId,
                UserFirstName = user.UserFirstName,
                UserLastName = user.UserLastName,
                UserEmail = user.UserEmail,
                IsMember = user.IsMember,
                CreatedDateTime = user.CreatedDateTime,
                ModifiedDateTime = user.ModifiedDateTime,
            };
            return userDto;
        }

    }
}
