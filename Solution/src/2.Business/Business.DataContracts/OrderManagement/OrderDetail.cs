using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Business.DataContracts.OrderItemsManagement;
using Business.DataContracts.UserManagement;
using Domain.Core.OrderManagement;

namespace Business.DataContracts.OrderManagement
{
    [DataContract]
    public class OrderDetail
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public DateTime PlacedOn { get; set; }
        [DataMember]
        public Status Status { get; set; }

        [DataMember]
        public Guid UserId { get; set; }
        [DataMember]
        public UserDetail User { get; set; }
        [DataMember]
        public IEnumerable<OrderItemsDetail> Items { get; set; }
    }
}
