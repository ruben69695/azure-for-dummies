using System.Linq;
using System.Threading.Tasks;
using AppService.Core.Interfaces;
using AppService.Core.Shared;
using Microsoft.EntityFrameworkCore;

namespace AppService.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly AppServiceDbContext _dbContext;

        public EfRepository(AppServiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> CreateAsync<T>(T entity) where T : BaseEntity
        {
            var result = await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task UpdateAsync<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<T> GetAll<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().AsNoTracking();
        }
    }
}