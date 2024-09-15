using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Models;

namespace CleanArchitecture.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User, UserDto>
    {
    }
}
