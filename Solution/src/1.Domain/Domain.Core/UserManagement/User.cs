using System;
using System.Collections.Generic;
using Domain.Core.Base;
using Domain.Core.OrderManagement;
using Microsoft.AspNetCore.Identity;

namespace Domain.Core.UserManagement
{
    public class User : IdentityUser<Guid>, IEntity<Guid>
    {
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }

    }
}
