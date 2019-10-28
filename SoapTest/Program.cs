using Newtonsoft.Json;
using ServiceReference1;
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace SoapTest
{
    class Program
    {
        static string WrapInEnvilope(string body)
        {
            return $@"<?xml version='1.0' encoding='utf-8'?>
                                <soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' 
                                             xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'>
                                  <soap:Body>
                                  {body}
                                  </soap:Body>
                                </soap:Envelope>";
        }
        static void Main(string[] args)
        {
            var envelope = "";
            var p = new GetCurrentRatesRequestBody { Currencies = "USD" };
            DataContractSerializer dcs = new DataContractSerializer(typeof(GetCurrentRatesRequestBody));

            using (var stream = new MemoryStream())
            {
                using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings { OmitXmlDeclaration = true, Encoding = new UTF8Encoding(false) }))
                {
                    dcs.WriteObject(writer, p);
                }
                var settingsString = Encoding.UTF8.GetString(stream.ToArray());

                envelope = WrapInEnvilope(settingsString);
            }
            //   XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(someStream, Encoding.UTF8);


            string url = "https://services.nbg.gov.ge/Rates/Service.asmx?wsdl";
            var client_ = new HttpClient();

            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(envelope, System.Text.Encoding.UTF8, "text/xml");
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));
                var url_ = url;
                request_.RequestUri = new System.Uri(url_, System.UriKind.Absolute);

                var response_ = client_.SendAsync(request_).Result;

                //Console.WriteLine("http response: " + JsonConvert.SerializeObject(response_));
                var responseData_ = response_.Content == null ? null : response_.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseData_);
                //var responseObj = OnlineBankingSoapServHelper.DeserializeXmlResponse(responseData_);
                //Console.WriteLine("serialized object: " + JsonConvert.SerializeObject(responseObj));
                // responseObj;


                GetCurrentRatesResponseBody asd =  Deserialize<GetCurrentRatesResponseBody>(responseData_);


            }


            Console.WriteLine("Hello World!");
        }


        static T Deserialize<T>(string response)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(response);
            DataContractSerializer dcs = new DataContractSerializer(typeof(Envelope<T>));

            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(bytes, new XmlDictionaryReaderQuotas());

            var p = (Envelope<T>)dcs.ReadObject(reader);


            return p.Body.tt;
        }

    }

    [DataContract(Name = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope<T>
    {
        [DataMember(Name = "Body", Order = 1)]
        public EnvelopeBody<T> Body;
    }

    [DataContract(Name = "Body", Namespace = "http://www.nbg.ge/")]
    public class EnvelopeBody<T>
    {
        [DataMember(Name = "GetCurrentRatesResponse", Order = 0)]
        public T tt;
    }


}
