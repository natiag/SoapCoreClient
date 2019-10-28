using System.Runtime.Serialization;

namespace SoapTest.Common
{
    [DataContract(Name = "Body", Namespace = "http://tempuri.org/")]
    public class EnvelopeBody<T>
    {
        [DataMember(Name = "GetCurrentRatesResponse", Order = 0)]
        public T tt;
    }
}
