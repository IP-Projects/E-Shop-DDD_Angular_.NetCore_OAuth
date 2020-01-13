using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Core.Base
{
    public interface IBaseLister<TEntity>
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> List();
    }
}