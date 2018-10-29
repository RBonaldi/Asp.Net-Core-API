//------------------------------------------------------------------------------
// <gerado automaticamente>
//     Esse código foi gerado por uma ferramenta.
//     //
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </gerado automaticamente>
//------------------------------------------------------------------------------

namespace ValidarFornecedor
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:br:com:mrv:MM003_ValidarFornecedor", ConfigurationName="ValidarFornecedor.SI_ValidarFornecedor_OUT")]
    public interface SI_ValidarFornecedor_OUT
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ValidarFornecedor.SI_ValidarFornecedor_OUTResponse> SI_ValidarFornecedor_OUTAsync(ValidarFornecedor.SI_ValidarFornecedor_OUTRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:MM003_ValidarFornecedor")]
    public partial class DT_Fornecedor
    {
        
        private string codFornecedorField;
        
        private string cGCFornecedorField;
        
        private string cPFFornecedorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodFornecedor
        {
            get
            {
                return this.codFornecedorField;
            }
            set
            {
                this.codFornecedorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CGCFornecedor
        {
            get
            {
                return this.cGCFornecedorField;
            }
            set
            {
                this.cGCFornecedorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CPFFornecedor
        {
            get
            {
                return this.cPFFornecedorField;
            }
            set
            {
                this.cPFFornecedorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:MM003_ValidarFornecedor")]
    public partial class DT_Retorno
    {
        
        private string statusField;
        
        private string mensagemField;
        
        private DT_RetornoRetorno retornoField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:MM003_ValidarFornecedor")]
    public partial class DT_RetornoRetorno
    {
        
        private string codfrnField;
        
        private string nomfrnzField;
        
        private string codcntctbField;
        
        private string codcgcfrnField;
        
        private string codcpffrnField;
        
        private string numinsmncField;
        
        private string codgrpcntfrnField;
        
        private string numtlfField;
        
        private string numtlfcelField;
        
        private string numfaxField;
        
        private string endfrnField;
        
        private string descplendField;
        
        private string nombaiField;
        
        private string codcepfrnField;
        
        private string nomcidField;
        
        private string codestField;
        
        private string datisrrgtField;
        
        private string indeclrgtField;
        
        private string idtfrnField;
        
        private string nomrpnlglField;
        
        private string cpfrpnlglField;
        
        private string nomcnrField;
        
        private string numtlfcnrField;
        
        private string nomcplfrnField;
        
        private string desddorecaltpagField;
        
        private string idtfrniemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Codfrn
        {
            get
            {
                return this.codfrnField;
            }
            set
            {
                this.codfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Nomfrnz
        {
            get
            {
                return this.nomfrnzField;
            }
            set
            {
                this.nomfrnzField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Codcntctb
        {
            get
            {
                return this.codcntctbField;
            }
            set
            {
                this.codcntctbField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Codcgcfrn
        {
            get
            {
                return this.codcgcfrnField;
            }
            set
            {
                this.codcgcfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Codcpffrn
        {
            get
            {
                return this.codcpffrnField;
            }
            set
            {
                this.codcpffrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Numinsmnc
        {
            get
            {
                return this.numinsmncField;
            }
            set
            {
                this.numinsmncField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Codgrpcntfrn
        {
            get
            {
                return this.codgrpcntfrnField;
            }
            set
            {
                this.codgrpcntfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Numtlf
        {
            get
            {
                return this.numtlfField;
            }
            set
            {
                this.numtlfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Numtlfcel
        {
            get
            {
                return this.numtlfcelField;
            }
            set
            {
                this.numtlfcelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string Numfax
        {
            get
            {
                return this.numfaxField;
            }
            set
            {
                this.numfaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string Endfrn
        {
            get
            {
                return this.endfrnField;
            }
            set
            {
                this.endfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string Descplend
        {
            get
            {
                return this.descplendField;
            }
            set
            {
                this.descplendField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string Nombai
        {
            get
            {
                return this.nombaiField;
            }
            set
            {
                this.nombaiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string Codcepfrn
        {
            get
            {
                return this.codcepfrnField;
            }
            set
            {
                this.codcepfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string Nomcid
        {
            get
            {
                return this.nomcidField;
            }
            set
            {
                this.nomcidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string Codest
        {
            get
            {
                return this.codestField;
            }
            set
            {
                this.codestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string Datisrrgt
        {
            get
            {
                return this.datisrrgtField;
            }
            set
            {
                this.datisrrgtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string Indeclrgt
        {
            get
            {
                return this.indeclrgtField;
            }
            set
            {
                this.indeclrgtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string Idtfrn
        {
            get
            {
                return this.idtfrnField;
            }
            set
            {
                this.idtfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public string Nomrpnlgl
        {
            get
            {
                return this.nomrpnlglField;
            }
            set
            {
                this.nomrpnlglField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string Cpfrpnlgl
        {
            get
            {
                return this.cpfrpnlglField;
            }
            set
            {
                this.cpfrpnlglField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string Nomcnr
        {
            get
            {
                return this.nomcnrField;
            }
            set
            {
                this.nomcnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string Numtlfcnr
        {
            get
            {
                return this.numtlfcnrField;
            }
            set
            {
                this.numtlfcnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public string Nomcplfrn
        {
            get
            {
                return this.nomcplfrnField;
            }
            set
            {
                this.nomcplfrnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public string Desddorecaltpag
        {
            get
            {
                return this.desddorecaltpagField;
            }
            set
            {
                this.desddorecaltpagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public string Idtfrniem
        {
            get
            {
                return this.idtfrniemField;
            }
            set
            {
                this.idtfrniemField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_ValidarFornecedor_OUTRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:MM003_ValidarFornecedor", Order=0)]
        public ValidarFornecedor.DT_Fornecedor MT_ValidarFornecedor;
        
        public SI_ValidarFornecedor_OUTRequest()
        {
        }
        
        public SI_ValidarFornecedor_OUTRequest(ValidarFornecedor.DT_Fornecedor MT_ValidarFornecedor)
        {
            this.MT_ValidarFornecedor = MT_ValidarFornecedor;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_ValidarFornecedor_OUTResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:MM003_ValidarFornecedor", Order=0)]
        public ValidarFornecedor.DT_Retorno MT_Retorno;
        
        public SI_ValidarFornecedor_OUTResponse()
        {
        }
        
        public SI_ValidarFornecedor_OUTResponse(ValidarFornecedor.DT_Retorno MT_Retorno)
        {
            this.MT_Retorno = MT_Retorno;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SI_ValidarFornecedor_OUTChannel : ValidarFornecedor.SI_ValidarFornecedor_OUT, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SI_ValidarFornecedor_OUTClient : System.ServiceModel.ClientBase<ValidarFornecedor.SI_ValidarFornecedor_OUT>, ValidarFornecedor.SI_ValidarFornecedor_OUT
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
    /// </summary>
    /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
    /// <param name="clientCredentials">As credenciais do cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SI_ValidarFornecedor_OUTClient() : 
                base(SI_ValidarFornecedor_OUTClient.GetDefaultBinding(), SI_ValidarFornecedor_OUTClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SI_ValidarFornecedor_OUTPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarFornecedor_OUTClient(EndpointConfiguration endpointConfiguration) : 
                base(SI_ValidarFornecedor_OUTClient.GetBindingForEndpoint(endpointConfiguration), SI_ValidarFornecedor_OUTClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarFornecedor_OUTClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SI_ValidarFornecedor_OUTClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarFornecedor_OUTClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SI_ValidarFornecedor_OUTClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_ValidarFornecedor_OUTClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ValidarFornecedor.SI_ValidarFornecedor_OUTResponse> ValidarFornecedor.SI_ValidarFornecedor_OUT.SI_ValidarFornecedor_OUTAsync(ValidarFornecedor.SI_ValidarFornecedor_OUTRequest request)
        {
            return base.Channel.SI_ValidarFornecedor_OUTAsync(request);
        }
        
        public System.Threading.Tasks.Task<ValidarFornecedor.SI_ValidarFornecedor_OUTResponse> SI_ValidarFornecedor_OUTAsync(ValidarFornecedor.DT_Fornecedor MT_ValidarFornecedor)
        {
            ValidarFornecedor.SI_ValidarFornecedor_OUTRequest inValue = new ValidarFornecedor.SI_ValidarFornecedor_OUTRequest();
            inValue.MT_ValidarFornecedor = MT_ValidarFornecedor;
            return ((ValidarFornecedor.SI_ValidarFornecedor_OUT)(this)).SI_ValidarFornecedor_OUTAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SI_ValidarFornecedor_OUTPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SI_ValidarFornecedor_OUTPort))
            {
                return new System.ServiceModel.EndpointAddress("http://mrvsap15.mrvbh.local:50200/sap/xi/engine?type=entry&version=3.0&Sender.Ser" +
                        "vice=MRVFramework&Interface=urn:br:com:mrv:MM003_ValidarFornecedor^SI_ValidarFor" +
                        "necedor_OUT");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SI_ValidarFornecedor_OUTClient.GetBindingForEndpoint(EndpointConfiguration.SI_ValidarFornecedor_OUTPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SI_ValidarFornecedor_OUTClient.GetEndpointAddress(EndpointConfiguration.SI_ValidarFornecedor_OUTPort);
        }
        
        public enum EndpointConfiguration
        {
            
            SI_ValidarFornecedor_OUTPort,
        }
    }
}
