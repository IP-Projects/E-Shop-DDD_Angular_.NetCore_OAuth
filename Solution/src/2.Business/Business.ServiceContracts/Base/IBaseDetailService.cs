namespace Business.ServiceContracts.Base
{
    public interface IBaseDetailService<TRepository>
    where TRepository : class
    {
        TRepository Repository { get; set; }
    }
}
