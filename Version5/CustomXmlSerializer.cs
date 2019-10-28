using ServiceReference1;
using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace Version5
{
    public class CustomXmlDeserializer
    {
        public IReadOnlyCollection<CurrencyRate> Deserialize(Stream stream)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(Envelope<GetCurrentRatesResponseBody>));

            using (XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
            {
                var p = (Envelope<GetCurrentRatesResponseBody>)dcs.ReadObject(reader);
                return p?.Body?.tt?.GetCurrentRatesResult;
            }
        }
    }
}
