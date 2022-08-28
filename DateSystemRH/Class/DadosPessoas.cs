using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class DadosPessoas
    {
        public DadosPessoas()
        {
            this.Id_DadosPessoas = 0;
            this.txtCargo = "";
            this.txtDataCadastro = "";
            this.txtNome = "";
            this.txtIdade = "";
            this.maskedTextBoxCep = "";
            this.txtEndereco = "";
            this.txtNumero = "";
            this.txtBairro = "";
            this.txtComplemento = "";
            this.txtCidadeNome = "";
            this.txtSiglaNome = "";
            this.txtLogradouroNome = "";
            this.txtEstado = "";
            this.radioButtonFSN = 0;
            this.radioButtonRegiao = 0;
            this.txtPontoReferencia = "";
            this.txtResideQTLocal = "";
            this.radioButtonMoradia = 0;
            this.txtTelefonePessoa = "";
            this.maskedtxtCelularPessoa = "";
            this.maskedtxtTelefoneRecardo = "";
            this.maskedtxtCelularRecardo = "";
            this.txtNomeRecardo = "";
            this.maskedtxtRgNome = "";
            this.txtDataOrgaoNome = "";
            this.maskedtxtCpf = "";
            this.txtCarteiraTrabalho = "";
            this.txtSerieNome = "";
            this.txtPisNome = "";
            this.txtTituloEleitor = "";
            this.radioButtonVotacaoSN = 0;
            this.txtNReservista = "";
            this.dateTimePickerDataNascimento = "";
            this.txtnaturalDe = "";
            this.txtEstadoNatural = "";
            this.txtNacionalidade = "";
            this.maskedtxtAltura = "";
            this.maskedtxtPeso = "";
            this.txtEmailNome = "";
            this.txtEstadoCivil = 0;
            this.txtNomeJunto = "";
            this.dateTimePickerNascimentoJunto = "";
            this.txtNdependentes = "";
            this.txtNFilhos  = "";
            this.txtIdadeFilhos = "";
            this.txtNomePai = "";
            this.radioButtonPSN = 0;
            this.dateTimePickerNascimentoPai = "";
            this.txtNomeMae = "";
            this.radioButtonMVS = 0;
            this.dateTimePickerNascimentoMae = "";
            this.ID_Cliente_MS = "";
            this.PassagemCriminal = 0;
            this.Id_Estabilidade = 0;
            this.ComentarioEstabilidade = "";
            this.SituacaoCriminal = 0;
            this.IdProfissao = 0;
            this.StatusMercado = 0;
            this.IdPessoaLogada = 0;
            this.Id_PessoLogadaAlterada = 0;

        }

        public DadosPessoas(int ID_DADOSPESSOS, string TXTCARGO, string TXTDATACADASTRO, string TXTNOME, string TXTIDADE, 
            string MASKEDTEXTBOXCEP, string TXTENDERECO, string TXTNUMERO,string TXTBAIRRO,string TXTCOMPLEMENTO, 
            string TXTLOGRADOURONOME, string TXTCIDADENOME, string TXTSIGLANOME, string TXTESTADO, int RADIOBUTTONFSN,
            int RADIOBUTTONREGIAO, string TXTPONTOREFERENCIA,string TXTRESIDEQLOCAL, int RADIOBUTTONMORADIA,
            string TXTTELEFONEPESSOA, string MASKEDTXTCELULARPESSOA, string MASKEDTXTELEFONERECARDO, string MASKEDTXCELULARRECARDO,string TXTNOMERECARDO,
            string MASKEDTXTRGNOME, string TXDATAORGAONOME, string MASKEDTXTCPF, string TXTCARTEIRATRABALHO, string TXTSERIENOME,
            string TXTPISNOME, string TXTTITULOELEITOR, int RADIOBUTTONVOTACAONS, string TXTNRESERVISTA,string DATETIMEPICKERDATANASCIMENTO,
            string TXTNATURALDE, string TXTESTADONATURAL, string TXTNACIONALIDADE, string MASKEDTXTALTURA,
            string MASKEDTXTPESSO, string TXTEMAIL, int TXTESTADOCIVIL, string TXTNOMEJUNTO, 
            string DATETIMEPICKERNASCIMENTOJUNTO, String TXTNDEPENDENTES, String TXTNFILHOS, string TXTIDADEFILHOS, 
            string TXTNOMEPAI, int RADIOBUTTONPSN, string DATETIMEPICKERNASCIMENTOPAI,string TXTNOMEMAE,int RADIOBUTTONMVS,
            string ID_CLIENTE_MS, string DATETIMEPICKERNASCIMENTOMAE,int PASSAGEM_CRIMINAL,int ID_ESTABILIDADE, string COMENTARIO_ESTABILIDADE,
            int SITUACAO_CRIMINAL, int ID_PROFISSAO, int STATUS_MERCADO, int ID_PESSOA_LOGADA, int ID_PESSOA_LOGADA_ALTERADA)
        {
            this.Id_DadosPessoas = ID_DADOSPESSOS;
            this.txtCargo = TXTCARGO;
            this.txtDataCadastro = TXTDATACADASTRO;
            this.txtNome = TXTNOME;
            this.txtIdade = TXTIDADE;
            this.maskedTextBoxCep = MASKEDTEXTBOXCEP;
            this.txtEndereco = TXTENDERECO;
            this.txtNumero = TXTNUMERO;
            this.txtBairro = TXTBAIRRO;
            this.txtComplemento = TXTCOMPLEMENTO;
            this.txtLogradouroNome = TXTLOGRADOURONOME;
            this.txtCidadeNome = TXTCIDADENOME;
            this.txtSiglaNome = TXTSIGLANOME;
            this.txtEstado = TXTESTADO;
            this.radioButtonFSN = RADIOBUTTONFSN;
            this.radioButtonRegiao = RADIOBUTTONREGIAO;
            this.txtPontoReferencia = TXTPONTOREFERENCIA;
            this.txtResideQTLocal = TXTRESIDEQLOCAL;
            this.radioButtonMoradia = RADIOBUTTONMORADIA;
            this.txtTelefonePessoa = TXTTELEFONEPESSOA;
            this.maskedtxtCelularPessoa = MASKEDTXTCELULARPESSOA;
            this.maskedtxtTelefoneRecardo = MASKEDTXTELEFONERECARDO;
            this.maskedtxtCelularRecardo = MASKEDTXCELULARRECARDO;
            this.txtNomeRecardo = TXTNOMERECARDO;
            this.maskedtxtRgNome = MASKEDTXTRGNOME;
            this.txtDataOrgaoNome = TXDATAORGAONOME;
            this.maskedtxtCpf = MASKEDTXTCPF;
            this.txtCarteiraTrabalho = TXTCARTEIRATRABALHO;
            this.txtSerieNome = TXTSERIENOME;
            this.txtPisNome = TXTPISNOME;
            this.txtTituloEleitor = TXTTITULOELEITOR;
            this.radioButtonVotacaoSN = RADIOBUTTONVOTACAONS;
            this.txtNReservista = TXTNRESERVISTA;
            this.dateTimePickerDataNascimento = DATETIMEPICKERDATANASCIMENTO;
            this.txtnaturalDe = TXTNATURALDE;
            this.txtEstadoNatural = TXTESTADONATURAL;
            this.txtNacionalidade = TXTNACIONALIDADE;
            this.maskedtxtAltura = MASKEDTXTALTURA;
            this.maskedtxtPeso = MASKEDTXTPESSO;
            this.txtEmailNome = TXTEMAIL;
            this.txtEstadoCivil = TXTESTADOCIVIL;
            this.txtNomeJunto = TXTNOMEJUNTO;
            this.dateTimePickerNascimentoJunto = DATETIMEPICKERNASCIMENTOJUNTO;
            this.txtNdependentes = TXTNDEPENDENTES;
            this.txtNFilhos = TXTNFILHOS;
            this.txtIdadeFilhos = TXTIDADEFILHOS;
            this.txtNomePai = TXTNOMEPAI;
            this.radioButtonPSN = RADIOBUTTONPSN;
            this.dateTimePickerNascimentoPai = DATETIMEPICKERNASCIMENTOPAI;
            this.txtNomeMae = TXTNOMEMAE;
            this.radioButtonMVS = RADIOBUTTONMVS;
            this.dateTimePickerNascimentoMae = DATETIMEPICKERNASCIMENTOMAE;
            this.ID_Cliente_MS = ID_CLIENTE_MS;
            this.PassagemCriminal = PASSAGEM_CRIMINAL;
            this.SituacaoCriminal = SITUACAO_CRIMINAL;
            this.IdProfissao = ID_PROFISSAO;
            this.StatusMercado = STATUS_MERCADO;
            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.Id_PessoLogadaAlterada = ID_PESSOA_LOGADA_ALTERADA;

        }

        private int ID_DADOSPESSOS;
        public int Id_DadosPessoas
        {
            get
            {
                return this.ID_DADOSPESSOS;

            }
            set
            {
                this.ID_DADOSPESSOS = value;
            }
        }

        private string TXTCARGO;
        public string txtCargo
        {
            get
            {
                return this.TXTCARGO;

            }
            set
            {
                this.TXTCARGO = value;
            }
        }
        private string TXTDATACADASTRO;
        public string txtDataCadastro
        {
            get
            {
                return this.TXTDATACADASTRO;

            }
            set
            {
                this.TXTDATACADASTRO = value;
            }
        }
        private string TXTNOME;
        public string txtNome
        {
            get
            {
                return this.TXTNOME;

            }
            set
            {
                this.TXTNOME = value;
            }
        }
        private string TXTIDADE;
        public string txtIdade
        {
            get
            {
                return this.TXTIDADE;

            }
            set
            {
                this.TXTIDADE = value;
            }
        }

        private string MASKEDTEXTBOXCEP;
        public string maskedTextBoxCep
        {
            get
            {
                return this.MASKEDTEXTBOXCEP;

            }
            set
            {
                this.MASKEDTEXTBOXCEP = value;
            }
        }
        private string TXTENDERECO;
        public string txtEndereco
        {
            get
            {
                return this.TXTENDERECO;

            }
            set
            {
                this.TXTENDERECO = value;
            }
        }
        private string TXTNUMERO;
        public string txtNumero
        {
            get
            {
                return this.TXTNUMERO;

            }
            set
            {
                this.TXTNUMERO = value;
            }
        }
        private string TXTBAIRRO;
        public string txtBairro
        {
            get
            {
                return this.TXTBAIRRO;

            }
            set
            {
                this.TXTBAIRRO = value;
            }
        }

        private string TXTCOMPLEMENTO;
        public string txtComplemento
        {
            get
            {
                return this.TXTCOMPLEMENTO;

            }
            set
            {
                this.TXTCOMPLEMENTO = value;
            }
        }
        private string TXTLOGRADOURONOME;
        public string txtLogradouroNome
        {
            get
            {
                return this.TXTLOGRADOURONOME;

            }
            set
            {
                this.TXTLOGRADOURONOME = value;
            }
        }
        private string TXTCIDADENOME;
        public string txtCidadeNome
        {
            get
            {
                return this.TXTCIDADENOME;

            }
            set
            {
                this.TXTCIDADENOME = value;
            }
        }
        private string TXTSIGLANOME;
        public string txtSiglaNome
        {
            get
            {
                return this.TXTSIGLANOME;

            }
            set
            {
                this.TXTSIGLANOME = value;
            }
        }
        private string TXTESTADO;
        public String txtEstado
        {
            get
            {
                return this.TXTESTADO;

            }
            set
            {
                this.TXTESTADO = value;
            }
        }

        private int RADIOBUTTONFSN;
        public int radioButtonFSN
        {
            get
            {
                return this.RADIOBUTTONFSN;

            }
            set
            {
                this.RADIOBUTTONFSN = value;
            }
        }
        private int RADIOBUTTONREGIAO;
        public int radioButtonRegiao
        {
            get
            {
                return this.RADIOBUTTONREGIAO;

            }
            set
            {
                this.RADIOBUTTONREGIAO = value;
            }
        }
        private string TXTPONTOREFERENCIA;
        public String txtPontoReferencia
        {
            get
            {
                return this.TXTPONTOREFERENCIA;

            }
            set
            {
                this.TXTPONTOREFERENCIA = value;
            }
        }
        private string TXTRESIDEQLOCAL;
        public string txtResideQTLocal
        {
            get
            {
                return this.TXTRESIDEQLOCAL;

            }
            set
            {
                this.TXTRESIDEQLOCAL = value;
            }

        }
        private int RADIOBUTTONMORADIA;
        public int radioButtonMoradia
        {
            get
            {
                return this.RADIOBUTTONMORADIA;

            }
            set
            {
                this.RADIOBUTTONMORADIA = value;
            }
        }
        private string TXTTELEFONEPESSOA;
        public string txtTelefonePessoa
        {
            get
            {
                return this.TXTTELEFONEPESSOA;

            }
            set
            {
                this.TXTTELEFONEPESSOA = value;
            }
        }
        private string MASKEDTXTCELULARPESSOA;
        public string maskedtxtCelularPessoa
        {
            get
            {
                return this.MASKEDTXTCELULARPESSOA;

            }
            set
            {
                this.MASKEDTXTCELULARPESSOA = value;
            }
        }
        private string MASKEDTXTELEFONERECARDO;
        public string maskedtxtTelefoneRecardo
        {
            get
            {
                return this.MASKEDTXTELEFONERECARDO;

            }
            set
            {
                this.MASKEDTXTELEFONERECARDO = value;
            }
        }
        private string MASKEDTXCELULARRECARDO;
        public string maskedtxtCelularRecardo
        {
            get
            {
                return this.MASKEDTXCELULARRECARDO;

            }
            set
            {
                this.MASKEDTXCELULARRECARDO = value;
            }
        }
        private String TXTNOMERECARDO;
        public String txtNomeRecardo
        {
            get
            {
                return this.TXTNOMERECARDO;

            }
            set
            {
                this.TXTNOMERECARDO = value;
            }
        }
        private String MASKEDTXTRGNOME;
        public String maskedtxtRgNome
        {
            get
            {
                return this.MASKEDTXTRGNOME;

            }
            set
            {
                this.MASKEDTXTRGNOME = value;
            }
        }
        private String TXDATAORGAONOME;
        public String txtDataOrgaoNome
        {
            get
            {
                return this.TXDATAORGAONOME;

            }
            set
            {
                this.TXDATAORGAONOME = value;
            }
        }
        private String MASKEDTXTCPF;
        public String maskedtxtCpf
        {
            get
            {
                return this.MASKEDTXTCPF;

            }
            set
            {
                this.MASKEDTXTCPF = value;
            }
        }
        private String TXTCARTEIRATRABALHO;
        public String txtCarteiraTrabalho
        {
            get
            {
                return this.TXTCARTEIRATRABALHO;

            }
            set
            {
                this.TXTCARTEIRATRABALHO = value;
            }
        }
        private String TXTSERIENOME;
        public String txtSerieNome
        {
            get
            {
                return this.TXTSERIENOME;

            }
            set
            {
                this.TXTSERIENOME = value;
            }
        }
        private String TXTPISNOME;
        public String txtPisNome
        {
            get
            {
                return this.TXTPISNOME;

            }
            set
            {
                this.TXTPISNOME = value;
            }
        }
        private String TXTTITULOELEITOR;
        public String txtTituloEleitor
        {
            get
            {
                return this.TXTTITULOELEITOR;

            }
            set
            {
                this.TXTTITULOELEITOR = value;
            }
        }
        private int RADIOBUTTONVOTACAONS;
        public int radioButtonVotacaoSN
        {
            get
            {
                return this.RADIOBUTTONVOTACAONS;

            }
            set
            {
                this.RADIOBUTTONVOTACAONS = value;
            }
        }
        private String TXTNRESERVISTA;
        public String txtNReservista
        {
            get
            {
                return this.TXTNRESERVISTA;

            }
            set
            {
                this.TXTNRESERVISTA = value;
            }
        }
        private String DATETIMEPICKERDATANASCIMENTO;
        public String dateTimePickerDataNascimento
        {
            get
            {
                return this.DATETIMEPICKERDATANASCIMENTO;

            }
            set
            {
                this.DATETIMEPICKERDATANASCIMENTO = value;
            }
        }
        private String TXTNATURALDE;
        public String txtnaturalDe
        {
            get
            {
                return this.TXTNATURALDE;

            }
            set
            {
                this.TXTNATURALDE = value;
            }
        }
        private String TXTESTADONATURAL;
        public String txtEstadoNatural
        {
            get
            {
                return this.TXTESTADONATURAL;

            }
            set
            {
                this.TXTESTADONATURAL = value;
            }
        }
        private String TXTNACIONALIDADE;
        public String txtNacionalidade
        {
            get
            {
                return this.TXTNACIONALIDADE;

            }
            set
            {
                this.TXTNACIONALIDADE = value;
            }
        }
        private String MASKEDTXTALTURA;
        public String maskedtxtAltura
        {
            get
            {
                return this.MASKEDTXTALTURA;

            }
            set
            {
                this.MASKEDTXTALTURA = value;
            }
        }
        private String MASKEDTXTPESSO;
        public String maskedtxtPeso
        {
            get
            {
                return this.MASKEDTXTPESSO;

            }
            set
            {
                this.MASKEDTXTPESSO = value;
            }
        }
        private String TXTEMAIL;
        public String txtEmailNome
        {
            get
            {
                return this.TXTEMAIL;

            }
            set
            {
                this.TXTEMAIL = value;
            }
        }
        private int TXTESTADOCIVIL;
        public int txtEstadoCivil
        {
            get
            {
                return this.TXTESTADOCIVIL;

            }
            set
            {
                this.TXTESTADOCIVIL = value;
            }
        }
        private String TXTNOMEJUNTO;
        public String txtNomeJunto
        {
            get
            {
                return this.TXTNOMEJUNTO;

            }
            set
            {
                this.TXTNOMEJUNTO = value;
            }
        }
        private String DATETIMEPICKERNASCIMENTOJUNTO;
        public String dateTimePickerNascimentoJunto
        {
            get
            {
                return this.DATETIMEPICKERNASCIMENTOJUNTO;

            }
            set
            {
                this.DATETIMEPICKERNASCIMENTOJUNTO = value;
            }
        }
        private String TXTNDEPENDENTES;
        public String txtNdependentes
        {
            get
            {
                return this.TXTNDEPENDENTES;

            }
            set
            {
                this.TXTNDEPENDENTES = value;
            }
        }
        private String TXTNFILHOS;
        public String txtNFilhos
        {
            get
            {
                return this.TXTNFILHOS;

            }
            set
            {
                this.TXTNFILHOS = value;
            }
        }
        private String TXTIDADEFILHOS;
        public String txtIdadeFilhos
        {
            get
            {
                return this.TXTIDADEFILHOS;

            }
            set
            {
                this.TXTIDADEFILHOS = value;
            }
        }
        private String TXTNOMEPAI;
        public String txtNomePai
        {
            get
            {
                return this.TXTNOMEPAI;

            }
            set
            {
                this.TXTNOMEPAI = value;
            }
        }
        private int RADIOBUTTONPSN;
        public int radioButtonPSN
        {
            get
            {
                return this.RADIOBUTTONPSN;

            }
            set
            {
                this.RADIOBUTTONPSN = value;
            }
        }
        private String DATETIMEPICKERNASCIMENTOPAI;
        public String dateTimePickerNascimentoPai
        {
            get
            {
                return this.DATETIMEPICKERNASCIMENTOPAI;

            }
            set
            {
                this.DATETIMEPICKERNASCIMENTOPAI = value;
            }
        }
        private String TXTNOMEMAE;
        public String txtNomeMae
        {
            get
            {
                return this.TXTNOMEMAE;

            }
            set
            {
                this.TXTNOMEMAE = value;
            }
        }
        private int RADIOBUTTONMVS;
        public int radioButtonMVS
        {
            get
            {
                return this.RADIOBUTTONMVS;

            }
            set
            {
                this.RADIOBUTTONMVS = value;
            }
        }
        private String DATETIMEPICKERNASCIMENTOMAE;
        public String dateTimePickerNascimentoMae
        {
            get
            {
                return this.DATETIMEPICKERNASCIMENTOMAE;

            }
            set
            {
                this.DATETIMEPICKERNASCIMENTOMAE = value;
            }
        }
        private string ID_CLIENTE_MS;
        public string ID_Cliente_MS
        {
            get
            {
                return this.ID_CLIENTE_MS;

            }
            set
            {
                this.ID_CLIENTE_MS = value;
            }
        }
        private int PASSAGEM_CRIMINAL;
        public int PassagemCriminal
        {
            get
            {
                return this.PASSAGEM_CRIMINAL;

            }
            set
            {
                this.PASSAGEM_CRIMINAL = value;
            }
        }
        private int ID_ESTABILIDADE;
        public int Id_Estabilidade
        {
            get
            {
                return this.ID_ESTABILIDADE;

            }
            set
            {
                this.ID_ESTABILIDADE = value;
            }
        }
        private string COMENTARIO_ESTABILIDADE;
        public string ComentarioEstabilidade
        {
            get
            {
                return this.COMENTARIO_ESTABILIDADE;

            }
            set
            {
                this.COMENTARIO_ESTABILIDADE = value;
            }
        }
        private int SITUACAO_CRIMINAL;
        public int SituacaoCriminal
        {
            get
            {
                return this.SITUACAO_CRIMINAL;

            }
            set
            {
                this.SITUACAO_CRIMINAL = value;
            }
        }
        private int ID_PROFISSAO;
        public int IdProfissao
        {
            get
            {
                return this.ID_PROFISSAO;

            }
            set
            {
                this.ID_PROFISSAO = value;
            }
        }
        private int STATUS_MERCADO;
        public int StatusMercado
        {
            get
            {
                return this.STATUS_MERCADO;

            }
            set
            {
                this.STATUS_MERCADO = value;
            }
        }
        private int ID_PESSOA_LOGADA;
        public int IdPessoaLogada
        {
            get
            {
                return this.ID_PESSOA_LOGADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA = value;
            }
        }
        private int ID_PESSOA_LOGADA_ALTERADA;
        public int Id_PessoLogadaAlterada
        {
            get
            {
                return this.ID_PESSOA_LOGADA_ALTERADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA_ALTERADA = value;
            }
        }

        //private String DESCRISAO;
        //public String Descricao
        //{
        //    get
        //    {
        //        return this.DESCRISAO;

        //    }
        //    set
        //    {
        //        this.DESCRISAO = value;
        //    }
        //}
    }
}

