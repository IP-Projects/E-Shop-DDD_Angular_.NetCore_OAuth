using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.ProductManagement;

namespace Business.ServiceContracts.ProductManagement
{
    public interface IProductDetailService
    {
        Task<IEnumerable<ProductDetail>> GetProductsByCategoryId(Guid categoryId);
        Task<IEnumerable<ProductDetail>> GetAllProducts();
        Task<ProductDetail> GetProductById(Guid productId);
    }
}
