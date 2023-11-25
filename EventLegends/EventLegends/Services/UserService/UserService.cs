using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;
using EventLegends.Repositories.UserRepository;

namespace EventLegends.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var userList = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(userList);
        }

        public async Task<UserDto> GetUserById(Guid userId)
        {
            var user = await _userRepository.FindByIdAsync(userId);
            return _mapper.Map<UserDto>(user);
        }

        public async Task CreateUser(UserDto userDto)
        {
            var userEntity = _mapper.Map<User>(userDto);
            _userRepository.Create(userEntity);
            await _userRepository.SaveAsync();
        }

        public async Task UpdateUser(Guid userId, UserDto userDto)
        {
            var existingUser = await _userRepository.FindByIdAsync(userId);
            if (existingUser == null)
            {
                throw new InvalidOperationException($"User-ul cu id-ul {userId} nu exista!");
            }

            _mapper.Map(userDto, existingUser);
            _userRepository.Update(existingUser);
            await _userRepository.SaveAsync();
        }

        public async Task DeleteUser(Guid userId)
        {
            var userToDelete = await _userRepository.FindByIdAsync(userId);
            if (userToDelete != null)
            {
                _userRepository.Delete(userToDelete);
                await _userRepository.SaveAsync();
            }
        }

    }
}
