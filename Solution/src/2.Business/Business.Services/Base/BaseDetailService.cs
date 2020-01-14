using Business.ServiceContracts.Base;

namespace Business.Services.Base
{
    public abstract class BaseDetailService<TRepository>: IBaseDetailService<TRepository>
    where TRepository : class
    {
        public TRepository Repository { get; set; }

        protected BaseDetailService(TRepository repository)
        {
            Repository = repository;
        }
    }
}
