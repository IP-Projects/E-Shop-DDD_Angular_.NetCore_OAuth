using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.Base;
using Business.ServiceContracts.Base;

namespace Business.Services.Base
{
    public abstract class BaseSearchService<TItem,TLister>:IBaseSearchService<TLister>
    where TItem : class
    where TLister: class
    {
        public TLister Lister { get; set; }

        protected BaseSearchService(TLister lister)
        {
            Lister = lister;
        }

        public abstract Task<IEnumerable<TItem>> SearchAsync(SearchDetail detail);
    }
}
