using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DataContracts.OrderManagement;
using Business.ServiceContracts.OrderManagement;
using Business.Services.Base;
using Domain.Core.OrderManagement.Interfaces;
using Domain.Services.OrderManagement;
using Microsoft.EntityFrameworkCore;

namespace Business.Services.OrderManagement
{
    public class OrderDetailService : BaseDetailService<IOrderRepository>, IOrderDetailService
    {
        public OrderDetailService(IOrderRepository repository) : base(repository)
        {
        }

        public async Task<OrderDetail> GetOrderById(Guid id)
        {
            var order = await Repository.GetByAsync(p => p.Id == id,
                e => e.Include(p => p.User).Include(p => p.Items).ThenInclude(x => x.Product).ThenInclude(z => z.Category));
            return order.ToDetail();
        }

        public async Task<IEnumerable<OrderDetail>> GetOrdersByUserId(Guid id)
        {
            var orders = await Repository.GetAllAsync(p => p.Include(e => e.User).Where(e => e.UserId == id));

            return orders.Select(x=> x.ToDetail());
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrders()
        {
            var orders = await Repository.GetAllAsync(o => o.Include(u => u.User));

            return orders.Select(x => x.ToDetail());
        }
    }
}
