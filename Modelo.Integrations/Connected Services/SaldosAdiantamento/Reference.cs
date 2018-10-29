﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaldosAdiantamento
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos", ConfigurationName="SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUT")]
    public interface SI_RetornarSaldosAdiantamentos_OUT
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTResponse> SI_RetornarSaldosAdiantamentos_OUTAsync(SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos")]
    public partial class DT_Fornecedor
    {
        
        private string fornecedorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Fornecedor
        {
            get
            {
                return this.fornecedorField;
            }
            set
            {
                this.fornecedorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos")]
    public partial class DT_Retorno
    {
        
        private string statusField;
        
        private string mensagemField;
        
        private DT_RetornoAdiantamento[] adiantamentoField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Adiantamento", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public DT_RetornoAdiantamento[] Adiantamento
        {
            get
            {
                return this.adiantamentoField;
            }
            set
            {
                this.adiantamentoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos")]
    public partial class DT_RetornoAdiantamento
    {
        
        private string numSolAdiantamentoField;
        
        private string exercicioField;
        
        private string itemField;
        
        private string numAdiantamentoField;
        
        private string referenciaField;
        
        private string vencimentoField;
        
        private string empresaField;
        
        private string divisaoField;
        
        private string descrDivisaoField;
        
        private string montanteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string NumSolAdiantamento
        {
            get
            {
                return this.numSolAdiantamentoField;
            }
            set
            {
                this.numSolAdiantamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Exercicio
        {
            get
            {
                return this.exercicioField;
            }
            set
            {
                this.exercicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string NumAdiantamento
        {
            get
            {
                return this.numAdiantamentoField;
            }
            set
            {
                this.numAdiantamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Referencia
        {
            get
            {
                return this.referenciaField;
            }
            set
            {
                this.referenciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Vencimento
        {
            get
            {
                return this.vencimentoField;
            }
            set
            {
                this.vencimentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string DescrDivisao
        {
            get
            {
                return this.descrDivisaoField;
            }
            set
            {
                this.descrDivisaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string Montante
        {
            get
            {
                return this.montanteField;
            }
            set
            {
                this.montanteField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_RetornarSaldosAdiantamentos_OUTRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos", Order=0)]
        public SaldosAdiantamento.DT_Fornecedor MT_Fornecedor;
        
        public SI_RetornarSaldosAdiantamentos_OUTRequest()
        {
        }
        
        public SI_RetornarSaldosAdiantamentos_OUTRequest(SaldosAdiantamento.DT_Fornecedor MT_Fornecedor)
        {
            this.MT_Fornecedor = MT_Fornecedor;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_RetornarSaldosAdiantamentos_OUTResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos", Order=0)]
        public SaldosAdiantamento.DT_Retorno MT_Retorno;
        
        public SI_RetornarSaldosAdiantamentos_OUTResponse()
        {
        }
        
        public SI_RetornarSaldosAdiantamentos_OUTResponse(SaldosAdiantamento.DT_Retorno MT_Retorno)
        {
            this.MT_Retorno = MT_Retorno;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SI_RetornarSaldosAdiantamentos_OUTChannel : SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUT, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SI_RetornarSaldosAdiantamentos_OUTClient : System.ServiceModel.ClientBase<SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUT>, SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUT
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SI_RetornarSaldosAdiantamentos_OUTClient() : 
                base(SI_RetornarSaldosAdiantamentos_OUTClient.GetDefaultBinding(), SI_RetornarSaldosAdiantamentos_OUTClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SI_RetornarSaldosAdiantamentos_OUTPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarSaldosAdiantamentos_OUTClient(EndpointConfiguration endpointConfiguration) : 
                base(SI_RetornarSaldosAdiantamentos_OUTClient.GetBindingForEndpoint(endpointConfiguration), SI_RetornarSaldosAdiantamentos_OUTClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarSaldosAdiantamentos_OUTClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SI_RetornarSaldosAdiantamentos_OUTClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarSaldosAdiantamentos_OUTClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SI_RetornarSaldosAdiantamentos_OUTClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarSaldosAdiantamentos_OUTClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTResponse> SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUT.SI_RetornarSaldosAdiantamentos_OUTAsync(SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTRequest request)
        {
            return base.Channel.SI_RetornarSaldosAdiantamentos_OUTAsync(request);
        }
        
        public System.Threading.Tasks.Task<SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTResponse> SI_RetornarSaldosAdiantamentos_OUTAsync(SaldosAdiantamento.DT_Fornecedor MT_Fornecedor)
        {
            SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTRequest inValue = new SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUTRequest();
            inValue.MT_Fornecedor = MT_Fornecedor;
            return ((SaldosAdiantamento.SI_RetornarSaldosAdiantamentos_OUT)(this)).SI_RetornarSaldosAdiantamentos_OUTAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SI_RetornarSaldosAdiantamentos_OUTPort))
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
            if ((endpointConfiguration == EndpointConfiguration.SI_RetornarSaldosAdiantamentos_OUTPort))
            {
                return new System.ServiceModel.EndpointAddress("http://mrvsap15.mrvbh.local:50200/sap/xi/engine?type=entry&version=3.0&Sender.Ser" +
                        "vice=MRVFramework&Interface=urn:br:com:mrv:FI003_RetornarSaldosAdiantamentos^SI_" +
                        "RetornarSaldosAdiantamentos_OUT");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SI_RetornarSaldosAdiantamentos_OUTClient.GetBindingForEndpoint(EndpointConfiguration.SI_RetornarSaldosAdiantamentos_OUTPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SI_RetornarSaldosAdiantamentos_OUTClient.GetEndpointAddress(EndpointConfiguration.SI_RetornarSaldosAdiantamentos_OUTPort);
        }
        
        public enum EndpointConfiguration
        {
            
            SI_RetornarSaldosAdiantamentos_OUTPort,
        }
    }
}
