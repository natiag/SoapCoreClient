using ServiceReference1;
using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Version2
{
    public class LariRatesClient : ILariRatesClient
    {
        private readonly HttpClient _httpClient;

        public LariRatesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<CurrencyRate>> GetRates()
        {
            GetCurrentRatesResponseBody result;

            var envelope = RatesApiConstants.RequestEnvelope;
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(envelope, System.Text.Encoding.UTF8, "text/xml");
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false);

                var responseData_ = response_.Content == null ? null : response_.Content.ReadAsStringAsync().Result;

                result = Deserialize<GetCurrentRatesResponseBody>(responseData_);
            }
            return result.GetCurrentRatesResult;
        }


        private T Deserialize<T>(string response)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(response);
            DataContractSerializer dcs = new DataContractSerializer(typeof(Envelope<T>));

            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(bytes, new XmlDictionaryReaderQuotas());

            var p = (Envelope<T>)dcs.ReadObject(reader);


            return p.Body.tt;
        }

    }
}
