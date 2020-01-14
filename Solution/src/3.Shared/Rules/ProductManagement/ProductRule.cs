using System;
using Rules.Base;

namespace Rules.ProductManagement
{
    public class ProductRule
    {
        public static StringMetaData Name => new StringMetaData
        {
            Required = true,
            MinLength = 1,
            MaxLength = 1000
        };

        public static StringMetaData Description => new StringMetaData
        {
            Required = true,
            MinLength = 1,
            MaxLength = 1000
        };

        public static StringMetaData CoverImageName => new StringMetaData
        {
            Required = true,
            MinLength = 1,
            MaxLength = 1000
        };

        public static DecimalMetaData Price => new DecimalMetaData
        {
            Required = true,
            MinValue = decimal.MinValue,
            MaxValue = decimal.MaxValue
        };

        public static RelationMetaData Category => new RelationMetaData
        {
            Required = false
        };

        public static RelationMetaData Items => new RelationMetaData
        {
            Required = false
        };
    }
}
