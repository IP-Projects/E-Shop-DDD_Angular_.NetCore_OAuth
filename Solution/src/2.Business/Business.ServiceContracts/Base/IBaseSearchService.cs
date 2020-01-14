namespace Business.ServiceContracts.Base
{
    public interface IBaseSearchService<TLister>
    where TLister : class
    {
        TLister Lister { get; set; }
        //TODO make generic IQuery object
    }
}
