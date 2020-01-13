using System;
using System.Collections.Generic;
using Domain.Core.Base;
using Domain.Core.ProductManagement;

namespace Domain.Core.CategoryManagement
{
    public class Category: IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
