using IdentityServer.Core.UserManagement;

namespace IdentityServer.Web.Models
{
    public class RegisterResponseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public RegisterResponseViewModel(User user)
        {
            Id = $"{user.Id}";
            Name = user.Name;
            Email = user.Email;
        }
    }
}
