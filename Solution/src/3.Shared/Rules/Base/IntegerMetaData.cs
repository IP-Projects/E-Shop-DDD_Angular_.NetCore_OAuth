using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class IntegerMetaData : PropertyMetaData<int>
    {
        [DataMember]
        public int MinValue { get; set; }
        [DataMember]
        public int MaxValue { get; set; }
    }
}
