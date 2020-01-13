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

        public async Task<IEnumerable<T>> GetAllAsync(
            Func<IQueryable<T>, IQueryable<T>> query = null)
        {
            var entities = _context.Set<T>().AsNoTracking();
            return query != null
                ? await query(entities).ToListAsync()
                : await entities.ToListAsync();
        }

        public async Task<T> GetByAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query)
        {
            var entities = _context.Set<T>().Where(expression);

            return query != null
                ? await query(entities).FirstOrDefaultAsync()
                : await entities.FirstOrDefaultAsync();
        }

        public async Task<T> ReadOnlyGetByAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>> query)
        {
            var entities = _context.Set<T>().Where(expression).AsNoTracking();

            return query != null
                ? await query(entities).FirstOrDefaultAsync()
                : await entities.FirstOrDefaultAsync();
        }

        public async Task Create(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}