using System;
using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class TimeSpanMetaData : PropertyMetaData<TimeSpan>
    {
        [DataMember]
        public TimeSpan Start { get; set; }
        [DataMember]
        public TimeSpan End { get; set; }
    }
}
