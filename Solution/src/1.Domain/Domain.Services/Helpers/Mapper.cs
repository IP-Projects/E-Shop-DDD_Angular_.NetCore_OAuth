namespace Domain.Services.Helpers
{
    public static class Mapper<TEntity,TDto> //: IItemMapper<TEntity, TDto>
    where TEntity: class
    where TDto: class, new()
    {
        //public static TDto Map(TEntity entity)
        //{
        //    var dto = new TDto();
        //    var properties = entity.GetType().GetProperties().ToDictionary(x => x.Name, x=>
        //    {
        //        var property = x.GetValue(entity,null);
        //        var dtoProperty = dto.GetType().GetProperty(x.Name).GetType();
        //        var a = property.GetType();
        //        return property is IEntity ? Mapper<a, dtoProperty>;
        //    });
        //    foreach (var (key, value) in properties)
        //    {
        //        dto.GetType().GetProperty(key)?.SetValue(dto, value);
        //    }
        //    return dto;
        //}
    }
}
