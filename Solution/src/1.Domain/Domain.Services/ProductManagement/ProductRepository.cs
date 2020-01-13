using Domain.Core.Base;
using Domain.Core.ProductManagement;
using Domain.Core.ProductManagement.Interfaces;
using Domain.Services.Base;

namespace Domain.Services.ProductManagement
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbContext context) : base(context)
        {
        }
    }
}
