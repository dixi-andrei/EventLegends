using EventLegends.Models.DTOs;

namespace EventLegends.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto> GetUserById(Guid userId);
        Task CreateUser(UserDto userDto);
        Task UpdateUser(Guid userId, UserDto userDto);
        Task DeleteUser(Guid userId);
    }
}
