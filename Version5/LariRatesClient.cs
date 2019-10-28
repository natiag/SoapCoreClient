using ServiceReference1;
using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;


namespace Version5
{
    public class LariRatesClient : ILariRatesClient
    {
        private readonly HttpClient _httpClient;
        public LariRatesClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IReadOnlyCollection<CurrencyRate>> GetRates()
        {
            var envelope = RatesApiConstants.RequestEnvelope;
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(envelope, System.Text.Encoding.UTF8, "text/xml");
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false);

                //var sdasd = await response_.Content.ReadAsStreamAsync();
                //return null;
                using (var responseStream = await response_.Content.ReadAsStreamAsync())
                {
                    //  return _deserializer.Deserialize(responseStream);
                    DataContractSerializer dcs = new DataContractSerializer(typeof(Envelope<GetCurrentRatesResponseBody>));

                    using (XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(responseStream, new XmlDictionaryReaderQuotas()))
                    {
                        var p = (Envelope<GetCurrentRatesResponseBody>)dcs.ReadObject(reader);
                        return p?.Body?.tt?.GetCurrentRatesResult;
                    }
                }
            }
        }
    }
}
