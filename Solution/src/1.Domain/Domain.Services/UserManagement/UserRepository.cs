using Domain.Core.Base;
using Domain.Core.UserManagement;
using Domain.Core.UserManagement.Interfaces;
using Domain.Services.Base;

namespace Domain.Services.UserManagement
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbContext context) : base(context)
        {
        }
    }
}
