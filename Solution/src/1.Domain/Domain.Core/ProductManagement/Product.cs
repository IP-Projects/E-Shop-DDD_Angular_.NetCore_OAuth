using System;
using System.Collections.Generic;
using Domain.Core.CategoryManagement;
using Domain.Core.OrderItemsManagement;

namespace Domain.Core.ProductManagement
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CoverImageName { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<OrderItems> Items { get; set; }
    }
}