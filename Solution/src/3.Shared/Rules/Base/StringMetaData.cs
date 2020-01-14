using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class StringMetaData : PropertyMetaData<string>
    {
        [DataMember]
        public int MinLength { get; set; }

        [DataMember]
        public int MaxLength { get; set; }

        [DataMember]
        public bool IsAlphabetic { get; set; }

        [DataMember]
        public bool IsAlphaNumeric { get; set; }

        [DataMember]
        public EContentType ContentType { get; set; }

        public enum EContentType
        {
            Other,
            Url,
            Email,
        }
    }
}
