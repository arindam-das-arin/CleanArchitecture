using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Context;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;

namespace CleanArchitecture.Repository.Repositories
{
    public class UserRepository(AppDbContext appDbContext, IMapper mapper) : BaseRepository<User, UserDto>(appDbContext, mapper), IUserRepository
    {
    }
}
