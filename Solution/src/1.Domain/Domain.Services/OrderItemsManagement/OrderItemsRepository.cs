using Domain.Core.Base;
using Domain.Core.OrderItemsManagement;
using Domain.Core.OrderItemsManagement.Interfaces;
using Domain.Services.Base;

namespace Domain.Services.OrderItemsManagement
{
    public class OrderItemsRepository : BaseRepository<OrderItems>, IOrderItemsRepository
    {
        public OrderItemsRepository(IDbContext context) : base(context)
        {
        }
    }
}
