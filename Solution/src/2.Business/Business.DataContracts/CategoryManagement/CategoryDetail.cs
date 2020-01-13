using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Business.DataContracts.ProductManagement;

namespace Business.DataContracts.CategoryManagement
{
    [DataContract]
    public class CategoryDetail
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IEnumerable<ProductDetail> Products { get; set; }
    }
}
