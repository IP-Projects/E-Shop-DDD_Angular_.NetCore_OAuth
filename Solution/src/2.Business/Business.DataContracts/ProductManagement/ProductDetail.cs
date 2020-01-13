using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Business.DataContracts.CategoryManagement;
using Business.DataContracts.OrderItemsManagement;

namespace Business.DataContracts.ProductManagement
{
    [DataContract]
    public class ProductDetail
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string CoverImageName { get; set; }


        [DataMember]
        public Guid CategoryId { get; set; }
        [DataMember]
        public CategoryDetail Category { get; set; }
        [DataMember]
        public IEnumerable<OrderItemsDetail> Items { get; set; }
    }
}
