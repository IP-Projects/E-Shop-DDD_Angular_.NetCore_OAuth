using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Core.Base;

namespace Domain.Services.Base
{
    public abstract class BaseLister<TEntity,TRepository>: IBaseLister<TEntity>
    where TEntity:class
    where TRepository:class
    {
        protected readonly TRepository Repository;
        //protected abstract Func<IQueryable<TEntity>, IQueryable<TEntity>> Query { get; set; }

        protected BaseLister(TRepository repository)
        {
            Repository = repository;
        }

        public abstract Task<IEnumerable<TEntity>> List();

        //protected Func<IQueryable<TEntity>, IQueryable<TEntity>> AddQuery(
        //    Func<IQueryable<TEntity>, IQueryable<TEntity>> query)
        //{
        //    Query.
        //}
    }
}
