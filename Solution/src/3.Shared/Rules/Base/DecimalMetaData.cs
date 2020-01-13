using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class DecimalMetaData : PropertyMetaData
    {
        [DataMember]
        public decimal MinValue { get; set; }
        [DataMember]
        public decimal MaxValue { get; set; }
        [DataMember]
        public short Scale { get; set; }
    }
}
