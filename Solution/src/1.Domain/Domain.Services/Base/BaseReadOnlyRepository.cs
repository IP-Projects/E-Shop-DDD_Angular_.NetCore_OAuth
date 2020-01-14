using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Domain.Core.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Base
{
    public abstract class BaseReadOnlyRepository<T> : IBaseReadOnlyRepository<T> where T : class
    {
        protected readonly IDbContext Context;

        protected BaseReadOnlyRepository(IDbContext context)
        {
            Context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync(
            Func<IQueryable<T>, IQueryable<T>> query = null)
        {
            var entities = Context.Set<T>().AsNoTracking();
            return query != null
                ? await query(entities).ToListAsync()
                : await entities.ToListAsync();
        }

        public async Task<T> GetByAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query)
        {
            var entities = Context.Set<T>().Where(expression);

            return query != null
                ? await query(entities).FirstOrDefaultAsync()
                : await entities.FirstOrDefaultAsync();
        }

        public async Task<T> ReadOnlyGetByAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query)
        {
            var entities = Context.Set<T>().Where(expression).AsNoTracking();

            return query != null
                ? await query(entities).FirstOrDefaultAsync()
                : await entities.FirstOrDefaultAsync();
        }
    }
}