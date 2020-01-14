using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Core.Base;

namespace Domain.Core.UserManagement.Interfaces
{
    public interface IUserRepository: IBaseReadOnlyRepository<User>
    {
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(Guid id);
        Task Create(User user, string password, string role);
        Task Delete(User user);
        Task Update(User user);
        Task<IEnumerable<User>> GetUsersByRole(string role);
        Task<bool> IsRoleByUserId(Guid id, string role);
    }
}