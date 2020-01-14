using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Core.Base
{
    public interface IBaseRepository<T>: IBaseReadOnlyRepository<T> where T : class
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Create(IEnumerable<T> entities);
    }
}