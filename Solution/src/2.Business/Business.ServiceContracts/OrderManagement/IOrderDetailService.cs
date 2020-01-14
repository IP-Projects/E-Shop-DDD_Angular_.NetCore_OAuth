using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.OrderManagement;
using Business.ServiceContracts.Base;
using Domain.Core.OrderManagement.Interfaces;

namespace Business.ServiceContracts.OrderManagement
{
    public interface IOrderDetailService : IBaseDetailService<IOrderRepository>
    {
        Task<OrderDetail> GetOrderById(Guid id);
        Task<IEnumerable<OrderDetail>> GetOrdersByUserId(Guid id);
        Task<IEnumerable<OrderDetail>> GetAllOrders();
    }
}
