using Business.ServiceContracts.Base;
using Domain.Core.UserManagement.Interfaces;

namespace Business.ServiceContracts.UserManagement
{
    public interface IUserDetailService : IBaseDetailService<IUserRepository>
    {
    }
}
