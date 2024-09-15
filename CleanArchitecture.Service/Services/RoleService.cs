using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Repository.Interfaces;
using CleanArchitecture.Service.Interfaces;

namespace CleanArchitecture.Service.Services
{
    public class RoleService(IRoleRepository roleRepository) : IRoleService
    {
        private readonly IRoleRepository _roleRepository = roleRepository;

        public async Task<int> AddRoleServiceAsync(RoleDto roleDto)
        {
            return await this._roleRepository.AddAsync(roleDto);
        }

        public async Task<int> DeleteRoleServiceAsync(int id)
        {
            return await this._roleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<RoleDto>> GetAllRoleServiceAsync()
        {
            return await this._roleRepository.GetAllAsync();
        }

        public async Task<RoleDto> GetRoleByIdServiceAsync(int id)
        {
            return await this._roleRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateRoleServiceAsync(RoleDto roleDto)
        {
            return await this._roleRepository.UpdateAsync(roleDto);
        }
    }
}
