using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Helpers;
using Domain.Core.Base;
using Domain.Core.ProductManagement;

namespace Domain.Services.Base
{
    public abstract class BaseLister<TEntity,TRepository>: IBaseLister<TEntity>
    where TEntity:class
    where TRepository:class
    {
        protected readonly TRepository Repository;

        protected BaseLister(TRepository repository)
        {
            Repository = repository;
        }

        public abstract Task<IEnumerable<TEntity>> List();
        
        // TODO must be modified to be used with different types of operation like contains
        public IQueryable<TEntity> ConstructQuery(IQueryable<TEntity> query)
        {
            var properties = ObjectMethods.GetProperties(this);
            foreach (var (key, value) in properties)
            {
                if (value != null)
                {
                    query = query.Where(x => x.GetType().GetProperty(key).GetValue(x, null) == value);
                }
            }
            return query;
        }
    }
}
