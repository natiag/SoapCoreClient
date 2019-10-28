namespace SoapTest.Common
{
    public class RatesApiConstants
    {
       // public const string ApiBaseUrl = "https://services.nbg.gov.ge/Rates/Service.asmx?wsdl";
       //// public const string RepositoriesPath = "/api/github/repositories";
       // public const string RequestEnvelope = @"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:nbg='http://www.nbg.ge/'>
       //                    <soapenv:Header/>
       //                    <soapenv:Body>
       //                       <nbg:GetCurrentRates>
                               
       //                       </nbg:GetCurrentRates>
       //                    </soapenv:Body>
       //                 </soapenv:Envelope>";//  <nbg:Currencies>USD,EUR</nbg:Currencies>   
        
        public const string ApiBaseUrl = "https://soap-test.azurewebsites.net/rates.asmx?WSDL";

        public const string RequestEnvelope = @"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:tem='http://tempuri.org/'>
                                                   <soapenv:Header/>
                                                   <soapenv:Body>
                                                      <tem:GetCurrentRates/>
                                                   </soapenv:Body>
                                                </soapenv:Envelope>";
    }
}
