using System;
using Domain.Core.Base;
using Domain.Core.UserManagement;
using Domain.Population.Base;

namespace Domain.Population
{
    public class UserDataSet: BaseDataSet<User>
    {
        public User User1 { get; set; }
        public User User2 { get; set; }
        public User User3 { get; set; }

        public UserDataSet(IBaseRepository<User> repository) : base(repository)
        {
        }

        public override void Populate()
        {
            User1 = AddEntity(new User
            {
                Id = Guid.NewGuid(),
                Name = "John Smith",
                Email = "john@gmail.com",
                UserName = "john@gmail.com"
            });
            User2 = AddEntity(new User
            {
                Id = Guid.NewGuid(),
                Name = "Richard Jenkins",
                Email = "jj@gmail.com",
                UserName = "jj@gmail.com"
            });
            User3 = AddEntity(new User
            {
                Id = Guid.NewGuid(),
                Name = "Jonathan Yellow",
                Email = "color@gmail.com",
                UserName = "color@gmail.com"
            });

            DefaultEntity = User1;
        }
    }
}
