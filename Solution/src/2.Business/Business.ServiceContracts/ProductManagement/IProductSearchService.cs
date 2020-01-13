using System.Collections.Generic;

namespace Business.ServiceContracts.ProductManagement
{
    public interface IProductSearchService
    {
        IEnumerable<TItem> Search<TItem>() where TItem:class;
    }
}