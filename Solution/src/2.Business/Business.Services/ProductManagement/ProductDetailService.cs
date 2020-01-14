using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DataContracts.ProductManagement;
using Business.ServiceContracts.ProductManagement;
using Business.Services.Base;
using Domain.Core.ProductManagement.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business.Services.ProductManagement
{
    public class ProductDetailService : BaseDetailService<IProductRepository>, IProductDetailService
    {
        public ProductDetailService(IProductRepository repository) : base(repository)
        {
        }

        public async Task<IEnumerable<ProductDetail>> GetProductsByCategoryId(Guid categoryId)
        {
            var products = await Repository.GetAllAsync(p => p.Include(e => e.Category).Where(e => e.CategoryId == categoryId));

            return products.Select(x => x.ToDetail());
        }

        public async Task<IEnumerable<ProductDetail>> GetAllProducts()
        {
            var products = await Repository.GetAllAsync(p => p.Include(e => e.Category));

            return products.Select(x => x.ToDetail());
        }

        public async Task<ProductDetail> GetProductById(Guid productId)
        {
            var product = await Repository.GetByAsync(x=> x.Id == productId, p => p.Include(e => e.Category));
            return product.ToDetail();
        }
    }
}
