using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Context;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;

namespace CleanArchitecture.Repository.Repositories
{
    public class RoleRepository(AppDbContext appDbContext, IMapper mapper) : BaseRepository<Role, RoleDto>(appDbContext, mapper), IRoleRepository
    {
    }
}
