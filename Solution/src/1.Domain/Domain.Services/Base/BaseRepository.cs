using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Core.Base;

namespace Domain.Services.Base
{
    public abstract class BaseRepository<T> : BaseReadOnlyRepository<T>, IBaseRepository<T> 
    where T : class
    {
        protected BaseRepository(IDbContext context)
            :base(context)
        {
        }
        
        public virtual async Task Create(T entity)
        {
            Context.Set<T>().Add(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task Create(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
            await Context.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}