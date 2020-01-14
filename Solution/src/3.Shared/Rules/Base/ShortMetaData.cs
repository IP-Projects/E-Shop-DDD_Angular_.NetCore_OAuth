using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class ShortMetaData : PropertyMetaData<short>
    {
        [DataMember]
        public short MinValue { get; set; }
        [DataMember]
        public short MaxValue { get; set; }
    }
}
