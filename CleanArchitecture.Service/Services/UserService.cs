using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Repository.Interfaces;
using CleanArchitecture.Service.Interfaces;

namespace CleanArchitecture.Service.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<IEnumerable<UserDto>> GetAllUserServiceAsync()
        {
            return await this._userRepository.GetAllAsync();
        }

        public async Task<UserDto> GetUserByIdServiceAsync(int id)
        {
            return await this._userRepository.GetByIdAsync(id);
        }

        public async Task<int> AddUserServiceAsync(UserDto userDto)
        {
            return await this._userRepository.AddAsync(userDto);
        }

        public async Task<int> UpdateUserServiceAsync(UserDto userDto)
        {
            return await this._userRepository.UpdateAsync(userDto);
        }

        public async Task<int> DeleteUserServiceAsync(int id)
        {
            return await this._userRepository.DeleteAsync(id);
        }
    }
}
