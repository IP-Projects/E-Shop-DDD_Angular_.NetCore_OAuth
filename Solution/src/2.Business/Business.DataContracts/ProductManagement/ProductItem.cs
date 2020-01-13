using System;
using Business.DataContracts.CategoryManagement;

namespace Business.DataContracts.ProductManagement
{
    public class ProductItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CoverImageName { get; set; }


        public Guid CategoryId { get; set; }
        public CategoryDetail Category { get; set; }
    }
}
