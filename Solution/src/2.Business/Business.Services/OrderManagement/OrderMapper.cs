using System.Linq;
using Business.DataContracts.OrderManagement;
using Business.Services.OrderItemsManagement;
using Business.Services.UserManagement;
using Domain.Core.OrderManagement;

namespace Business.Services.OrderManagement
{
    public static class OrderMapper
    {
        public static OrderDetail ToDetail(this Order entity)
        {
            return new OrderDetail
            {
                Id = entity.Id,
                PlacedOn = entity.PlacedOn,
                Status = entity.Status,
                UserId = entity.UserId,
                User = entity.User.ToDetail(),
                Items = entity.Items.Select(x => x.ToDetail()),
            };
        }
    }
}