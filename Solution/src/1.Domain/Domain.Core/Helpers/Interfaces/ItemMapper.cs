using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Helpers.Interfaces
{
    public interface IItemMapper<TEntity,TDto>
        where TEntity : class
        where TDto : class
    {
        void Map(TEntity entity, TDto dto);
    }
}
