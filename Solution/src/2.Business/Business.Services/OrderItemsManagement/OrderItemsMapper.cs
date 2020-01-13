using Business.DataContracts.OrderItemsManagement;
using Business.Services.OrderManagement;
using Business.Services.ProductManagement;
using Domain.Core.OrderItemsManagement;

namespace Business.Services.OrderItemsManagement
{
    public static class OrderItemsMapper
    {
        public static OrderItemsDetail ToDetail(this OrderItems entity)
        {
            return new OrderItemsDetail
            {
                OrderId = entity.OrderId ,
                Order = entity.Order.ToDetail() ,

                ProductId = entity.ProductId ,
                Product = entity.Product.ToDetail(),
            };
        }
    }
}