using System.Linq;
using Business.DataContracts.UserManagement;
using Business.Services.OrderManagement;
using Domain.Core.UserManagement;

namespace Business.Services.UserManagement
{
    public static class UserMapper
    {
        public static UserDetail ToDetail(this User entity)
        {
            return new UserDetail
            {
                Id = entity.Id,
                Name = entity.Name,
                Orders = entity.Orders.Select(x => x.ToDetail()),
            };
        }
    }
}