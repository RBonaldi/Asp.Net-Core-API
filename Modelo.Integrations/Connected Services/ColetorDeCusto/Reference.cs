﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColetorDeCusto
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:br:com:mrv:MM002_ValidarColetorCusto", ConfigurationName="ColetorDeCusto.SI_ValidarColetorCusto_OUT")]
    public interface SI_ValidarColetorCusto_OUT
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ColetorDeCusto.SI_ValidarColetorCusto_OUTResponse> SI_ValidarColetorCusto_OUTAsync(ColetorDeCusto.SI_ValidarColetorCusto_OUTRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:MM002_ValidarColetorCusto")]
    public partial class DT_ColetorCusto
    {
        
        private string empresaCentroField;
        
        private string divisaoCentroField;
        
        private string centroField;
        
        private DT_ColetorCustoColetorCusto[] coletorCustoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string EmpresaCentro
        {
            get
            {
                return this.empresaCentroField;
            }
            set
            {
                this.empresaCentroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string DivisaoCentro
        {
            get
            {
                return this.divisaoCentroField;
            }
            set
            {
                this.divisaoCentroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Centro
        {
            get
            {
                return this.centroField;
            }
            set
            {
                this.centroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ColetorCusto", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public DT_ColetorCustoColetorCusto[] ColetorCusto
        {
            get
            {
                return this.coletorCustoField;
            }
            set
            {
                this.coletorCustoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:MM002_ValidarColetorCusto")]
    public partial class DT_ColetorCustoColetorCusto
    {
        
        private string catClassContField;
        
        private string codColetorCustoField;
        
        private string numOperacaoField;
        
        private string empresaField;
        
        private string materialField;
        
        private string contaContabilField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CatClassCont
        {
            get
            {
                return this.catClassContField;
            }
            set
            {
                this.catClassContField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CodColetorCusto
        {
            get
            {
                return this.codColetorCustoField;
            }
            set
            {
                this.codColetorCustoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumOperacao
        {
            get
            {
                return this.numOperacaoField;
            }
            set
            {
                this.numOperacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Empresa
        {
            get
            {
                return this.empresaField;
            }
            set
            {
                this.empresaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string ContaContabil
        {
            get
            {
                return this.contaContabilField;
            }
            set
            {
                this.contaContabilField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:MM002_ValidarColetorCusto")]
    public partial class DT_Retorno
    {
        
        private DT_RetornoRetorno retornoField;
        
        private DT_RetornoRetornoStatus[] retornoStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public DT_RetornoRetorno Retorno
        {
            get
            {
                return this.retornoField;
            }
            set
            {
                this.retornoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RetornoStatus", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DT_RetornoRetornoStatus[] RetornoStatus
        {
            get
            {
                return this.retornoStatusField;
            }
            set
            {
                this.retornoStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:MM002_ValidarColetorCusto")]
    public partial class DT_RetornoRetorno
    {
        
        private string statusField;
        
        private string mensagemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:MM002_ValidarColetorCusto")]
    public partial class DT_RetornoRetornoStatus
    {
        
        private string catClassContField;
        
        private string codColetorCustoField;
        
        private string numOperacaoField;
        
        private string descColetorField;
        
        private string empresaField;
        
        private string divisaoField;
        
        private string centroField;
        
        private string contaContabilField;
        
        private string descMensagemField;
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CatClassCont
        {
            get
            {
                return this.catClassContField;
            }
            set
            {
                this.catClassContField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CodColetorCusto
        {
            get
            {
                return this.codColetorCustoField;
            }
            set
            {
                this.codColetorCustoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumOperacao
        {
            get
            {
                return this.numOperacaoField;
            }
            set
            {
                this.numOperacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string DescColetor
        {
            get
            {
                return this.descColetorField;
            }
            set
            {
                this.descColetorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Empresa
        {
            get
            {
                return this.empresaField;
            }
            set
            {
                this.empresaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Divisao
        {
            get
            {
                return this.divisaoField;
            }
            set
            {
                this.divisaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Centro
        {
            get
            {
                return this.centroField;
            }
            set
            {
                this.centroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ContaContabil
        {
            get
            {
                return this.contaContabilField;
            }
            set
            {
                this.contaContabilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string DescMensagem
        {
            get
            {
                return this.descMensagemField;
            }
            set
            {
                this.descMensagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_ValidarColetorCusto_OUTRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:MM001_ValidarColetorCusto", Order=0)]
        public ColetorDeCusto.DT_ColetorCusto MT_ColetorCusto;
        
        public SI_ValidarColetorCusto_OUTRequest()
        {
        }
        
        public SI_ValidarColetorCusto_OUTRequest(ColetorDeCusto.DT_ColetorCusto MT_ColetorCusto)
        {
            this.MT_ColetorCusto = MT_ColetorCusto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_ValidarColetorCusto_OUTResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:MM001_ValidarColetorCusto", Order=0)]
        public ColetorDeCusto.DT_Retorno MT_Retorno;
        
        public SI_ValidarColetorCusto_OUTResponse()
        {
        }
        
        public SI_ValidarColetorCusto_OUTResponse(ColetorDeCusto.DT_Retorno MT_Retorno)
        {
            this.MT_Retorno = MT_Retorno;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SI_ValidarColetorCusto_OUTChannel : ColetorDeCusto.SI_ValidarColetorCusto_OUT, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SI_ValidarColetorCusto_OUTClient : System.ServiceModel.ClientBase<ColetorDeCusto.SI_ValidarColetorCusto_OUT>, ColetorDeCusto.SI_ValidarColetorCusto_OUT
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SI_ValidarColetorCusto_OUTClient() : 
                base(SI_ValidarColetorCusto_OUTClient.GetDefaultBinding(), SI_ValidarColetorCusto_OUTClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SI_ValidarColetorCusto_OUTPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarColetorCusto_OUTClient(EndpointConfiguration endpointConfiguration) : 
                base(SI_ValidarColetorCusto_OUTClient.GetBindingForEndpoint(endpointConfiguration), SI_ValidarColetorCusto_OUTClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarColetorCusto_OUTClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SI_ValidarColetorCusto_OUTClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarColetorCusto_OUTClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SI_ValidarColetorCusto_OUTClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarColetorCusto_OUTClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ColetorDeCusto.SI_ValidarColetorCusto_OUTResponse> ColetorDeCusto.SI_ValidarColetorCusto_OUT.SI_ValidarColetorCusto_OUTAsync(ColetorDeCusto.SI_ValidarColetorCusto_OUTRequest request)
        {
            return base.Channel.SI_ValidarColetorCusto_OUTAsync(request);
        }
        
        public System.Threading.Tasks.Task<ColetorDeCusto.SI_ValidarColetorCusto_OUTResponse> SI_ValidarColetorCusto_OUTAsync(ColetorDeCusto.DT_ColetorCusto MT_ColetorCusto)
        {
            ColetorDeCusto.SI_ValidarColetorCusto_OUTRequest inValue = new ColetorDeCusto.SI_ValidarColetorCusto_OUTRequest();
            inValue.MT_ColetorCusto = MT_ColetorCusto;
            return ((ColetorDeCusto.SI_ValidarColetorCusto_OUT)(this)).SI_ValidarColetorCusto_OUTAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SI_ValidarColetorCusto_OUTPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SI_ValidarColetorCusto_OUTPort))
            {
                return new System.ServiceModel.EndpointAddress("http://mrvsap15.mrvbh.local:50200/sap/xi/engine?type=entry&version=3.0&Sender.Ser" +
                        "vice=MRVFramework&Interface=urn:br:com:mrv:MM002_ValidarColetorCusto^SI_ValidarC" +
                        "oletorCusto_OUT");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SI_ValidarColetorCusto_OUTClient.GetBindingForEndpoint(EndpointConfiguration.SI_ValidarColetorCusto_OUTPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SI_ValidarColetorCusto_OUTClient.GetEndpointAddress(EndpointConfiguration.SI_ValidarColetorCusto_OUTPort);
        }
        
        public enum EndpointConfiguration
        {
            
            SI_ValidarColetorCusto_OUTPort,
        }
    }
}