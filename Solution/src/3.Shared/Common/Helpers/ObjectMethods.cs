using System.Collections.Generic;
using System.Linq;

namespace Common.Helpers
{
    public static class ObjectMethods
    {
        public static Dictionary<string, object> GetProperties<TEntity>(TEntity entity) where TEntity : class
        {
            return entity.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(entity,null));
        }
    }
}
