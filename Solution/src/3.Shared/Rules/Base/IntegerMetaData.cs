using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class IntegerMetaData : PropertyMetaData
    {
        [DataMember]
        public int MinValue { get; set; }
        [DataMember]
        public int MaxValue { get; set; }
    }
}
