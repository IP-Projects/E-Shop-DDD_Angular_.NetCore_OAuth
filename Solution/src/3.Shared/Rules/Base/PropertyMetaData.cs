using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public abstract class PropertyMetaData
    {
        [DataMember]
        public bool Required { get; set; }

        [DataMember]
        public string DefaultResource { get; set; }
    }
}
