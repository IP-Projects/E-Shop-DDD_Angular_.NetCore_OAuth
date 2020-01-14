using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Core.Base;
using Domain.Core.UserManagement;
using Domain.Core.UserManagement.Interfaces;
using Domain.Services.Base;
using Microsoft.AspNetCore.Identity;
using Rules.UserManagement;

namespace Domain.Services.UserManagement
{
    public class UserRepository :BaseReadOnlyRepository<User>, IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(IDbContext context,UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
        }

  
        public async Task<User> GetUserByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<User> GetUserById(Guid id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }

        public async Task Create(User user, string password, string role)
        {
            var userCreation = await _userManager.CreateAsync(user, password);
            if (!userCreation.Succeeded)
            {
                throw new Exception($"Failed to create user {user.Email} with password {password}");
            }

            var addedToRole = await _userManager.AddToRoleAsync(user, role);
            if (!addedToRole.Succeeded)
            {
                throw new Exception($"Failed to add user {user.Email} to role {role}");
            }

        }

        public async Task Delete(User user)
        {
            var userDeleted = await _userManager.DeleteAsync(user);
            if (!userDeleted.Succeeded)
            {
                throw new Exception($"Failed to delete user {user.Email}");
            }
        }

        public async Task Update(User user)
        {
            var userUpdated = await _userManager.UpdateAsync(user);
            if (!userUpdated.Succeeded)
            {
                throw new Exception($"Failed to update user {user.Email}");
            }
        }

        public async Task<IEnumerable<User>> GetUsersByRole(string role)
        {
            var users = await _userManager.GetUsersInRoleAsync(role);
            return users ?? new List<User>();
        }

        public async Task<bool> IsRoleByUserId(Guid id, string role)
        {
            var user = await GetUserById(id);
            if (user != null)
            {
                return await _userManager.IsInRoleAsync(user, role);
            }
            return false;
        }
    }
}
