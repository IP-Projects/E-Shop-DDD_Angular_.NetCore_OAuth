using System;
using Rules.Base;

namespace Rules.OrderManagement
{
    public class OrderRule
    {
        public static DateTimeMetaData PlacedOn => new DateTimeMetaData
        {
            Required = true,
            Start = DateTime.MinValue,
            End = DateTime.MaxValue
        };

        public static RelationMetaData User => new RelationMetaData
        {
            Required = false
        };

        public static RelationMetaData Items => new RelationMetaData
        {
            Required = false
        };

    }
}
