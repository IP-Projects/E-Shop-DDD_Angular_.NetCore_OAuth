using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.OrderManagement;
using Business.ServiceContracts.OrderManagement;
using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderDetailService _detailService;

        public OrderController(IOrderDetailService detailService)
        {
            _detailService = detailService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<OrderDetail>> GetAll()
        {
            return await _detailService.GetAllOrders();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<OrderDetail> Get(Guid id)
        {
            return await _detailService.GetOrderById(id);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IEnumerable<OrderDetail>> GetByUserId(Guid id)
        {
            return await _detailService.GetOrdersByUserId(id);
        }
    }
}
