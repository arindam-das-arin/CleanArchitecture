using AutoMapper;
using CleanArchitecture.Entity.Base;
using CleanArchitecture.Entity.Context;
using CleanArchitecture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Repository.Repositories
{
    public class BaseRepository<TEntity, TDto>(AppDbContext appDbContext, IMapper mapper) : IBaseRepository<TEntity, TDto> where TEntity : BaseEntity where TDto : class
    {
        protected readonly AppDbContext _appDbContext = appDbContext;
        protected readonly DbSet<TEntity> _dbSet = appDbContext.Set<TEntity>();
        protected readonly IMapper _mapper = mapper;

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await this._dbSet.ToListAsync();
            return this._mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto?> GetByIdAsync(int id)
        {
            var entity = await this._dbSet.FindAsync(id);
            return this._mapper.Map<TDto>(entity);
        }

        public async Task<int> AddAsync(TDto dto)
        {
            var entity = this._mapper.Map<TEntity>(dto);
            await this._dbSet.AddAsync(entity);
            return await this._appDbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(TDto dto)
        {
            var entity = this._mapper.Map<TEntity>(dto);
            this._dbSet.Attach(entity);
            this._appDbContext.Entry(entity).State = EntityState.Modified;
            return await this._appDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var dto = await this.GetByIdAsync(id);
            if (dto != null)
            {
                var entity = this._mapper.Map<TEntity>(dto);
                this._dbSet.Remove(entity);
                return await this._appDbContext.SaveChangesAsync();
            }
            return 0;
        }
    }
}
