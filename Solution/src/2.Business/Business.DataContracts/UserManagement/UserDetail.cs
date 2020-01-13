using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Business.DataContracts.OrderManagement;

namespace Business.DataContracts.UserManagement
{
    [DataContract]
    public class UserDetail
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IEnumerable<OrderDetail> Orders { get; set; }
    }
}
