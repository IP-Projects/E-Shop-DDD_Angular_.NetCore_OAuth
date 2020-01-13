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
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IDbContext _context;

        protected BaseRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken,
            Func<IQueryable<T>, IQueryable<T>> query = null)
        {
            var entities = _context.Set<T>().AsNoTracking();
            return query != null
                ? await query(entities).ToListAsync(cancellationToken)
                : await entities.ToListAsync(cancellationToken);
        }

        public async Task<T> GetByAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query, CancellationToken cancellationToken)
        {
            var entities = _context.Set<T>().Where(expression);

            return query != null
                ? await query(entities).FirstOrDefaultAsync(cancellationToken)
                : await entities.FirstOrDefaultAsync(cancellationToken: cancellationToken);
        }

        public async Task<T> ReadOnlyGetByAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query, CancellationToken cancellationToken)
        {
            var entities = _context.Set<T>().Where(expression).AsNoTracking();

            return query != null
                ? await query(entities).FirstOrDefaultAsync(cancellationToken)
                : await entities.FirstOrDefaultAsync(cancellationToken: cancellationToken);
        }

        public async Task Create(T entity, CancellationToken cancellationToken)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(T entity, CancellationToken cancellationToken)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(T entity, CancellationToken cancellationToken)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}