﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CurrencyRate", Namespace = "http://www.nbg.ge/")]
    public partial class CurrencyRate : object
    {

        private string CodeField;

        private int QuantityField;

        private decimal RateField;

        private string NameField;

        private decimal DiffField;

        private System.DateTime DateField;

        private System.DateTime ValidFromDateField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int Quantity
        {
            get
            {
                return this.QuantityField;
            }
            set
            {
                this.QuantityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public decimal Rate
        {
            get
            {
                return this.RateField;
            }
            set
            {
                this.RateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 4)]
        public decimal Diff
        {
            get
            {
                return this.DiffField;
            }
            set
            {
                this.DiffField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 5)]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 6)]
        public System.DateTime ValidFromDate
        {
            get
            {
                return this.ValidFromDateField;
            }
            set
            {
                this.ValidFromDateField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.nbg.ge/", ConfigurationName = "ServiceReference1.ServiceSoap")]
    public interface ServiceSoap
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nbg.ge/GetCurrentRates", ReplyAction = "*")]
        System.Threading.Tasks.Task<ServiceReference1.GetCurrentRatesResponse> GetCurrentRatesAsync(ServiceReference1.GetCurrentRatesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.nbg.ge/GetLastRates", ReplyAction = "*")]
        System.Threading.Tasks.Task<ServiceReference1.GetLastRatesResponse> GetLastRatesAsync(ServiceReference1.GetLastRatesRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetCurrentRatesRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetCurrentRates", Namespace = "http://www.nbg.ge/", Order = 0)]
        public ServiceReference1.GetCurrentRatesRequestBody Body;

        public GetCurrentRatesRequest()
        {
        }

        public GetCurrentRatesRequest(ServiceReference1.GetCurrentRatesRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://www.nbg.ge/", Name = "GetCurrentRates")]
    public partial class GetCurrentRatesRequestBody
    {

        // [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        [DataMember]
        public string Currencies;

        public GetCurrentRatesRequestBody()
        {
        }

        public GetCurrentRatesRequestBody(string Currencies)
        {
            this.Currencies = Currencies;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetCurrentRatesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetCurrentRatesResponse", Namespace = "http://www.nbg.ge/", Order = 0)]
        public ServiceReference1.GetCurrentRatesResponseBody Body;

        public GetCurrentRatesResponse()
        {
        }

        public GetCurrentRatesResponse(ServiceReference1.GetCurrentRatesResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://www.nbg.ge/", Name = "GetCurrentRatesResponse")]
    public partial class GetCurrentRatesResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceReference1.CurrencyRate[] GetCurrentRatesResult;

        public GetCurrentRatesResponseBody()
        {
        }

        public GetCurrentRatesResponseBody(ServiceReference1.CurrencyRate[] GetCurrentRatesResult)
        {
            this.GetCurrentRatesResult = GetCurrentRatesResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetLastRatesRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetLastRates", Namespace = "http://www.nbg.ge/", Order = 0)]
        public ServiceReference1.GetLastRatesRequestBody Body;

        public GetLastRatesRequest()
        {
        }

        public GetLastRatesRequest(ServiceReference1.GetLastRatesRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://www.nbg.ge/")]
    public partial class GetLastRatesRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string Currencies;

        public GetLastRatesRequestBody()
        {
        }

        public GetLastRatesRequestBody(string Currencies)
        {
            this.Currencies = Currencies;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetLastRatesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetLastRatesResponse", Namespace = "http://www.nbg.ge/", Order = 0)]
        public ServiceReference1.GetLastRatesResponseBody Body;

        public GetLastRatesResponse()
        {
        }

        public GetLastRatesResponse(ServiceReference1.GetLastRatesResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://www.nbg.ge/")]
    public partial class GetLastRatesResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceReference1.CurrencyRate[] GetLastRatesResult;

        public GetLastRatesResponseBody()
        {
        }

        public GetLastRatesResponseBody(ServiceReference1.CurrencyRate[] GetLastRatesResult)
        {
            this.GetLastRatesResult = GetLastRatesResult;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public interface ServiceSoapChannel : ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<ServiceReference1.ServiceSoap>, ServiceReference1.ServiceSoap
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public ServiceSoapClient(EndpointConfiguration endpointConfiguration) :
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), ServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public ServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public ServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetCurrentRatesResponse> ServiceReference1.ServiceSoap.GetCurrentRatesAsync(ServiceReference1.GetCurrentRatesRequest request)
        {
            return base.Channel.GetCurrentRatesAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1.GetCurrentRatesResponse> GetCurrentRatesAsync(string Currencies)
        {
            ServiceReference1.GetCurrentRatesRequest inValue = new ServiceReference1.GetCurrentRatesRequest();
            inValue.Body = new ServiceReference1.GetCurrentRatesRequestBody();
            inValue.Body.Currencies = Currencies;
            return ((ServiceReference1.ServiceSoap)(this)).GetCurrentRatesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetLastRatesResponse> ServiceReference1.ServiceSoap.GetLastRatesAsync(ServiceReference1.GetLastRatesRequest request)
        {
            return base.Channel.GetLastRatesAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1.GetLastRatesResponse> GetLastRatesAsync(string Currencies)
        {
            ServiceReference1.GetLastRatesRequest inValue = new ServiceReference1.GetLastRatesRequest();
            inValue.Body = new ServiceReference1.GetLastRatesRequestBody();
            inValue.Body.Currencies = Currencies;
            return ((ServiceReference1.ServiceSoap)(this)).GetLastRatesAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://services.nbg.gov.ge/Rates/Service.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://services.nbg.gov.ge/Rates/Service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {

            ServiceSoap,

            ServiceSoap12,
        }
    }
}
