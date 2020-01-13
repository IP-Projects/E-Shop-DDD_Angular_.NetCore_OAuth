using System;
using System.Collections.Generic;
using Business.ServiceContracts.ProductManagement;

namespace Business.Services.ProductManagement
{
    public class ProductSearchService: IProductSearchService
    {
        public IEnumerable<TProductItem> Search<TProductItem>() where TProductItem : class
        {
            throw new NotImplementedException();
        }
    }
}
