using CleanArchitecture.Entity.Base;

namespace CleanArchitecture.Repository.Interfaces
{
    public interface IBaseRepository<TEntity, TDto> where TEntity : BaseEntity where TDto : class
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto?> GetByIdAsync(int id);
        Task<int> AddAsync(TDto entity);
        Task<int> UpdateAsync(TDto entity);
        Task<int> DeleteAsync(int id);
    }
}
