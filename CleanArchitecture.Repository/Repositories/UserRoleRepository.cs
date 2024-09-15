using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Context;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;

namespace CleanArchitecture.Repository.Repositories
{
    public class UserRoleRepository(AppDbContext appDbContext, IMapper mapper) : BaseRepository<UserRole, UserRoleDto>(appDbContext, mapper), IUserRoleRepository
    {
    }
}
