using Rules.Base;

namespace Rules.UserManagement
{
    public class UserRule
    {
        public const string Admin = "admin";
        public const string Consumer = "consumer";

        public const string TestAdminPass = "Qwerty12345!";
        public const string TestCustomerPass = "Qwerty12345";

        public static StringMetaData Name => new StringMetaData
        {
            Required = true,
            MaxLength = 1000,
            MinLength = 1
        };

        public static RelationMetaData Order => new RelationMetaData
        {
            Required = false
        };
    }
}
