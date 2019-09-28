using System.Linq;
using System.Threading.Tasks;
using AppService.Core.Shared;

namespace AppService.Core.Interfaces
{
    public interface IRepository
    {
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task UpdateAsync<T>(T entity) where T : BaseEntity;
        Task DeleteAsync<T>(T entity) where T : BaseEntity;
        IQueryable<T> GetAll<T>() where T : BaseEntity;
    }
}