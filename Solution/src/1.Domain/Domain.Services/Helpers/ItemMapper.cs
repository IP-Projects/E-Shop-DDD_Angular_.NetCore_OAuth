using System.Linq;
using Domain.Core.Helpers.Interfaces;

namespace Domain.Services.Helpers
{
    public static class ItemMapper<TEntity,TDto> //: IItemMapper<TEntity, TDto>
    where TEntity: class
    where TDto: class
    {
        public static void Map(TEntity entity, TDto dto)
        {
            var properties = entity.GetType().GetProperties().ToDictionary(x => x.Name, x=> x.GetValue(entity,null));
            foreach (var (key, value) in properties)
            {
                dto.GetType().GetProperty(key)?.SetValue(dto, value);
            }
        }
    }
}
