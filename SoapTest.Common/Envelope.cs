using System.Runtime.Serialization;

namespace SoapTest.Common
{
    [DataContract(Name = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope<T>
    {
        [DataMember(Name = "Body", Order = 1)]
        public EnvelopeBody<T> Body;
    }
}
