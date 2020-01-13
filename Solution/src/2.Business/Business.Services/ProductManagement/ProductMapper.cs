using System.Linq;
using Business.DataContracts.ProductManagement;
using Business.Services.CategoryManagement;
using Business.Services.OrderItemsManagement;
using Domain.Core.ProductManagement;

namespace Business.Services.ProductManagement
{
    public static class ProductMapper
    {
        public static ProductDetail ToDetail(this Product entity)
        {
            return new ProductDetail
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                CoverImageName = entity.CoverImageName,
                CategoryId = entity.CategoryId,
                Category = entity.Category.ToDetail(),
                Items = entity.Items.Select(x => x.ToDetail())
            };
        }

        public static ProductItem ToItem(this Product entity)
        {
            return new ProductItem
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                CoverImageName = entity.CoverImageName,
                CategoryId = entity.CategoryId,
                Category = entity.Category.ToDetail(),
            };
        }
    }
}