﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TipoDocumento
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas", ConfigurationName="TipoDocumento.SI_RetornarTipos_OUT")]
    public interface SI_RetornarTipos_OUT
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TipoDocumento.SI_RetornarTiposDocumentos_OUTResponse> SI_RetornarTiposDocumentos_OUTAsync(TipoDocumento.SI_RetornarTiposDocumentos_OUTRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TipoDocumento.SI_RetornarTiposDespesas_OUTResponse> SI_RetornarTiposDespesas_OUTAsync(TipoDocumento.SI_RetornarTiposDespesas_OUTRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas")]
    public partial class DT_TiposDocumentos
    {
        
        private string codDocumentosField;
        
        private string tipoDocumentosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodDocumentos
        {
            get
            {
                return this.codDocumentosField;
            }
            set
            {
                this.codDocumentosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TipoDocumentos
        {
            get
            {
                return this.tipoDocumentosField;
            }
            set
            {
                this.tipoDocumentosField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas")]
    public partial class DT_RetornoDespesas
    {
        
        private string statusField;
        
        private string messageField;
        
        private DT_RetornoDespesasRetorno[] retornoField;
        
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
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Retorno", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public DT_RetornoDespesasRetorno[] Retorno
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas")]
    public partial class DT_RetornoDespesasRetorno
    {
        
        private string codDocumentoField;
        
        private string tipoDocumentoField;
        
        private string codDespesaField;
        
        private string tipoDespesaField;
        
        private string contaRazaoField;
        
        private string razaoEspecialField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodDocumento
        {
            get
            {
                return this.codDocumentoField;
            }
            set
            {
                this.codDocumentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TipoDocumento
        {
            get
            {
                return this.tipoDocumentoField;
            }
            set
            {
                this.tipoDocumentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CodDespesa
        {
            get
            {
                return this.codDespesaField;
            }
            set
            {
                this.codDespesaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string TipoDespesa
        {
            get
            {
                return this.tipoDespesaField;
            }
            set
            {
                this.tipoDespesaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ContaRazao
        {
            get
            {
                return this.contaRazaoField;
            }
            set
            {
                this.contaRazaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string RazaoEspecial
        {
            get
            {
                return this.razaoEspecialField;
            }
            set
            {
                this.razaoEspecialField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas")]
    public partial class DT_TiposDespesas
    {
        
        private string codDocumentoField;
        
        private string tipoDocumentoField;
        
        private string codDespesaField;
        
        private string tipoDespesaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodDocumento
        {
            get
            {
                return this.codDocumentoField;
            }
            set
            {
                this.codDocumentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TipoDocumento
        {
            get
            {
                return this.tipoDocumentoField;
            }
            set
            {
                this.tipoDocumentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CodDespesa
        {
            get
            {
                return this.codDespesaField;
            }
            set
            {
                this.codDespesaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string TipoDespesa
        {
            get
            {
                return this.tipoDespesaField;
            }
            set
            {
                this.tipoDespesaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas")]
    public partial class DT_RetornoDocumento
    {
        
        private string statusField;
        
        private DT_RetornoDocumentoRetorno[] retornoField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("Retorno", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DT_RetornoDocumentoRetorno[] Retorno
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas")]
    public partial class DT_RetornoDocumentoRetorno
    {
        
        private string codDocumentoField;
        
        private string tipoDocumentoField;
        
        private string tipoDocumentoSapField;
        
        private string codFuncionalidadeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodDocumento
        {
            get
            {
                return this.codDocumentoField;
            }
            set
            {
                this.codDocumentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TipoDocumento
        {
            get
            {
                return this.tipoDocumentoField;
            }
            set
            {
                this.tipoDocumentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string TipoDocumentoSap
        {
            get
            {
                return this.tipoDocumentoSapField;
            }
            set
            {
                this.tipoDocumentoSapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string CodFuncionalidade
        {
            get
            {
                return this.codFuncionalidadeField;
            }
            set
            {
                this.codFuncionalidadeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_RetornarTiposDocumentos_OUTRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas", Order=0)]
        public TipoDocumento.DT_TiposDocumentos MT_TiposDocumentos;
        
        public SI_RetornarTiposDocumentos_OUTRequest()
        {
        }
        
        public SI_RetornarTiposDocumentos_OUTRequest(TipoDocumento.DT_TiposDocumentos MT_TiposDocumentos)
        {
            this.MT_TiposDocumentos = MT_TiposDocumentos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_RetornarTiposDocumentos_OUTResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas", Order=0)]
        public TipoDocumento.DT_RetornoDocumento MT_RetornoDocumento;
        
        public SI_RetornarTiposDocumentos_OUTResponse()
        {
        }
        
        public SI_RetornarTiposDocumentos_OUTResponse(TipoDocumento.DT_RetornoDocumento MT_RetornoDocumento)
        {
            this.MT_RetornoDocumento = MT_RetornoDocumento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_RetornarTiposDespesas_OUTRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas", Order=0)]
        public TipoDocumento.DT_TiposDespesas MT_TiposDespesas;
        
        public SI_RetornarTiposDespesas_OUTRequest()
        {
        }
        
        public SI_RetornarTiposDespesas_OUTRequest(TipoDocumento.DT_TiposDespesas MT_TiposDespesas)
        {
            this.MT_TiposDespesas = MT_TiposDespesas;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_RetornarTiposDespesas_OUTResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespesas", Order=0)]
        public TipoDocumento.DT_RetornoDespesas MT_RetornoDespesas;
        
        public SI_RetornarTiposDespesas_OUTResponse()
        {
        }
        
        public SI_RetornarTiposDespesas_OUTResponse(TipoDocumento.DT_RetornoDespesas MT_RetornoDespesas)
        {
            this.MT_RetornoDespesas = MT_RetornoDespesas;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SI_RetornarTipos_OUTChannel : TipoDocumento.SI_RetornarTipos_OUT, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SI_RetornarTipos_OUTClient : System.ServiceModel.ClientBase<TipoDocumento.SI_RetornarTipos_OUT>, TipoDocumento.SI_RetornarTipos_OUT
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SI_RetornarTipos_OUTClient(EndpointConfiguration endpointConfiguration) : 
                base(SI_RetornarTipos_OUTClient.GetBindingForEndpoint(endpointConfiguration), SI_RetornarTipos_OUTClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarTipos_OUTClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SI_RetornarTipos_OUTClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarTipos_OUTClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SI_RetornarTipos_OUTClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SI_RetornarTipos_OUTClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TipoDocumento.SI_RetornarTiposDocumentos_OUTResponse> TipoDocumento.SI_RetornarTipos_OUT.SI_RetornarTiposDocumentos_OUTAsync(TipoDocumento.SI_RetornarTiposDocumentos_OUTRequest request)
        {
            return base.Channel.SI_RetornarTiposDocumentos_OUTAsync(request);
        }
        
        public System.Threading.Tasks.Task<TipoDocumento.SI_RetornarTiposDocumentos_OUTResponse> SI_RetornarTiposDocumentos_OUTAsync(TipoDocumento.DT_TiposDocumentos MT_TiposDocumentos)
        {
            TipoDocumento.SI_RetornarTiposDocumentos_OUTRequest inValue = new TipoDocumento.SI_RetornarTiposDocumentos_OUTRequest();
            inValue.MT_TiposDocumentos = MT_TiposDocumentos;
            return ((TipoDocumento.SI_RetornarTipos_OUT)(this)).SI_RetornarTiposDocumentos_OUTAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TipoDocumento.SI_RetornarTiposDespesas_OUTResponse> TipoDocumento.SI_RetornarTipos_OUT.SI_RetornarTiposDespesas_OUTAsync(TipoDocumento.SI_RetornarTiposDespesas_OUTRequest request)
        {
            return base.Channel.SI_RetornarTiposDespesas_OUTAsync(request);
        }
        
        public System.Threading.Tasks.Task<TipoDocumento.SI_RetornarTiposDespesas_OUTResponse> SI_RetornarTiposDespesas_OUTAsync(TipoDocumento.DT_TiposDespesas MT_TiposDespesas)
        {
            TipoDocumento.SI_RetornarTiposDespesas_OUTRequest inValue = new TipoDocumento.SI_RetornarTiposDespesas_OUTRequest();
            inValue.MT_TiposDespesas = MT_TiposDespesas;
            return ((TipoDocumento.SI_RetornarTipos_OUT)(this)).SI_RetornarTiposDespesas_OUTAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.HTTP_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.TransportCredentialOnly;
                result.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.Basic;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.HTTPS_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HTTP_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://mrvsap15.mrvbh.local:50200/XISOAPAdapter/MessageServlet?senderParty=&sende" +
                        "rService=MRVFramework&receiverParty=&receiverService=&interface=SI_RetornarTipos" +
                        "_OUT&interfaceNamespace=urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespes" +
                        "as");
            }
            if ((endpointConfiguration == EndpointConfiguration.HTTPS_Port))
            {
                return new System.ServiceModel.EndpointAddress("https://mrvsap15.mrvbh.local:50201/XISOAPAdapter/MessageServlet?senderParty=&send" +
                        "erService=MRVFramework&receiverParty=&receiverService=&interface=SI_RetornarTipo" +
                        "s_OUT&interfaceNamespace=urn:br:com:mrv:FI001_RetornarTiposdocumentos_TiposDespe" +
                        "sas");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            HTTP_Port,
            
            HTTPS_Port,
        }
    }
}