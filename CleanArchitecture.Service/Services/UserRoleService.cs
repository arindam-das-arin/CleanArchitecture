using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Repository.Interfaces;
using CleanArchitecture.Service.Interfaces;

namespace CleanArchitecture.Service.Services
{
    public class UserRoleService(IUserRoleRepository userRoleRepository) : IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository = userRoleRepository;

        public async Task<int> AddUserRoleServiceAsync(UserRoleDto userRoleDto)
        {
            return await this._userRoleRepository.AddAsync(userRoleDto);
        }

        public async Task<int> DeleteUserRoleServiceAsync(int id)
        {
            return await this._userRoleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserRoleDto>> GetAllUserRoleServiceAsync()
        {
            return await this._userRoleRepository.GetAllAsync();
        }

        public async Task<UserRoleDto> GetUserRoleByIdServiceAsync(int id)
        {
            return await this._userRoleRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateUserRoleServiceAsync(UserRoleDto userRoleDto)
        {
            return await this._userRoleRepository.UpdateAsync(userRoleDto);
        }
    }
}
