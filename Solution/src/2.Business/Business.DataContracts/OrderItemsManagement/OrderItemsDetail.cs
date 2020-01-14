using System;
using System.Runtime.Serialization;
using Business.DataContracts.OrderManagement;
using Business.DataContracts.ProductManagement;

namespace Business.DataContracts.OrderItemsManagement
{
    [DataContract]
    public class OrderItemsDetail
    {
        [DataMember]
        public Guid OrderId { get; set; }
        [DataMember]
        public OrderDetail Order { get; set; }

        [DataMember]
        public Guid ProductId { get; set; }
        [DataMember]
        public ProductDetail Product { get; set; }
        [DataMember]
        public int Quantity{ get; set; }
    }
}
