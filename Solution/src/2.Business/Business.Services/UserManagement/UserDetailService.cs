using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DataContracts.UserManagement;
using Business.ServiceContracts.UserManagement;
using Business.Services.Base;
using Domain.Core.UserManagement.Interfaces;
using Rules.UserManagement;

namespace Business.Services.UserManagement
{
    public class UserDetailService : BaseDetailService<IUserRepository>, IUserDetailService
    {

        public UserDetailService(IUserRepository repository) : base(repository)
        {
        }

        public async Task<IEnumerable<UserDetail>> GetUsersByRole(string role)
        {
            var users = await Repository.GetUsersByRole(role);
            return users.Select(x => x.ToDetail());
        }

        public async Task<bool> IsAdmin(Guid id)
        {
            return await Repository.IsRoleByUserId(id, UserRule.Admin);
        }

        public async Task<IEnumerable<UserDetail>> GetAllUsers()
        {
            var users = await Repository.GetAllAsync();
            return users.Select(x => x.ToDetail());
        }

        public async Task<UserDetail> GetUserById(Guid id)
        {
            var user = await Repository.GetUserById(id);
            return user.ToDetail();
        }
    }
}
