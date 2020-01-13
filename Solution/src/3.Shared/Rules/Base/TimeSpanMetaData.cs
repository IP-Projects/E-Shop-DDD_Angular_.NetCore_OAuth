using System;
using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class TimeSpanMetaData : PropertyMetaData
    {
        [DataMember]
        public TimeSpan Start { get; set; }
        [DataMember]
        public TimeSpan End { get; set; }
    }
}
