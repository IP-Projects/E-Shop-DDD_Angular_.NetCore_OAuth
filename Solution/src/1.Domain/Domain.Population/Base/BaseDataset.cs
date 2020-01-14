using System.Collections.Generic;
using Domain.Core.Base;

namespace Domain.Population.Base
{
    public abstract class BaseDataSet<TEntity>
    where TEntity : class
    {
        protected IBaseRepository<TEntity> Repository;
        public List<TEntity> Entities = new List<TEntity>();
        public TEntity DefaultEntity { get; protected set; }

        protected BaseDataSet(IBaseRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public abstract void Populate();

        protected void SaveToDatabase()
        {
            Repository.Create(Entities);
        }

        public TEntity AddEntity(TEntity entity)
        {
            Entities.Add(entity);
            return entity;
        }
    }
}
