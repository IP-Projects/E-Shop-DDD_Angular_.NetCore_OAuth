using Rules.Base;

namespace Rules.OrderItemsManagement
{
    public class OrderItemsRule
    {
        public static IntegerMetaData Quantity => new IntegerMetaData
        {
            Required = true,
            MinValue = int.MinValue,
            MaxValue = int.MaxValue,
            DefaultValue = 0
        };

        public static RelationMetaData Product => new RelationMetaData
        {
            Required = true
        };

        public static RelationMetaData Order => new RelationMetaData
        {
            Required = true
        };

    }
}
