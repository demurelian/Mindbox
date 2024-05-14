using System.Runtime.Serialization;

namespace GeometryLibrary.Controllers
{
    [DataContract]
    public class Request
    {
        [DataMember(Name = "a")]
        public int FirstSide { get; set; }
        [DataMember(Name = "b")]
        public int SecondSide { get; set; }
        [DataMember(Name = "c")]
        public int ThirdSide { get; set; }
        [DataMember(Name = "r")]
        public int Radius { get; set; }
    }
}
