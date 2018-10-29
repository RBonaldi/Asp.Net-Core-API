//------------------------------------------------------------------------------
// <gerado automaticamente>
//     Esse código foi gerado por uma ferramenta.
//     //
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </gerado automaticamente>
//------------------------------------------------------------------------------

namespace Seguranca
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Seguranca.SegurancaSoap")]
    public interface SegurancaSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDateTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.DateTime> GetDateTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TokenValido", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> TokenValidoAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChaveValida", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> ChaveValidaAsync(System.Guid apiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UsuarioValidar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Seguranca.UsuarioValidarResponse> UsuarioValidarAsync(Seguranca.UsuarioValidarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UsuarioValidarPorLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Seguranca.UsuarioValidarPorLoginResponse> UsuarioValidarPorLoginAsync(Seguranca.UsuarioValidarPorLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UsuarioADListar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Seguranca.UsuarioADListarResponse> UsuarioADListarAsync(Seguranca.UsuarioADListarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UsuarioListarPorSistema", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Seguranca.UsuarioListarPorSistemaResponse> UsuarioListarPorSistemaAsync(Seguranca.UsuarioListarPorSistemaRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SegurancaSoapHeader
    {
        
        private WsUsuario usuarioField;
        
        private WsSistema sistemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WsUsuario Usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public WsSistema Sistema
        {
            get
            {
                return this.sistemaField;
            }
            set
            {
                this.sistemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class WsUsuario
    {
        
        private int codigoField;
        
        private string loginField;
        
        private string senhaField;
        
        private string iDOSDispositivoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Senha
        {
            get
            {
                return this.senhaField;
            }
            set
            {
                this.senhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string IDOSDispositivo
        {
            get
            {
                return this.iDOSDispositivoField;
            }
            set
            {
                this.iDOSDispositivoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class WsSistema
    {
        
        private int codigoField;
        
        private string nomeField;
        
        private string tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UsuarioSenhaInfo
    {
        
        private int codigoField;
        
        private System.Nullable<int> codigoUsuarioField;
        
        private string senhaField;
        
        private string senhaHashField;
        
        private System.DateTime dataCasdastroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> CodigoUsuario
        {
            get
            {
                return this.codigoUsuarioField;
            }
            set
            {
                this.codigoUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Senha
        {
            get
            {
                return this.senhaField;
            }
            set
            {
                this.senhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string SenhaHash
        {
            get
            {
                return this.senhaHashField;
            }
            set
            {
                this.senhaHashField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime DataCasdastro
        {
            get
            {
                return this.dataCasdastroField;
            }
            set
            {
                this.dataCasdastroField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SistemaInfo
    {
        
        private FuncionalidadeInfo[] funcionalidadesField;
        
        private int codigoField;
        
        private string nomeField;
        
        private string descricaoField;
        
        private GrupoInfo[] gruposField;
        
        private FuncionalidadeInfo[] funcionalidadesField1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public FuncionalidadeInfo[] funcionalidades
        {
            get
            {
                return this.funcionalidadesField;
            }
            set
            {
                this.funcionalidadesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        public GrupoInfo[] Grupos
        {
            get
            {
                return this.gruposField;
            }
            set
            {
                this.gruposField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        public FuncionalidadeInfo[] Funcionalidades
        {
            get
            {
                return this.funcionalidadesField1;
            }
            set
            {
                this.funcionalidadesField1 = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class FuncionalidadeInfo
    {
        
        private int codigoField;
        
        private System.Nullable<int> codigoFuncionalidadePaiField;
        
        private int codigoSitemaField;
        
        private string nomeField;
        
        private string descricaoField;
        
        private GrupoInfo[] gruposField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> CodigoFuncionalidadePai
        {
            get
            {
                return this.codigoFuncionalidadePaiField;
            }
            set
            {
                this.codigoFuncionalidadePaiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int CodigoSitema
        {
            get
            {
                return this.codigoSitemaField;
            }
            set
            {
                this.codigoSitemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        public GrupoInfo[] Grupos
        {
            get
            {
                return this.gruposField;
            }
            set
            {
                this.gruposField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GrupoInfo
    {
        
        private int codigoField;
        
        private int codigoSistemaField;
        
        private string nomeField;
        
        private string descricaoField;
        
        private int quantidadeFuncionalidadeField;
        
        private int quantidadeUsuariosField;
        
        private FuncionalidadeInfo[] funcionalidadesField;
        
        private string nomeSistemaField;
        
        private int codigoGrupoPaiField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int CodigoSistema
        {
            get
            {
                return this.codigoSistemaField;
            }
            set
            {
                this.codigoSistemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int QuantidadeFuncionalidade
        {
            get
            {
                return this.quantidadeFuncionalidadeField;
            }
            set
            {
                this.quantidadeFuncionalidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int QuantidadeUsuarios
        {
            get
            {
                return this.quantidadeUsuariosField;
            }
            set
            {
                this.quantidadeUsuariosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
        public FuncionalidadeInfo[] Funcionalidades
        {
            get
            {
                return this.funcionalidadesField;
            }
            set
            {
                this.funcionalidadesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string NomeSistema
        {
            get
            {
                return this.nomeSistemaField;
            }
            set
            {
                this.nomeSistemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int CodigoGrupoPai
        {
            get
            {
                return this.codigoGrupoPaiField;
            }
            set
            {
                this.codigoGrupoPaiField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UsuarioInfo
    {
        
        private int codigoUsuarioField;
        
        private string iDPessoaField;
        
        private System.Guid identificadorGUIDField;
        
        private string nomeField;
        
        private string emailField;
        
        private string departamentoField;
        
        private string telefoneField;
        
        private int codigoInfoADField;
        
        private long dataUltimaSenhaField;
        
        private bool autenticacaoADField;
        
        private EnumUsuarioStatus statusField;
        
        private string loginField;
        
        private System.DateTime dataCadastroField;
        
        private string loginUsuarioCadastroField;
        
        private System.Nullable<System.DateTime> dataAlteracaoField;
        
        private string loginUsuarioAlteracaoField;
        
        private string descricaoField;
        
        private GrupoInfo[] gruposField;
        
        private string nomeGruposField;
        
        private SistemaInfo[] sistemasField;
        
        private UsuarioSenhaInfo senhaField;
        
        private string iDSapUsuarioField;
        
        private bool gestorRegionalField;
        
        private bool supervisorObraField;
        
        private bool recebeEmailField;
        
        private string iDOSDispositivoField;
        
        private string versaoAppAtualField;
        
        private bool versaoImplantacaoField;
        
        private System.DateTime dataImplantacaoField;
        
        private System.DateTime dataAtualizacaoField;
        
        private int codigoSistemaField;
        
        private decimal pCTamanhoDiscoDisponivelField;
        
        private decimal pCMemoriaTotalField;
        
        private decimal pCMemoriaDisponivelField;
        
        private decimal pCMemoriaUsoField;
        
        private string pCSistemaOperacionalField;
        
        private string pCDispositivoField;
        
        private string mensagemField;
        
        private bool validoField;
        
        private bool validoADField;
        
        private bool validoEMPField;
        
        private string cpfUsuarioField;
        
        private string idUsuarioField;
        
        private string situacaoField;
        
        private System.Nullable<System.DateTime> dataAdmissaoField;
        
        private System.Nullable<System.DateTime> dataDemissaoField;
        
        public UsuarioInfo()
        {
            this.statusField = EnumUsuarioStatus.Ativo;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int CodigoUsuario
        {
            get
            {
                return this.codigoUsuarioField;
            }
            set
            {
                this.codigoUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string IDPessoa
        {
            get
            {
                return this.iDPessoaField;
            }
            set
            {
                this.iDPessoaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Guid IdentificadorGUID
        {
            get
            {
                return this.identificadorGUIDField;
            }
            set
            {
                this.identificadorGUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Departamento
        {
            get
            {
                return this.departamentoField;
            }
            set
            {
                this.departamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int CodigoInfoAD
        {
            get
            {
                return this.codigoInfoADField;
            }
            set
            {
                this.codigoInfoADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public long DataUltimaSenha
        {
            get
            {
                return this.dataUltimaSenhaField;
            }
            set
            {
                this.dataUltimaSenhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool AutenticacaoAD
        {
            get
            {
                return this.autenticacaoADField;
            }
            set
            {
                this.autenticacaoADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        [System.ComponentModel.DefaultValueAttribute(EnumUsuarioStatus.Ativo)]
        public EnumUsuarioStatus Status
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
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public System.DateTime DataCadastro
        {
            get
            {
                return this.dataCadastroField;
            }
            set
            {
                this.dataCadastroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string LoginUsuarioCadastro
        {
            get
            {
                return this.loginUsuarioCadastroField;
            }
            set
            {
                this.loginUsuarioCadastroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<System.DateTime> DataAlteracao
        {
            get
            {
                return this.dataAlteracaoField;
            }
            set
            {
                this.dataAlteracaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string LoginUsuarioAlteracao
        {
            get
            {
                return this.loginUsuarioAlteracaoField;
            }
            set
            {
                this.loginUsuarioAlteracaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string Descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=17)]
        public GrupoInfo[] Grupos
        {
            get
            {
                return this.gruposField;
            }
            set
            {
                this.gruposField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string NomeGrupos
        {
            get
            {
                return this.nomeGruposField;
            }
            set
            {
                this.nomeGruposField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=19)]
        public SistemaInfo[] Sistemas
        {
            get
            {
                return this.sistemasField;
            }
            set
            {
                this.sistemasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public UsuarioSenhaInfo Senha
        {
            get
            {
                return this.senhaField;
            }
            set
            {
                this.senhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string IDSapUsuario
        {
            get
            {
                return this.iDSapUsuarioField;
            }
            set
            {
                this.iDSapUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public bool GestorRegional
        {
            get
            {
                return this.gestorRegionalField;
            }
            set
            {
                this.gestorRegionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public bool SupervisorObra
        {
            get
            {
                return this.supervisorObraField;
            }
            set
            {
                this.supervisorObraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public bool RecebeEmail
        {
            get
            {
                return this.recebeEmailField;
            }
            set
            {
                this.recebeEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string IDOSDispositivo
        {
            get
            {
                return this.iDOSDispositivoField;
            }
            set
            {
                this.iDOSDispositivoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string VersaoAppAtual
        {
            get
            {
                return this.versaoAppAtualField;
            }
            set
            {
                this.versaoAppAtualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public bool VersaoImplantacao
        {
            get
            {
                return this.versaoImplantacaoField;
            }
            set
            {
                this.versaoImplantacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public System.DateTime DataImplantacao
        {
            get
            {
                return this.dataImplantacaoField;
            }
            set
            {
                this.dataImplantacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public System.DateTime DataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public int CodigoSistema
        {
            get
            {
                return this.codigoSistemaField;
            }
            set
            {
                this.codigoSistemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public decimal PCTamanhoDiscoDisponivel
        {
            get
            {
                return this.pCTamanhoDiscoDisponivelField;
            }
            set
            {
                this.pCTamanhoDiscoDisponivelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public decimal PCMemoriaTotal
        {
            get
            {
                return this.pCMemoriaTotalField;
            }
            set
            {
                this.pCMemoriaTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public decimal PCMemoriaDisponivel
        {
            get
            {
                return this.pCMemoriaDisponivelField;
            }
            set
            {
                this.pCMemoriaDisponivelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=34)]
        public decimal PCMemoriaUso
        {
            get
            {
                return this.pCMemoriaUsoField;
            }
            set
            {
                this.pCMemoriaUsoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=35)]
        public string PCSistemaOperacional
        {
            get
            {
                return this.pCSistemaOperacionalField;
            }
            set
            {
                this.pCSistemaOperacionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=36)]
        public string PCDispositivo
        {
            get
            {
                return this.pCDispositivoField;
            }
            set
            {
                this.pCDispositivoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=37)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=38)]
        public bool Valido
        {
            get
            {
                return this.validoField;
            }
            set
            {
                this.validoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=39)]
        public bool ValidoAD
        {
            get
            {
                return this.validoADField;
            }
            set
            {
                this.validoADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=40)]
        public bool ValidoEMP
        {
            get
            {
                return this.validoEMPField;
            }
            set
            {
                this.validoEMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=41)]
        public string CpfUsuario
        {
            get
            {
                return this.cpfUsuarioField;
            }
            set
            {
                this.cpfUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=42)]
        public string IdUsuario
        {
            get
            {
                return this.idUsuarioField;
            }
            set
            {
                this.idUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=43)]
        public string Situacao
        {
            get
            {
                return this.situacaoField;
            }
            set
            {
                this.situacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
        public System.Nullable<System.DateTime> DataAdmissao
        {
            get
            {
                return this.dataAdmissaoField;
            }
            set
            {
                this.dataAdmissaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
        public System.Nullable<System.DateTime> DataDemissao
        {
            get
            {
                return this.dataDemissaoField;
            }
            set
            {
                this.dataDemissaoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum EnumUsuarioStatus
    {
        
        /// <remarks/>
        Ativo,
        
        /// <remarks/>
        Bloqueado,
        
        /// <remarks/>
        Inativo,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioValidar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioValidarRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Seguranca.SegurancaSoapHeader SegurancaSoapHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string login;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string senha;
        
        public UsuarioValidarRequest()
        {
        }
        
        public UsuarioValidarRequest(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, string login, string senha)
        {
            this.SegurancaSoapHeader = SegurancaSoapHeader;
            this.login = login;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioValidarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioValidarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Seguranca.UsuarioInfo UsuarioValidarResult;
        
        public UsuarioValidarResponse()
        {
        }
        
        public UsuarioValidarResponse(Seguranca.UsuarioInfo UsuarioValidarResult)
        {
            this.UsuarioValidarResult = UsuarioValidarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioValidarPorLogin", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioValidarPorLoginRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Seguranca.SegurancaSoapHeader SegurancaSoapHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string login;
        
        public UsuarioValidarPorLoginRequest()
        {
        }
        
        public UsuarioValidarPorLoginRequest(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, string login)
        {
            this.SegurancaSoapHeader = SegurancaSoapHeader;
            this.login = login;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioValidarPorLoginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioValidarPorLoginResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Seguranca.UsuarioInfo UsuarioValidarPorLoginResult;
        
        public UsuarioValidarPorLoginResponse()
        {
        }
        
        public UsuarioValidarPorLoginResponse(Seguranca.UsuarioInfo UsuarioValidarPorLoginResult)
        {
            this.UsuarioValidarPorLoginResult = UsuarioValidarPorLoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioADListar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioADListarRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Seguranca.SegurancaSoapHeader SegurancaSoapHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string nome;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string login;
        
        public UsuarioADListarRequest()
        {
        }
        
        public UsuarioADListarRequest(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, string nome, string login)
        {
            this.SegurancaSoapHeader = SegurancaSoapHeader;
            this.nome = nome;
            this.login = login;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioADListarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioADListarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Seguranca.UsuarioInfo[] UsuarioADListarResult;
        
        public UsuarioADListarResponse()
        {
        }
        
        public UsuarioADListarResponse(Seguranca.UsuarioInfo[] UsuarioADListarResult)
        {
            this.UsuarioADListarResult = UsuarioADListarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioListarPorSistema", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioListarPorSistemaRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Seguranca.SegurancaSoapHeader SegurancaSoapHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int codigoSistema;
        
        public UsuarioListarPorSistemaRequest()
        {
        }
        
        public UsuarioListarPorSistemaRequest(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, int codigoSistema)
        {
            this.SegurancaSoapHeader = SegurancaSoapHeader;
            this.codigoSistema = codigoSistema;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UsuarioListarPorSistemaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UsuarioListarPorSistemaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Seguranca.UsuarioInfo[] UsuarioListarPorSistemaResult;
        
        public UsuarioListarPorSistemaResponse()
        {
        }
        
        public UsuarioListarPorSistemaResponse(Seguranca.UsuarioInfo[] UsuarioListarPorSistemaResult)
        {
            this.UsuarioListarPorSistemaResult = UsuarioListarPorSistemaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SegurancaSoapChannel : Seguranca.SegurancaSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SegurancaSoapClient : System.ServiceModel.ClientBase<Seguranca.SegurancaSoap>, Seguranca.SegurancaSoap
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
    /// </summary>
    /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
    /// <param name="clientCredentials">As credenciais do cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SegurancaSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SegurancaSoapClient.GetBindingForEndpoint(endpointConfiguration), SegurancaSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SegurancaSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SegurancaSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SegurancaSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SegurancaSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SegurancaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetDateTimeAsync()
        {
            return base.Channel.GetDateTimeAsync();
        }
        
        public System.Threading.Tasks.Task<bool> TokenValidoAsync(string token)
        {
            return base.Channel.TokenValidoAsync(token);
        }
        
        public System.Threading.Tasks.Task<bool> ChaveValidaAsync(System.Guid apiKey)
        {
            return base.Channel.ChaveValidaAsync(apiKey);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Seguranca.UsuarioValidarResponse> Seguranca.SegurancaSoap.UsuarioValidarAsync(Seguranca.UsuarioValidarRequest request)
        {
            return base.Channel.UsuarioValidarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Seguranca.UsuarioValidarResponse> UsuarioValidarAsync(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, string login, string senha)
        {
            Seguranca.UsuarioValidarRequest inValue = new Seguranca.UsuarioValidarRequest();
            inValue.SegurancaSoapHeader = SegurancaSoapHeader;
            inValue.login = login;
            inValue.senha = senha;
            return ((Seguranca.SegurancaSoap)(this)).UsuarioValidarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Seguranca.UsuarioValidarPorLoginResponse> Seguranca.SegurancaSoap.UsuarioValidarPorLoginAsync(Seguranca.UsuarioValidarPorLoginRequest request)
        {
            return base.Channel.UsuarioValidarPorLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Seguranca.UsuarioValidarPorLoginResponse> UsuarioValidarPorLoginAsync(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, string login)
        {
            Seguranca.UsuarioValidarPorLoginRequest inValue = new Seguranca.UsuarioValidarPorLoginRequest();
            inValue.SegurancaSoapHeader = SegurancaSoapHeader;
            inValue.login = login;
            return ((Seguranca.SegurancaSoap)(this)).UsuarioValidarPorLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Seguranca.UsuarioADListarResponse> Seguranca.SegurancaSoap.UsuarioADListarAsync(Seguranca.UsuarioADListarRequest request)
        {
            return base.Channel.UsuarioADListarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Seguranca.UsuarioADListarResponse> UsuarioADListarAsync(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, string nome, string login)
        {
            Seguranca.UsuarioADListarRequest inValue = new Seguranca.UsuarioADListarRequest();
            inValue.SegurancaSoapHeader = SegurancaSoapHeader;
            inValue.nome = nome;
            inValue.login = login;
            return ((Seguranca.SegurancaSoap)(this)).UsuarioADListarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Seguranca.UsuarioListarPorSistemaResponse> Seguranca.SegurancaSoap.UsuarioListarPorSistemaAsync(Seguranca.UsuarioListarPorSistemaRequest request)
        {
            return base.Channel.UsuarioListarPorSistemaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Seguranca.UsuarioListarPorSistemaResponse> UsuarioListarPorSistemaAsync(Seguranca.SegurancaSoapHeader SegurancaSoapHeader, int codigoSistema)
        {
            Seguranca.UsuarioListarPorSistemaRequest inValue = new Seguranca.UsuarioListarPorSistemaRequest();
            inValue.SegurancaSoapHeader = SegurancaSoapHeader;
            inValue.codigoSistema = codigoSistema;
            return ((Seguranca.SegurancaSoap)(this)).UsuarioListarPorSistemaAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SegurancaSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.SegurancaSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SegurancaSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://frameworkh.mrv.com.br/Seguranca.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.SegurancaSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://frameworkh.mrv.com.br/Seguranca.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            SegurancaSoap,
            
            SegurancaSoap12,
        }
    }
}
