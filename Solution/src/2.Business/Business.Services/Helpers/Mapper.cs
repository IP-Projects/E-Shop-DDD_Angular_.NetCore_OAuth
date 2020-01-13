using System.Linq;

namespace Business.Services.Helpers
{
    public static class ItemMapper<TEntity,TDto> //: IItemMapper<TEntity, TDto>
    where TEntity: class
    where TDto: class, new()
    {
        //public static TDto Map(TEntity entity)
        //{
        //    var properties = entity.GetType().GetProperties().ToDictionary(x => x.Name, x=> x.GetValue(entity,null));
        //    var dto = new TDto();
        //    foreach (var (key, value) in properties)
        //    {
        //        dto.GetType().GetProperty(key)?.SetValue(dto, value);
        //    }
        //    return dto;
        //}
    }
}
