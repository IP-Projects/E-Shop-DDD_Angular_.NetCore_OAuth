using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Core.Base
{
    public interface IBaseReadOnlyRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IQueryable<T>> query = null);

        Task<T> GetByAsync(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query);

        Task<T> ReadOnlyGetByAsync(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query);
    }
}