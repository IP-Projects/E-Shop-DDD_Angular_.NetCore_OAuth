using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DataContracts.Base;
using Business.DataContracts.ProductManagement;
using Business.ServiceContracts.ProductManagement;
using Business.Services.Base;
using Domain.Core.ProductManagement.Interfaces;

namespace Business.Services.ProductManagement
{
    public class ProductSearchService: BaseSearchService<ProductItem, IProductLister>, IProductSearchService
    {
        public ProductSearchService(IProductLister lister) : base(lister)
        {
        }

        public override async Task<IEnumerable<ProductItem>> SearchAsync(SearchDetail detail)
        {
            Lister.WithName(detail.Name);
            return (await Lister.List()).Select(x => x.ToItem());
        }
    }
}
