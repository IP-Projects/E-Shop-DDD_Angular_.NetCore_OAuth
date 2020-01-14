using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.Base;
using Business.DataContracts.ProductManagement;

namespace Business.ServiceContracts.ProductManagement
{
    public interface IProductSearchService
    {
        Task<IEnumerable<ProductItem>> SearchAsync(SearchDetail detail);
    }
}