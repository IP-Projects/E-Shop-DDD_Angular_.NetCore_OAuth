using Domain.Core.Base;
using Domain.Core.OrderManagement;
using Domain.Core.OrderManagement.Interfaces;
using Domain.Services.Base;

namespace Domain.Services.OrderManagement
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(IDbContext context) : base(context)
        {
        }
    }
}
