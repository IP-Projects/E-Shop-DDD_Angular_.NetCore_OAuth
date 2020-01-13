using System;
using System.Collections.Generic;
using Domain.Core.OrderItemsManagement;
using Domain.Core.UserManagement;

namespace Domain.Core.OrderManagement
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime PlacedOn { get; set; }
        public Status Status { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<OrderItems> Items { get; set; }
    }

    public enum Status
    {
        Confirmed,
        Placed,
        Pending
    }
}
