using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Core.UserManagement
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
    }
}
