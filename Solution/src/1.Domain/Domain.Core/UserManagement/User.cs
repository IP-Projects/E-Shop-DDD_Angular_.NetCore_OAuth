using System;
using System.Collections.Generic;
using Domain.Core.OrderManagement;
using Microsoft.AspNetCore.Identity;

namespace Domain.Core.UserManagement
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }

    }
}
