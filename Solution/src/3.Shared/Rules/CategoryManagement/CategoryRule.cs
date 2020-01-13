using Rules.Base;

namespace Rules.CategoryManagement
{
    public class CategoryRule
    {
        public static StringMetaData Name => new StringMetaData
        {
            Required = true,
            MaxLength = 1000,
            MinLength = 1
        };

        public static RelationMetaData Products => new RelationMetaData
        {
            Required = false
        };
    }
}
