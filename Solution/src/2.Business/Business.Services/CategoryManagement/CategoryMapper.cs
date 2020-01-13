using System.Linq;
using Business.DataContracts.CategoryManagement;
using Business.Services.ProductManagement;
using Domain.Core.CategoryManagement;

namespace Business.Services.CategoryManagement
{
    public static class CategoryMapper
    {
        public static CategoryDetail ToDetail(this Category entity)
        {
            return new CategoryDetail
            {
                Id = entity.Id,
                Name = entity.Name,
                Products = entity.Products.Select(x => x.ToDetail())
            };
        }
    }
}