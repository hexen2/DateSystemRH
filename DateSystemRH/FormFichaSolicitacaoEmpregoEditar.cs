using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;

namespace DateSystemRH
{
    public partial class FormFichaSolicitacaoEmpregoEditar : Form
    {
        Bitmap bmp;
        private int CONTADOR = 0;
        public int contador
        {
            get
            {
                return this.CONTADOR;

            }
            set
            {
                this.CONTADOR = value;
            }
        }
        private int ID_PESSOAP = 0;
        public int IdPessoaP
        {
            get
            {
                return this.ID_PESSOAP;

            }
            set
            {
                this.ID_PESSOAP = value;
            }
        }
        private string CONNECTIONSTRING = "";
        public string connetionString
        {
            get
            {
                return this.CONNECTIONSTRING;

            }
            set
            {
                this.CONNECTIONSTRING = value;
            }
        }
        private int ID_ESTADOCIVIL = 0;
        public int IdEstadoCivil
        {
            get
            {
                return this.ID_ESTADOCIVIL;

            }
            set
            {
                this.ID_ESTADOCIVIL = value;
            }
        }
        private int ID_ESTABILIDADE = 0;
        public int IdPEstabilidade
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
        private string ID_EX_EMPREGADO = "";
        public string IdExEmpregado
        {
            get
            {
                return this.ID_EX_EMPREGADO;

            }
            set
            {
                this.ID_EX_EMPREGADO = value;
            }
        }
        private string ID_PASSAGEM_CRIMINAL = "";
        public string IdPassagemCriminal
        {
            get
            {
                return this.ID_PASSAGEM_CRIMINAL;

            }
            set
            {
                this.ID_PASSAGEM_CRIMINAL = value;
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
        private int STATUS_MERDADO;
        public int StatusMercado
        {
            get
            {
                return this.STATUS_MERDADO;

            }
            set
            {
                this.STATUS_MERDADO = value;
            }
        }
        private int STATUS_MERDADO_TEMP;
        public int StatusMercadoTemp
        {
            get
            {
                return this.STATUS_MERDADO_TEMP;

            }
            set
            {
                this.STATUS_MERDADO_TEMP = value;
            }
        }
        private int FICHAEDITAR;
        public int FichaEditar
        {
            get
            {
                return this.FICHAEDITAR;

            }
            set
            {
                this.FICHAEDITAR = value;
            }
        }
        
        private int IDLOGINUSUARIO;
        public int IdLoginUsuario
        {
            get
            {
                return this.IDLOGINUSUARIO;

            }
            set
            {
                this.IDLOGINUSUARIO = value;
            }
        }
        private Boolean ATIVARCRIMINAL = false;
        public Boolean AtivarCriminal 
        {
            get
            {
                return this.ATIVARCRIMINAL;

            }
            set
            {
                this.ATIVARCRIMINAL = value;
            }
        }
        private string IMGLOCATION = "";
        public string ImgLocation
        {
            get
            {
                return this.IMGLOCATION;

            }
            set
            {
                this.IMGLOCATION = value;
            }
        }
        private Image IMAGEM = null;
        public Image Imagem
        {
            get
            {
                return this.IMAGEM;

            }
            set
            {
                this.IMAGEM = value;
            }
        }
        private Boolean CONSTAIMAGEM = false;
        public Boolean ConstaImagem
        {
            get
            {
                return this.CONSTAIMAGEM;

            }
            set
            {
                this.CONSTAIMAGEM = value;
            }
        }
        private Boolean txtNomePessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProviderEditarFichaEmprego.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarFichaEmprego.SetError(textBox, "Nome Não pode se em branco!");
                this.contador++;
                return false;
            }
        }



        
        public FormFichaSolicitacaoEmpregoEditar(int Idpessoa, int EmpresaEditar, int IdLoginUsuario)
        {
            InitializeComponent();
            this.IdPessoaP = Idpessoa;
            this.IdLoginUsuario = IdLoginUsuario;
            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

            label36.Text = "POSSUI OS 03 ÚLTIMOS\nCOMPROVANTES DE VOTAÇÃO:";
            label54.Text = "1° GRAU\nCOMPLETO?";
            label55.Text = "2° GRAU\nCOMPLETO?";
            label56.Text = "SUPERIOR\nCOMPLETO?";
            label60.Text = "ESTUDA\nATUALMENTE?";
            label78.Text = "CARTEIRA DE MOTORISTA\nCATEGORIA:";
            label84.Text = "PERÍODO\nNOTURNO?";
            label85.Text = "PRAZO DE\nEXPERIÊNCIA?";
            label86.Text = "ESCALA DE\nREVESAMENTO?";
            label87.Text = "TRANSFERIDO\nDE BAIRRO?";
            label88.Text = "CONHECE ALGUÉM\nNA EMPRESA?";
            label93.Text = "LOCAL DE\nTRABALHO:";
            Fill_listBoxEstadoCivil();
            Fill_listBoxTodasEstabilidade();
            Fill_listBoxProfissao();
            TamanhoCaracteres();
            dateTimePicker();
            Fill_listBoxTodasStatusMercado();
            EditarFichaSolicitacaoEmprego();
            AnalizaProcessoSeletivo();
            if (EmpresaEditar == 1)
            {
                buttonEditar.Enabled = true;
            }

        }
        public void AnalizaProcessoSeletivo()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);
            string Query = "SELECT * FROM P_ProcessoSeletivo P INNER JOIN P_CandidatosPSeletivo PC ON PC.ID_PROCESSO_SELETIVO = P.ID_PROCESSO_SELETIVO WHERE P.STATUS_FINALIZADO = 2 AND PC.ID_PESSOA = " + this.IdPessoaP + ";";
            SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
            DataSet ds = new DataSet();
            sa.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                //MessageBox.Show("Ele não está em Processo Seletivo!");
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.AtivarCriminal = true;
                string Processo = ds.Tables[0].Rows[0][0].ToString();
                label2.ForeColor = Color.Blue;
                //checkBoxPassagemCriminal.Enabled = false;
                checkBoxPassagemCriminal.Text = "Passagem Criminal\nProcesso Seleção: " + Processo +".";
                checkBoxPassagemCriminal.Location = new Point(344, 8);
            }
            conn.Close();
        }
        public void dateTimePicker()
        {
            this.txtDataCadastro.Value = DateTime.Now.Date;
            this.dateTimePickerAdmissaoEmpregado.Value = DateTime.Now.Date;
            this.dateTimePickerAntepenultimoEntrada.Value = DateTime.Now.Date;
            this.dateTimePickerAntepenultimoSaida.Value = DateTime.Now.Date;
            this.dateTimePickerDataNascimento.Value = DateTime.Now.Date;
            this.dateTimePickerDataTreinamentoAvaliacao.Value = DateTime.Now.Date;
            this.dateTimePickerDataValidadeCMotorista.Value = DateTime.Now.Date;
            this.dateTimePickerDemissaoEmpregado.Value = DateTime.Now.Date;
            this.dateTimePickerFormacaoVigilante.Value = DateTime.Now.Date;
            this.dateTimePickerNascimentoJunto.Value = DateTime.Now.Date;
            this.dateTimePickerNascimentoMae.Value = DateTime.Now.Date;
            this.dateTimePickerNascimentoPai.Value = DateTime.Now.Date;
            this.dateTimePickerPenultimaEntrada.Value = DateTime.Now.Date;
            this.dateTimePickerPenultimaSaida.Value = DateTime.Now.Date;
            this.dateTimePickerReciclagem.Value = DateTime.Now.Date;
            this.dateTimePickerUltimaEntrada.Value = DateTime.Now.Date;
            this.dateTimePickerUltimaSaida.Value = DateTime.Now.Date;
            //this.dateTimePickerDataDia.Value = DateTime.Now.Date;
            //this.DatadoDia = DatadoDia.ToString();
        }

        public void TamanhoCaracteres()
        {
            //DADOS PESSOAS
            txtCargo.MaxLength = 50;
            txtNome.MaxLength = 60;
            txtIdade.MaxLength = 3;
            maskedTextBoxCep.MaxLength = 10;
            txtEndereco.MaxLength = 100;
            txtNumero.MaxLength = 10;
            txtBairro.MaxLength = 30;
            txtComplemento.MaxLength = 30;
            txtLogradouroNome.MaxLength = 30;
            txtEstado.MaxLength = 30;
            txtPontoReferencia.MaxLength = 30;
            txtResideQTLocal.MaxLength = 30;
            txtTelefonePessoa.MaxLength = 10;
            maskedtxtCelularPessoa.MaxLength = 10;
            maskedtxtTelefoneRecardo.MaxLength = 10;
            txtNomeRecardo.MaxLength = 60;
            maskedtxtRgNome.MaxLength = 9;
            txtDataOrgaoNome.MaxLength = 15;
            maskedtxtCpf.MaxLength = 11;
            txtCarteiraTrabalho.MaxLength = 15;
            txtSerieNome.MaxLength = 15;
            txtPisNome.MaxLength = 15;
            txtTituloEleitor.MaxLength = 15;
            txtNReservista.MaxLength = 15;
            txtnaturalDe.MaxLength = 30;
            txtEstadoNatural.MaxLength = 30;
            txtNacionalidade.MaxLength = 30;
            maskedtxtAltura.MaxLength = 4;
            maskedtxtPeso.MaxLength = 6;
            txtEmailNome.MaxLength = 50;
            txtNomeJunto.MaxLength = 60;
            txtNdependentes.MaxLength = 3;
            txtNFilhos.MaxLength = 3;
            txtIdadeFilhos.MaxLength = 30;
            txtNomePai.MaxLength = 60;
            txtNomeMae.MaxLength = 60;
            //ESCOLARIDADE
            txtSuperiorCurso.MaxLength = 30;
            txtEstudaAtualmente.MaxLength = 20;
            txtBairroCursando.MaxLength = 20;
            //HABILIDADES PROFISSIONAIS
            txtNomeAcademiaVigilante.MaxLength = 40;
            txtNomeAcademiaReciclagem.MaxLength = 40;
            txtCursoPortaria.MaxLength = 40;
            txtEscolaPortaria.MaxLength = 40;
            txtQuaisCursos.MaxLength = 60;
            //INFORMACOES
            txtNumeroCarteiraMotorista.MaxLength = 20;
            txtDrogasIlicitas.MaxLength = 60;
            txtTratamentoMedico.MaxLength = 60;
            txtNomeConhecidoEmpresa.MaxLength = 60;
            txtCargoConhecidoEmpresa.MaxLength = 60;
            txtTrabalhoConhecidoEmpresa.MaxLength = 60;
            //EXPERIENCIA PROFISSIONAL
            txtUltimoEmprego.MaxLength = 40;
            txtUltimoCargo.MaxLength = 50;
            txtUltimoSalario.MaxLength = 10;
            txtNomeUltimoChefe.MaxLength = 40;
            txtMotivoSaidaUltimoEmprego.MaxLength = 40;
            txtPenultimoEmprego.MaxLength = 40;
            txtPenultimoCargo.MaxLength = 50;
            txtPenultimoSalario.MaxLength = 10;
            txtNomePenultimoChefe.MaxLength = 40;
            txtMotivoSaidaPenultimoEmprego.MaxLength = 40;
            txtAntepenultimoEmprego.MaxLength = 40;
            txtAntepenultimoCargo.MaxLength = 50;
            txtPenultimoSalario.MaxLength = 10;
            txtNomePenultimoChefe.MaxLength = 40;
            txtMotivoSaidaAntepenultimoEmprego.MaxLength = 40;
            //RECRUTAMENTO E SELECAO
            txtRecutamentoSelecao.MaxLength = 400;
            //AVALIACAO TECNICA
            txtEntrevistadoAprovado.MaxLength = 20;
            txtComentariosAprovado.MaxLength = 100;
            txtEntrevistadoAproveitamento.MaxLength = 20;
            txtComentariosEntrevistado.MaxLength = 100;
            txtMSAvaliacao.MaxLength = 10;
            //FICHA EM EMPREGADO
            txtNomeEmpregado.MaxLength = 60;
            txtQualPosto.MaxLength = 20;
            txtQuemSupervisor.MaxLength = 20;
            txtMotivoSaida.MaxLength = 40;
            txtTreinamentoInforme.MaxLength = 60;
            txtRedacao.MaxLength = 200;
            //ESTABLIDADE
            txtComentarioEstabilidade.MaxLength = 100;
            txtComentarios.MaxLength = 100;
        }
        public void EditarFichaSolicitacaoEmprego()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(this.connetionString);
                string sql1 = "exec RH_ConsultaFichaSolitacaoEmpregadoEditarTxt " + this.IdPessoaP + ";";
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1);
                conn1.Open();
                //MessageBox.Show(IdPessoaP.ToString());

                txtCargo.Text = ds1.Tables[0].Rows[0][1].ToString();
                txtDataCadastro.Text = ds1.Tables[0].Rows[0][2].ToString();
                txtNome.Text = ds1.Tables[0].Rows[0][3].ToString();
                txtIdade.Text = ds1.Tables[0].Rows[0][4].ToString();
                string fumante = ds1.Tables[0].Rows[0][5].ToString();
                if (fumante.ToString() != "") { if (int.Parse(fumante.ToString()) == 1) { radioButtonFS.Checked = true; } else { radioButtonFN.Checked = true; } }
                string regiaoMora = ds1.Tables[0].Rows[0][6].ToString();
                if (regiaoMora.ToString() != "")
                {
                    if (int.Parse(regiaoMora.ToString()) == 1) { radioButtonLeste.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 2) { radioButtonOeste.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 3) { radioButtonNorte.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 4) { radioButtonSul.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 5) { radioButtonCentro.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 6) { radioButtonABC.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 7) { radioButtonGuarulhos.Checked = true; }
                    if (int.Parse(regiaoMora.ToString()) == 8) { radioButtonInterior.Checked = true; }
                }

                //cep
                txtPontoReferencia.Text = ds1.Tables[0].Rows[0][7].ToString();
                txtResideQTLocal.Text = ds1.Tables[0].Rows[0][8].ToString();
                string ID_MOVEL = ds1.Tables[0].Rows[0][9].ToString();
                if (ID_MOVEL.ToString() != "")
                {
                    if (int.Parse(ID_MOVEL.ToString()) == 1) { radioButtonIProprio.Checked = true; }
                    if (int.Parse(ID_MOVEL.ToString()) == 2) { radioButtonIAlugado.Checked = true; }
                    if (int.Parse(ID_MOVEL.ToString()) == 3) { radioButtonICedido.Checked = true; }
                }
                txtTelefonePessoa.Text = ds1.Tables[0].Rows[0][10].ToString();
                maskedtxtCelularPessoa.Text = ds1.Tables[0].Rows[0][11].ToString();
                maskedtxtTelefoneRecardo.Text = ds1.Tables[0].Rows[0][12].ToString();
                maskedtxtCelularRecardo.Text = ds1.Tables[0].Rows[0][13].ToString();
                txtNomeRecardo.Text = ds1.Tables[0].Rows[0][14].ToString();
                maskedtxtRgNome.Text = ds1.Tables[0].Rows[0][15].ToString();
                txtDataOrgaoNome.Text = ds1.Tables[0].Rows[0][16].ToString();
                maskedtxtCpf.Text = ds1.Tables[0].Rows[0][17].ToString();
                txtCarteiraTrabalho.Text = ds1.Tables[0].Rows[0][18].ToString();
                txtSerieNome.Text = ds1.Tables[0].Rows[0][19].ToString();
                txtPisNome.Text = ds1.Tables[0].Rows[0][20].ToString();
                txtTituloEleitor.Text = ds1.Tables[0].Rows[0][21].ToString();
                string COMPROVANTE_VOTACAO = ds1.Tables[0].Rows[0][22].ToString();
                if (COMPROVANTE_VOTACAO.ToString() != "")
                { if (int.Parse(COMPROVANTE_VOTACAO.ToString()) == 1) { radioButtonVotacaoS.Checked = true; } if (int.Parse(COMPROVANTE_VOTACAO.ToString()) == 2) { radioButtonVotacaoN.Checked = true; } }
                txtNReservista.Text = ds1.Tables[0].Rows[0][23].ToString();
                dateTimePickerDataNascimento.Text = ds1.Tables[0].Rows[0][24].ToString();
                txtnaturalDe.Text = ds1.Tables[0].Rows[0][25].ToString();
                txtEstadoNatural.Text = ds1.Tables[0].Rows[0][26].ToString();
                txtNacionalidade.Text = ds1.Tables[0].Rows[0][27].ToString();
                maskedtxtAltura.Text = ds1.Tables[0].Rows[0][28].ToString();
                maskedtxtPeso.Text = ds1.Tables[0].Rows[0][29].ToString();
                txtEmailNome.Text = ds1.Tables[0].Rows[0][30].ToString();
                string ESTADO_CIVIL = ds1.Tables[0].Rows[0][31].ToString();
                if (ESTADO_CIVIL == "")
                {

                }
                if (!(ESTADO_CIVIL == ""))
                {
                    int ID_ESTADO_CIVIL = int.Parse(ESTADO_CIVIL);
                    this.IdEstadoCivil = ID_ESTADO_CIVIL;
                    SqlConnection conn = new SqlConnection(this.connetionString);
                    string Query = "SELECT * FROM P_EstadoCivil WHERE ID_ESTADO_CIVIL = " + ID_ESTADO_CIVIL + ";";
                    SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);

                    comboBoxEstadoCivil.Items.Insert(0, ds.Tables[0].Rows[0][1].ToString());
                    comboBoxEstadoCivil.SelectedIndex = 0;
                    conn.Close();
                }
                txtNomeJunto.Text = ds1.Tables[0].Rows[0][32].ToString();
                dateTimePickerNascimentoJunto.Text = ds1.Tables[0].Rows[0][33].ToString();
                txtNdependentes.Text = ds1.Tables[0].Rows[0][34].ToString();
                txtNFilhos.Text = ds1.Tables[0].Rows[0][35].ToString();
                txtIdadeFilhos.Text = ds1.Tables[0].Rows[0][36].ToString();
                txtNomePai.Text = ds1.Tables[0].Rows[0][37].ToString();
                string ESTADO_PAI = ds1.Tables[0].Rows[0][38].ToString();
                if (ESTADO_PAI.ToString() != "")
                { if (int.Parse(ESTADO_PAI.ToString()) == 1) { radioButtonPS.Checked = true; } if (int.Parse(ESTADO_PAI.ToString()) == 2) { radioButtonPN.Checked = true; } }
                dateTimePickerNascimentoPai.Text = ds1.Tables[0].Rows[0][39].ToString();
                txtNomeMae.Text = ds1.Tables[0].Rows[0][40].ToString();
                string ESTADO_MAE = ds1.Tables[0].Rows[0][41].ToString();
                if (ESTADO_MAE.ToString() != "")
                { if (int.Parse(ESTADO_MAE.ToString()) == 1) { radioButtonMS.Checked = true; } if (int.Parse(ESTADO_MAE.ToString()) == 2) { radioButtonMN.Checked = true; } }
                dateTimePickerNascimentoMae.Text = ds1.Tables[0].Rows[0][42].ToString();
                string ID_CLIENTE = ds1.Tables[0].Rows[0][43].ToString();
                string ID_SITUACAO_CRIMINAL = ds1.Tables[0].Rows[0][44].ToString();
                // NO 45 ENTRAR ID PROFISSAO
                string COMBOBOX_STATUS_MERCADO = ds1.Tables[0].Rows[0][46].ToString();
                if (!(COMBOBOX_STATUS_MERCADO == ""))
                {
                    this.StatusMercado = int.Parse(COMBOBOX_STATUS_MERCADO);
                    SqlConnection conn = new SqlConnection(this.connetionString);
                    string Query = "SELECT ID_STATUS_MERCADO, NOME_STATUS_MERCADO FROM P_StatusMercado WHERE ID_STATUS_MERCADO = " + this.StatusMercado + ";";
                    SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);
                    comboBoxStatusMercado.Items.Insert(0, ds.Tables[0].Rows[0][1].ToString());
                    comboBoxStatusMercado.SelectedIndex = 0;
                    this.StatusMercadoTemp = this.StatusMercado;
                    conn.Close();
                }
                string ID_PESSOA_LOGADA = ds1.Tables[0].Rows[0][47].ToString();
                if (!(ID_PESSOA_LOGADA == ""))
                {
                    SqlConnection conn = new SqlConnection(this.connetionString);
                    string Query = "SELECT USUARIO FROM U_LoginUsuario WHERE ID_LOGIN_USUARIO = " + int.Parse(ID_PESSOA_LOGADA) + ";";
                    SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);
                    ID_PESSOA_LOGADA = ds.Tables[0].Rows[0][0].ToString();
                    conn.Close();
                }
                string ID_PESSOA_LOGADA_ALTERADA = ds1.Tables[0].Rows[0][48].ToString();
                if (!(ID_PESSOA_LOGADA_ALTERADA == ""))
                {
                    SqlConnection conn = new SqlConnection(this.connetionString);
                    string Query = "SELECT USUARIO FROM U_LoginUsuario WHERE ID_LOGIN_USUARIO = " + int.Parse(ID_PESSOA_LOGADA_ALTERADA) + ";";
                    SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);
                    ID_PESSOA_LOGADA_ALTERADA = ds.Tables[0].Rows[0][0].ToString();
                    conn.Close();
                }
                //CRIAÇÃO E ALTERAÇÃO DA FICHA
                if ((ID_PESSOA_LOGADA != "") && (ID_PESSOA_LOGADA_ALTERADA != "")) { label145.Text = "A ficha foi criado por " + ID_PESSOA_LOGADA + " e alterada por " + ID_PESSOA_LOGADA_ALTERADA + ";"; }
                else if ((ID_PESSOA_LOGADA != "") && (ID_PESSOA_LOGADA_ALTERADA == "")) { label145.Text = "A ficha foi criado por " + ID_PESSOA_LOGADA + " e não teve alteração."; }
                //CeP Pessoa
                string ID_CEP = ds1.Tables[0].Rows[0][59].ToString();
                maskedTextBoxCep.Text = ds1.Tables[0].Rows[0][60].ToString();
                txtLogradouroNome.Text = ds1.Tables[0].Rows[0][61].ToString();
                txtEndereco.Text = ds1.Tables[0].Rows[0][62].ToString();
                txtNumero.Text = ds1.Tables[0].Rows[0][63].ToString();
                txtComplemento.Text = ds1.Tables[0].Rows[0][64].ToString();
                txtBairro.Text = ds1.Tables[0].Rows[0][65].ToString();
                txtCidade.Text = ds1.Tables[0].Rows[0][66].ToString();
                txtSigla.Text = ds1.Tables[0].Rows[0][67].ToString();
                txtEstado.Text = ds1.Tables[0].Rows[0][68].ToString();
                //ESCOLARIDADE
                string id_escolaridade = ds1.Tables[0].Rows[0][49].ToString();
                string PRIMEIRO_GRAU = ds1.Tables[0].Rows[0][50].ToString();
                if (PRIMEIRO_GRAU.ToString() != "")
                { if (int.Parse(PRIMEIRO_GRAU.ToString()) == 1) { radioButton1GS.Checked = true; } if (int.Parse(PRIMEIRO_GRAU.ToString()) == 2) { radioButton1GN.Checked = true; } }
                string SEGUNDO_GRAU = ds1.Tables[0].Rows[0][51].ToString();
                if (SEGUNDO_GRAU.ToString() != "")
                { if (int.Parse(SEGUNDO_GRAU.ToString()) == 1) { radioButton2GS.Checked = true; } if (int.Parse(SEGUNDO_GRAU.ToString()) == 2) { radioButton2GN.Checked = true; } }
                string SUPERIOR = ds1.Tables[0].Rows[0][52].ToString();
                if (SUPERIOR.ToString() != "")
                { if (int.Parse(SUPERIOR.ToString()) == 1) { radioButtonSS.Checked = true; } if (int.Parse(SUPERIOR.ToString()) == 2) { radioButtonSN.Checked = true; } }
                txtSuperiorCurso.Text = ds1.Tables[0].Rows[0][53].ToString();
                string ESTUDA_ATUALMENTE = ds1.Tables[0].Rows[0][54].ToString();
                if (ESTUDA_ATUALMENTE.ToString() != "")
                { if (int.Parse(ESTUDA_ATUALMENTE.ToString()) == 1) { radioButtonESS.Checked = true; } if (int.Parse(ESTUDA_ATUALMENTE.ToString()) == 2) { radioButtonESN.Checked = true; } }
                txtEstudaAtualmente.Text = ds1.Tables[0].Rows[0][55].ToString();
                txtAnoEstaCursando.Text = ds1.Tables[0].Rows[0][56].ToString();
                txtBairroCursando.Text = ds1.Tables[0].Rows[0][57].ToString();
                maskedTxtHorarioCursando.Text = ds1.Tables[0].Rows[0][58].ToString();
                //profissional
                string ID_PROFISSIONAL = ds1.Tables[0].Rows[0][69].ToString();
                dateTimePickerFormacaoVigilante.Text = ds1.Tables[0].Rows[0][70].ToString();
                txtNomeAcademiaVigilante.Text = ds1.Tables[0].Rows[0][71].ToString();
                dateTimePickerReciclagem.Text = ds1.Tables[0].Rows[0][72].ToString();
                txtNomeAcademiaReciclagem.Text = ds1.Tables[0].Rows[0][73].ToString();
                txtCursoPortaria.Text = ds1.Tables[0].Rows[0][74].ToString();
                txtEscolaPortaria.Text = ds1.Tables[0].Rows[0][75].ToString();

                string COMPUTACAO = ds1.Tables[0].Rows[0][76].ToString();
                if (COMPUTACAO.ToString() != "")
                { if (int.Parse(COMPUTACAO.ToString()) == 1) { radioButtonCS.Checked = true; } if (int.Parse(COMPUTACAO.ToString()) == 2) { radioButtonCN.Checked = true; } }
                string OUTROS_CURSOS = ds1.Tables[0].Rows[0][77].ToString();
                if (OUTROS_CURSOS.ToString() != "")
                { if (int.Parse(OUTROS_CURSOS.ToString()) == 1) { radioButtonOCS.Checked = true; } if (int.Parse(OUTROS_CURSOS.ToString()) == 2) { radioButtonOCN.Checked = true; } }
                txtQuaisCursos.Text = ds1.Tables[0].Rows[0][78].ToString();
                string RADIO_HT = ds1.Tables[0].Rows[0][79].ToString();
                if (RADIO_HT.ToString() != "")
                { if (int.Parse(RADIO_HT.ToString()) == 1) { radioButtonRHS.Checked = true; } if (int.Parse(RADIO_HT.ToString()) == 2) { radioButtonRHN.Checked = true; } }
                //informacoes
                string ID_INFORMACOES = ds1.Tables[0].Rows[0][80].ToString();
                string FAZ_USO_ILICITO = ds1.Tables[0].Rows[0][81].ToString();
                if (FAZ_USO_ILICITO.ToString() != "")
                { if (int.Parse(FAZ_USO_ILICITO.ToString()) == 1) { radioButtonFATIS.Checked = true; } if (int.Parse(FAZ_USO_ILICITO.ToString()) == 2) { radioButtonFATIN.Checked = true; } }
                // txtNumeroCarteiraMotorista.Text = "123456789";
                txtDrogasIlicitas.Text = ds1.Tables[0].Rows[0][82].ToString();
                string FAZ_TRATAMENTO_MEDICO = ds1.Tables[0].Rows[0][83].ToString();
                if (FAZ_TRATAMENTO_MEDICO.ToString() != "")
                { if (int.Parse(FAZ_TRATAMENTO_MEDICO.ToString()) == 1) { radioButtonFATMS.Checked = true; } if (int.Parse(FAZ_TRATAMENTO_MEDICO.ToString()) == 2) { radioButtonFATMN.Checked = true; } }
                txtTratamentoMedico.Text = ds1.Tables[0].Rows[0][84].ToString();
                string PERIODO_NOTURNO = ds1.Tables[0].Rows[0][85].ToString();
                if (PERIODO_NOTURNO.ToString() != "")
                { if (int.Parse(PERIODO_NOTURNO.ToString()) == 1) { radioButtonPNS.Checked = true; } if (int.Parse(PERIODO_NOTURNO.ToString()) == 2) { radioButtonPNN.Checked = true; } }
                string PRAZO_EXPERIENCIA = ds1.Tables[0].Rows[0][86].ToString();
                if (PRAZO_EXPERIENCIA.ToString() != "")
                { if (int.Parse(PRAZO_EXPERIENCIA.ToString()) == 1) { radioButtonPES.Checked = true; } if (int.Parse(PRAZO_EXPERIENCIA.ToString()) == 2) { radioButtonPEN.Checked = true; } }
                string ESCALA_REVERSAMENTO = ds1.Tables[0].Rows[0][87].ToString();
                if (ESCALA_REVERSAMENTO.ToString() != "")
                { if (int.Parse(ESCALA_REVERSAMENTO.ToString()) == 1) { radioButtonERS.Checked = true; } if (int.Parse(ESCALA_REVERSAMENTO.ToString()) == 2) { radioButtonERN.Checked = true; } }
                string TRANSFERENCIA_BAIRRO = ds1.Tables[0].Rows[0][88].ToString();
                if (TRANSFERENCIA_BAIRRO.ToString() != "")
                { if (int.Parse(TRANSFERENCIA_BAIRRO.ToString()) == 1) { radioButtonTBS.Checked = true; } if (int.Parse(TRANSFERENCIA_BAIRRO.ToString()) == 2) { radioButtonTBN.Checked = true; } }
                string CONHECE_ALGUEM_EMPRESA = ds1.Tables[0].Rows[0][89].ToString();
                if (CONHECE_ALGUEM_EMPRESA.ToString() != "")
                { if (int.Parse(CONHECE_ALGUEM_EMPRESA.ToString()) == 1) { radioButtonConheceAlguemS.Checked = true; } if (int.Parse(CONHECE_ALGUEM_EMPRESA.ToString()) == 2) { radioButtonConheceAlguemN.Checked = true; } }
                string PARENTE = ds1.Tables[0].Rows[0][90].ToString();
                if (PARENTE.ToString() != "")
                { if (int.Parse(PARENTE.ToString()) == 1) { radioButtonParenteS.Checked = true; } if (int.Parse(PARENTE.ToString()) == 2) { radioButtonParenteN.Checked = true; } }
                txtNomeConhecidoEmpresa.Text = ds1.Tables[0].Rows[0][91].ToString();
                txtCargoConhecidoEmpresa.Text = ds1.Tables[0].Rows[0][92].ToString();
                txtTrabalhoConhecidoEmpresa.Text = ds1.Tables[0].Rows[0][93].ToString();
                //profissional 2
                string ID_PROFISSIONAL2 = ds1.Tables[0].Rows[0][94].ToString();
                txtUltimoEmprego.Text = ds1.Tables[0].Rows[0][95].ToString();
                txtUltimoCargo.Text = ds1.Tables[0].Rows[0][96].ToString();
                txtUltimoSalario.Text = ds1.Tables[0].Rows[0][97].ToString();
                dateTimePickerUltimaEntrada.Text = ds1.Tables[0].Rows[0][98].ToString();
                dateTimePickerUltimaSaida.Text = ds1.Tables[0].Rows[0][99].ToString();
                txtNomeUltimoChefe.Text = ds1.Tables[0].Rows[0][100].ToString();
                maskedtxtTelefoneUltimoEmprego.Text = ds1.Tables[0].Rows[0][101].ToString();
                txtMotivoSaidaUltimoEmprego.Text = ds1.Tables[0].Rows[0][102].ToString();
                txtPenultimoEmprego.Text = ds1.Tables[0].Rows[0][103].ToString();
                txtPenultimoCargo.Text = ds1.Tables[0].Rows[0][104].ToString();
                txtPenultimoSalario.Text = ds1.Tables[0].Rows[0][105].ToString();
                dateTimePickerPenultimaEntrada.Text = ds1.Tables[0].Rows[0][106].ToString();
                dateTimePickerPenultimaSaida.Text = ds1.Tables[0].Rows[0][107].ToString();
                txtNomePenultimoChefe.Text = ds1.Tables[0].Rows[0][108].ToString();
                maskedtxtTelefonePenultimoEmprego.Text = ds1.Tables[0].Rows[0][109].ToString();
                txtMotivoSaidaPenultimoEmprego.Text = ds1.Tables[0].Rows[0][110].ToString();
                txtAntepenultimoEmprego.Text = ds1.Tables[0].Rows[0][111].ToString();
                txtAntepenultimoCargo.Text = ds1.Tables[0].Rows[0][112].ToString();
                txtAntepenultimoSalario.Text = ds1.Tables[0].Rows[0][113].ToString();
                dateTimePickerAntepenultimoEntrada.Text = ds1.Tables[0].Rows[0][114].ToString();
                dateTimePickerAntepenultimoSaida.Text = ds1.Tables[0].Rows[0][115].ToString();
                txtNomeAntepenultimoChefe.Text = ds1.Tables[0].Rows[0][116].ToString();
                maskedtxtTelefoneAntepenultimoEmprego.Text = ds1.Tables[0].Rows[0][117].ToString();
                txtMotivoSaidaAntepenultimoEmprego.Text = ds1.Tables[0].Rows[0][118].ToString();
                string ID_RECRUTAMENTO = ds1.Tables[0].Rows[0][119].ToString();
                txtRecutamentoSelecao.Text = ds1.Tables[0].Rows[0][120].ToString();
                //AVALIACAO
                string ID_AVALIACAO = ds1.Tables[0].Rows[0][121].ToString();
                string PARECER_APROVADO = ds1.Tables[0].Rows[0][122].ToString();
                if (PARECER_APROVADO.ToString() != "")
                { if (int.Parse(PARECER_APROVADO.ToString()) == 1) { radioButtonPAS.Checked = true; } if (int.Parse(PARECER_APROVADO.ToString()) == 2) { radioButtonPAN.Checked = true; } }
                txtEntrevistadoAprovado.Text = ds1.Tables[0].Rows[0][123].ToString();
                txtComentariosAprovado.Text = ds1.Tables[0].Rows[0][124].ToString();
                string PARECER_APROVEITAMENTO = ds1.Tables[0].Rows[0][125].ToString();
                if (PARECER_APROVEITAMENTO.ToString() != "")
                { if (int.Parse(PARECER_APROVEITAMENTO.ToString()) == 1) { radioButtonPFAS.Checked = true; } if (int.Parse(PARECER_APROVEITAMENTO.ToString()) == 2) { radioButtonPFAN.Checked = true; } }
                txtEntrevistadoAproveitamento.Text = ds1.Tables[0].Rows[0][126].ToString();
                txtComentariosEntrevistado.Text = ds1.Tables[0].Rows[0][127].ToString();
                dateTimePickerDataTreinamentoAvaliacao.Text = ds1.Tables[0].Rows[0][128].ToString();
                txtMSAvaliacao.Text = ds1.Tables[0].Rows[0][129].ToString();
                //ESTABILIDADE
                string ID_ESTABILIDADE_PESSOA = ds1.Tables[0].Rows[0][130].ToString();
                string COMBOBOX_ESTABILIDADE = ds1.Tables[0].Rows[0][131].ToString();
                if (COMBOBOX_ESTABILIDADE == "")
                {

                }
                if (!(COMBOBOX_ESTABILIDADE == ""))
                {
                    int ID_ESTABILIDADE = int.Parse(COMBOBOX_ESTABILIDADE);
                    this.IdPEstabilidade = ID_ESTABILIDADE;
                    SqlConnection conn = new SqlConnection(this.connetionString);
                    string Query = "SELECT * FROM P_Estabilidade WHERE ID_ESTABILIDADE = " + ID_ESTABILIDADE + ";";
                    SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);
                    comboBoxEstabilidade.Items.Insert(0, ds.Tables[0].Rows[0][1].ToString());
                    comboBoxEstabilidade.SelectedIndex = 0;
                    conn.Close();
                }
                if ((this.StatusMercado == 1) || (this.StatusMercado == 2)) { comboBoxStatusMercado.Enabled = false; }
                txtComentarioEstabilidade.Text = ds1.Tables[0].Rows[0][132].ToString();
                //CARTEIRA MOTORISTA
                string ID_MOTORISTA = ds1.Tables[0].Rows[0][133].ToString();
                txtNumeroCarteiraMotorista.Text = ds1.Tables[0].Rows[0][134].ToString();
                dateTimePickerDataValidadeCMotorista.Text = ds1.Tables[0].Rows[0][135].ToString();
                string CARTA_A = ds1.Tables[0].Rows[0][136].ToString();
                if (CARTA_A.ToString() != "")
                { if (int.Parse(CARTA_A.ToString()) == 1) { checkBoxCMA.Checked = true; } if (int.Parse(CARTA_A.ToString()) == 2) { checkBoxCMA.Checked = false; } }
                string CARTA_B = ds1.Tables[0].Rows[0][137].ToString();
                if (CARTA_B.ToString() != "")
                { if (int.Parse(CARTA_B.ToString()) == 1) { checkBoxCMB.Checked = true; } if (int.Parse(CARTA_B.ToString()) == 2) { checkBoxCMB.Checked = false; } }
                string CARTA_C = ds1.Tables[0].Rows[0][138].ToString();
                if (CARTA_C.ToString() != "")
                { if (int.Parse(CARTA_C.ToString()) == 1) { checkBoxCMC.Checked = true; } if (int.Parse(CARTA_C.ToString()) == 2) { checkBoxCMC.Checked = false; } }
                string CARTA_D = ds1.Tables[0].Rows[0][139].ToString();
                if (CARTA_D.ToString() != "")
                { if (int.Parse(CARTA_D.ToString()) == 1) { checkBoxCMD.Checked = true; } if (int.Parse(CARTA_D.ToString()) == 2) { checkBoxCMD.Checked = false; } }
                // ID CONHECE EMPRESA            
                string ID_EMPRESA_CONHECE = ds1.Tables[0].Rows[0][140].ToString();
                string PLAQUEIRA = ds1.Tables[0].Rows[0][141].ToString();
                if (PLAQUEIRA.ToString() != "")
                { if (int.Parse(PLAQUEIRA.ToString()) == 1) { checkBoxCCEP.Checked = true; } if (int.Parse(PLAQUEIRA.ToString()) == 2) { checkBoxCCEP.Checked = false; } }
                string INDICACAO = ds1.Tables[0].Rows[0][142].ToString();
                if (INDICACAO.ToString() != "")
                { if (int.Parse(INDICACAO.ToString()) == 1) { checkBoxCCEI.Checked = true; } if (int.Parse(INDICACAO.ToString()) == 2) { checkBoxCCEI.Checked = false; } }
                string ESCOLA = ds1.Tables[0].Rows[0][143].ToString();
                if (ESCOLA.ToString() != "")
                { if (int.Parse(ESCOLA.ToString()) == 1) { checkBoxCCEE.Checked = true; } if (int.Parse(ESCOLA.ToString()) == 2) { checkBoxCCEE.Checked = false; } }
                string JORNAL = ds1.Tables[0].Rows[0][144].ToString();
                if (JORNAL.ToString() != "")
                { if (int.Parse(JORNAL.ToString()) == 1) { checkBoxCCEJ.Checked = true; } if (int.Parse(JORNAL.ToString()) == 2) { checkBoxCCEJ.Checked = false; } }
                string OUTROS = ds1.Tables[0].Rows[0][145].ToString();
                if (OUTROS.ToString() != "")
                { if (int.Parse(OUTROS.ToString()) == 1) { checkBoxCCEO.Checked = true; } if (int.Parse(OUTROS.ToString()) == 2) { checkBoxCCEO.Checked = false; } }
                string CONVOCADO = ds1.Tables[0].Rows[0][146].ToString();
                if (CONVOCADO.ToString() != "")
                { if (int.Parse(CONVOCADO.ToString()) == 1) { checkBoxCCEC.Checked = true; } if (int.Parse(CONVOCADO.ToString()) == 2) { checkBoxCCEC.Checked = false; } }
                string ID_REDACAO = ds1.Tables[0].Rows[0][147].ToString();
                txtRedacao.Text = ds1.Tables[0].Rows[0][148].ToString();
                //EX EMPREGADO
                this.IdExEmpregado = ds1.Tables[0].Rows[0][149].ToString(); //ID TABELA
                if (IdExEmpregado != "") { radioButtonJTEMSS.Checked = true; radioButtonJTEMSS.Enabled = false; radioButtonJTEMSN.Enabled = false; }
                txtNomeEmpregado.Text = ds1.Tables[0].Rows[0][150].ToString();
                string EX_FUNCIONARIO = ds1.Tables[0].Rows[0][151].ToString(); //ID
                txtQualPosto.Text = ds1.Tables[0].Rows[0][152].ToString();
                dateTimePickerAdmissaoEmpregado.Text = ds1.Tables[0].Rows[0][153].ToString();
                dateTimePickerDemissaoEmpregado.Text = ds1.Tables[0].Rows[0][154].ToString();
                txtQuemSupervisor.Text = ds1.Tables[0].Rows[0][155].ToString();
                txtMotivoSaida.Text = ds1.Tables[0].Rows[0][156].ToString();
                txtREEmpregado.Text = ds1.Tables[0].Rows[0][157].ToString();
                txtTreinamentoInforme.Text = ds1.Tables[0].Rows[0][158].ToString();
                //ID PASSAGEM CRIMINAL
                this.IdPassagemCriminal = ds1.Tables[0].Rows[0][159].ToString(); //ID TABELA
                if (IdPassagemCriminal != "") { checkBoxPassagemCriminal.Checked = true; checkBoxPassagemCriminal.Enabled = false; }
                txtComentarios.Text = ds1.Tables[0].Rows[0][160].ToString();
                //ID PROFISSAO PESSOA.Text = ds1.Tables[0].Rows[0][158].ToString();
                //PESSOA ID PROFISSAO E NOME
                string ID_PROFISSAO = ds1.Tables[0].Rows[0][161].ToString();
                if (ID_PROFISSAO != "")
                {
                    this.IdProfissao = int.Parse(ID_PROFISSAO);
                    SqlConnection conn = new SqlConnection(this.connetionString);
                    string Query = "SELECT * FROM P_Profissao WHERE ID_PROFISSAO = " + this.IdProfissao + ";";
                    SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);
                    comboBoxProfissao.Items.Insert(0, ds.Tables[0].Rows[0][1].ToString());
                    comboBoxProfissao.SelectedIndex = 0;
                    conn.Close();

                }
                //txtTreinamentoInforme.Text = "AAAAA";
                //ds1.Tables[0].Rows[0][].ToString();
                conn1.Close();

                if (this.StatusMercado == 3){ comboBoxStatusMercado.Enabled = false; buttonLiberar.Enabled = true; }
                FotoFicha();
            }
            catch (Exception ex ){MessageBox.Show(" error" + ex.ToString());}
        }
        void Fill_listBoxTodasStatusMercado()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC RH_ConsultaStatusMercado;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxStatusMercado.Items.Add(name);
                    //comboBoxStatusMercado.Items.Insert(0, dr.GetString(0));
                    //comboBoxStatusMercado.SelectedIndex = 0;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxStatusMercado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "SELECT ID_STATUS_MERCADO, NOME_STATUS_MERCADO FROM P_StatusMercado WHERE NOME_STATUS_MERCADO = '" + this.comboBoxStatusMercado.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    this.StatusMercado = dr.GetInt32(0);
                    comboBoxStatusMercado.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxProfissao()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC RH_ConsultaCadastroTodosProfissao;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxProfissao.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxProfissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = " SELECT ID_PROFISSAO, NOME_PROFISSAO FROM P_Profissao WHERE NOME_PROFISSAO = '" + this.comboBoxProfissao.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdProfissao = dr.GetInt32(0);
                    comboBoxProfissao.Text = dr.GetString(1);
                    //label8.Text = dr.GetString(1);
                    //this.ComboBoxAbreviacao = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxEstadoCivil()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC RH_ConsultaCadastroTodosEstadoCivil;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxEstadoCivil.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = " SELECT ID_ESTADO_CIVIL, ESTADO_CIVIL P_EstadoCivil FROM P_EstadoCivil WHERE ESTADO_CIVIL = '" + this.comboBoxEstadoCivil.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdEstadoCivil = dr.GetInt32(0);
                    comboBoxEstadoCivil.Text = dr.GetString(1);
                    //label8.Text = dr.GetString(1);
                    //this.ComboBoxAbreviacao = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxTodasEstabilidade()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC RH_ConsultaCadastroTodosEstabilidade;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxEstabilidade.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxEstabilidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = " SELECT ID_ESTABILIDADE, NOME_ESTABILIDADE FROM P_Estabilidade WHERE NOME_ESTABILIDADE = '" + this.comboBoxEstabilidade.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdPEstabilidade = dr.GetInt32(0);
                    comboBoxEstabilidade.Text = dr.GetString(1);
                    //label8.Text = dr.GetString(1);
                    //this.ComboBoxAbreviacao = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormFichaSolicitacaoEmpregoEditar_Load(object sender, EventArgs e)
        {

        }
        public static void FechatodosOsFormularios(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.Close();

                    //MessageBox.Show("Formulario Já foi Fechado.");


                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }
        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtREEmpregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtNdependentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtNFilhos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void buttonCepPrincipal_Click(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                    .Replace("@cep", maskedTextBoxCep.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                labelConfirmacaoPrimario.Text = ds.Tables[0].Rows[0][1].ToString();
                txtLogradouroNome.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEndereco.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSigla.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show(" Erro: " + e.ToString());
            }
        }

        private void txtUltimoSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPenultimoSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtAntepenultimoSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;

            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }

        private void txtUltimoSalario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtUltimoSalario);
            txtUltimoSalario.TextAlign = HorizontalAlignment.Right;
        }

        private void txtPenultimoSalario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPenultimoSalario);
            txtPenultimoSalario.TextAlign = HorizontalAlignment.Right;
        }

        private void txtAntepenultimoSalario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtAntepenultimoSalario);
            txtAntepenultimoSalario.TextAlign = HorizontalAlignment.Right;
        }

        private void buttonSalvaCadastro_Click(object sender, EventArgs e)
        {
            SalvaEditar();
        }
        public void SalvaEditar()
        {
            try
            {
                int contador = 0;
                DadosPessoas PPessoas = new DadosPessoas();
                Escolaridade PEscolaridade = new Escolaridade();
                Profissionais PProfissionais = new Profissionais();
                Informacoes PInformacoes = new Informacoes();
                Profissional2 PProfissionais2 = new Profissional2();
                Avaliacao PAvaliacao = new Avaliacao();
                ExEmpregado PExEmpregado = new ExEmpregado();
                PassagemCriminal PPassagemCriminal = new PassagemCriminal();

                //AMAZENAR DADOS PESSOAS
                PPessoas.txtCargo = txtCargo.Text;
                PPessoas.txtDataCadastro = txtDataCadastro.Text;
                PPessoas.txtNome = txtNome.Text;
                if (txtIdade.Text != "") { PPessoas.txtIdade = txtIdade.Text; }
                PPessoas.maskedTextBoxCep = maskedTextBoxCep.Text;
                PPessoas.txtEndereco = txtEndereco.Text;
                PPessoas.txtNumero = txtNumero.Text;
                PPessoas.txtBairro = txtBairro.Text;
                PPessoas.txtComplemento = txtComplemento.Text;
                PPessoas.txtLogradouroNome = txtLogradouroNome.Text;
                PPessoas.txtCidadeNome = txtCidade.Text;
                PPessoas.txtSiglaNome = txtSigla.Text;
                PPessoas.txtEstado = txtEstado.Text;
                if (radioButtonFS.Checked == true) { PPessoas.radioButtonFSN = 1; }
                if (radioButtonFN.Checked == true) { PPessoas.radioButtonFSN = 2; }
                if (radioButtonLeste.Checked == true) { PPessoas.radioButtonRegiao = 1; }
                if (radioButtonOeste.Checked == true) { PPessoas.radioButtonRegiao = 2; }
                if (radioButtonNorte.Checked == true) { PPessoas.radioButtonRegiao = 3; }
                if (radioButtonSul.Checked == true) { PPessoas.radioButtonRegiao = 4; }
                if (radioButtonCentro.Checked == true) { PPessoas.radioButtonRegiao = 5; }
                if (radioButtonABC.Checked == true) { PPessoas.radioButtonRegiao = 6; }
                if (radioButtonGuarulhos.Checked == true) { PPessoas.radioButtonRegiao = 7; }
                if (radioButtonInterior.Checked == true) { PPessoas.radioButtonRegiao = 8; }
                PPessoas.txtPontoReferencia = txtPontoReferencia.Text;
                PPessoas.txtResideQTLocal = txtResideQTLocal.Text;
                if (radioButtonIProprio.Checked == true) { PPessoas.radioButtonMoradia = 1; }
                if (radioButtonIAlugado.Checked == true) { PPessoas.radioButtonMoradia = 2; }
                if (radioButtonICedido.Checked == true) { PPessoas.radioButtonMoradia = 3; }
                PPessoas.txtTelefonePessoa = txtTelefonePessoa.Text;
                PPessoas.maskedtxtCelularPessoa = maskedtxtCelularPessoa.Text;
                PPessoas.maskedtxtTelefoneRecardo = maskedtxtTelefoneRecardo.Text;
                PPessoas.maskedtxtCelularRecardo = maskedtxtCelularRecardo.Text;
                PPessoas.txtNomeRecardo = txtNomeRecardo.Text;
                PPessoas.maskedtxtRgNome = maskedtxtRgNome.Text;
                PPessoas.txtDataOrgaoNome = txtDataOrgaoNome.Text;
                PPessoas.maskedtxtCpf = maskedtxtCpf.Text;
                PPessoas.txtCarteiraTrabalho = txtCarteiraTrabalho.Text;
                PPessoas.txtSerieNome = txtSerieNome.Text;
                PPessoas.txtPisNome = txtPisNome.Text;
                PPessoas.txtTituloEleitor = txtTituloEleitor.Text;
                if (radioButtonVotacaoS.Checked == true) { PPessoas.radioButtonVotacaoSN = 1; }
                if (radioButtonVotacaoN.Checked == true) { PPessoas.radioButtonVotacaoSN = 2; }
                PPessoas.txtNReservista = txtNReservista.Text;
                PPessoas.dateTimePickerDataNascimento = dateTimePickerDataNascimento.Text;
                PPessoas.txtnaturalDe = txtnaturalDe.Text;
                PPessoas.txtEstadoNatural = txtEstadoNatural.Text;
                PPessoas.txtNacionalidade = txtNacionalidade.Text;
                PPessoas.maskedtxtAltura = maskedtxtAltura.Text;
                PPessoas.maskedtxtPeso = maskedtxtPeso.Text;
                PPessoas.txtEmailNome = txtEmailNome.Text;
                PPessoas.txtEstadoCivil = this.IdEstadoCivil;
                PPessoas.txtNomeJunto = txtNomeJunto.Text;
                PPessoas.dateTimePickerNascimentoJunto = dateTimePickerNascimentoJunto.Text;
                PPessoas.txtNdependentes = txtNdependentes.Text;
                PPessoas.txtNFilhos = txtNFilhos.Text;
                PPessoas.txtIdadeFilhos = txtIdadeFilhos.Text;
                PPessoas.txtNomePai = txtNomePai.Text;
                if (radioButtonPS.Checked == true) { PPessoas.radioButtonPSN = 1; }
                if (radioButtonPN.Checked == true) { PPessoas.radioButtonPSN = 2; }
                PPessoas.dateTimePickerNascimentoPai = dateTimePickerNascimentoPai.Text;
                PPessoas.txtNomeMae = txtNomeMae.Text;
                if (radioButtonMS.Checked == true) { PPessoas.radioButtonMVS = 1; }
                if (radioButtonMN.Checked == true) { PPessoas.radioButtonMVS = 2; }
                PPessoas.dateTimePickerNascimentoMae = dateTimePickerNascimentoMae.Text;
                PPessoas.ID_Cliente_MS = txtMSAvaliacao.Text;
                if (checkBoxPassagemCriminal.Checked == true) { PPessoas.SituacaoCriminal = 1; } else { PPessoas.SituacaoCriminal = 2; }
                PPessoas.IdProfissao = this.IdProfissao;
                PPessoas.StatusMercado = this.StatusMercado;
                PPessoas.IdPessoaLogada = this.IdLoginUsuario;
                //ESCOLARIDADE
                if (radioButton1GS.Checked == true) { PEscolaridade.radioButton1GN = 1; }
                if (radioButton1GN.Checked == true) { PEscolaridade.radioButton1GN = 2; }
                if (radioButton2GS.Checked == true) { PEscolaridade.radioButton2GSN = 1; }
                if (radioButton2GN.Checked == true) { PEscolaridade.radioButton2GSN = 2; }
                if (radioButtonSS.Checked == true) { PEscolaridade.radioButtonSSN = 1; }
                if (radioButtonSN.Checked == true) { PEscolaridade.radioButtonSSN = 2; }
                PEscolaridade.txtSuperiorCurso = txtSuperiorCurso.Text;
                if (radioButtonERS.Checked == true) { PEscolaridade.radioButtonESSN = 1; }
                if (radioButtonERN.Checked == true) { PEscolaridade.radioButtonESSN = 2; }
                PEscolaridade.txtEstudaAtualmente = txtEstudaAtualmente.Text;
                PEscolaridade.txtAnoEstaCursando = txtAnoEstaCursando.Text;
                PEscolaridade.txtBairroCursando = txtBairroCursando.Text;
                PEscolaridade.maskedTxtHorarioCursando = maskedTxtHorarioCursando.Text;
                ///HABILIDADES PROFISSIONAIS
                PProfissionais.dateTimePickerFormacaoVigilante = dateTimePickerFormacaoVigilante.Text;
                PProfissionais.txtNomeAcademiaVigilante = txtNomeAcademiaVigilante.Text;
                PProfissionais.dateTimePickerReciclagem = dateTimePickerReciclagem.Text;
                PProfissionais.txtCursoPortaria = txtCursoPortaria.Text;
                PProfissionais.txtEscolaPortaria = txtEscolaPortaria.Text;
                if (radioButtonCS.Checked == true) { PProfissionais.radioButtonCSN = 1; }
                if (radioButtonCN.Checked == true) { PProfissionais.radioButtonCSN = 2; }
                if (radioButtonOCS.Checked == true) { PProfissionais.radioButtonOCSN = 1; }
                if (radioButtonOCN.Checked == true) { PProfissionais.radioButtonOCSN = 2; }
                PProfissionais.txtQuaisCursos = txtQuaisCursos.Text;
                if (radioButtonRHS.Checked == true) { PProfissionais.radioButtonRHSN = 1; }
                if (radioButtonRHN.Checked == true) { PProfissionais.radioButtonRHSN = 2; }
                //INFORMAÇÕES
                if (checkBoxCMA.Checked == true) { PInformacoes.checkBoxCMA = 1; } else { PInformacoes.checkBoxCMA = 2; }
                if (checkBoxCMB.Checked == true) { PInformacoes.checkBoxCMB = 1; } else { PInformacoes.checkBoxCMB = 2; }
                if (checkBoxCMC.Checked == true) { PInformacoes.checkBoxCMC = 1; } else { PInformacoes.checkBoxCMC = 2; }
                if (checkBoxCMD.Checked == true) { PInformacoes.checkBoxCMD = 1; } else { PInformacoes.checkBoxCMD = 2; }
                PInformacoes.txtNumeroCarteiraMotorista = txtNumeroCarteiraMotorista.Text;
                PInformacoes.dateTimePickerDataValidadeCMotorista = dateTimePickerDataValidadeCMotorista.Text;
                if (radioButtonFATIS.Checked == true) { PInformacoes.radioButtonFATISN = 1; }
                if (radioButtonFATIN.Checked == true) { PInformacoes.radioButtonFATISN = 2; }
                PInformacoes.txtDrogasIlicitas = txtDrogasIlicitas.Text;
                if (radioButtonFATMS.Checked == true) { PInformacoes.radioButtonFATMS = 1; }
                if (radioButtonFATMN.Checked == true) { PInformacoes.radioButtonFATMS = 2; }
                PInformacoes.txtTratamentoMedico = txtTratamentoMedico.Text;
                if (radioButtonPNS.Checked == true) { PInformacoes.radioButtonPNSN = 1; }
                if (radioButtonPNN.Checked == true) { PInformacoes.radioButtonPNSN = 2; }
                if (radioButtonPES.Checked == true) { PInformacoes.radioButtonPESN = 1; }
                if (radioButtonPEN.Checked == true) { PInformacoes.radioButtonPESN = 2; }
                if (radioButtonERS.Checked == true) { PInformacoes.radioButtonERSN = 1; }
                if (radioButtonERN.Checked == true) { PInformacoes.radioButtonERSN = 2; }
                if (radioButtonTBS.Checked == true) { PInformacoes.radioButtonTBSN = 1; }
                if (radioButtonTBN.Checked == true) { PInformacoes.radioButtonTBSN = 2; }
                if (radioButtonConheceAlguemS.Checked == true) { PInformacoes.radioButtonConheceAlguemSN = 1; }
                if (radioButtonConheceAlguemN.Checked == true) { PInformacoes.radioButtonConheceAlguemSN = 2; }
                PInformacoes.txtNomeConhecidoEmpresa = txtNomeConhecidoEmpresa.Text;
                PInformacoes.txtCargoConhecidoEmpresa = txtCargoConhecidoEmpresa.Text;
                PInformacoes.txtTrabalhoConhecidoEmpresa = txtTrabalhoConhecidoEmpresa.Text;
                if (checkBoxCCEP.Checked == true) { PInformacoes.checkBoxPlaqueira = 1; } else { PInformacoes.checkBoxPlaqueira = 2; }
                if (checkBoxCCEI.Checked == true) { PInformacoes.checkBoxIndicacao = 1; } else { PInformacoes.checkBoxIndicacao = 2; }
                if (checkBoxCCEE.Checked == true) { PInformacoes.checkBoxEscola = 1; } else { PInformacoes.checkBoxEscola = 2; }
                if (checkBoxCCEJ.Checked == true) { PInformacoes.checkBoxJornal = 1; } else { PInformacoes.checkBoxJornal = 2; }
                if (checkBoxCCEO.Checked == true) { PInformacoes.checkBoxOutros = 1; } else { PInformacoes.checkBoxOutros = 2; }
                if (checkBoxCCEC.Checked == true) { PInformacoes.checkBoxConvocado = 1; } else { PInformacoes.checkBoxConvocado = 2; }
                //EXPERIÊNCIA PROFFISIONAL
                PProfissionais2.txtUltimoEmprego = txtUltimoEmprego.Text;
                PProfissionais2.txtUltimoCargo = txtUltimoCargo.Text;
                PProfissionais2.txtUltimoSalario = txtUltimoSalario.Text;
                PProfissionais2.dateTimePickerUltimaEntrada = dateTimePickerUltimaEntrada.Text;
                PProfissionais2.dateTimePickerUltimaSaida = dateTimePickerUltimaSaida.Text;
                PProfissionais2.txtNomeUltimoChefe = txtNomeUltimoChefe.Text;
                PProfissionais2.maskedtxtTelefoneUltimoEmprego = maskedtxtTelefoneUltimoEmprego.Text;
                PProfissionais2.txtMotivoSaidaUltimoEmprego = txtMotivoSaidaUltimoEmprego.Text;
                PProfissionais2.txtPenultimoEmprego = txtPenultimoEmprego.Text;
                PProfissionais2.txtPenultimoCargo = txtPenultimoCargo.Text;
                PProfissionais2.txtPenultimoSalario = txtPenultimoSalario.Text;
                PProfissionais2.dateTimePickerPenultimaEntrada = dateTimePickerPenultimaEntrada.Text;
                PProfissionais2.dateTimePickerPenultimaSaida = dateTimePickerPenultimaSaida.Text;
                PProfissionais2.txtNomePenultimoChefe = txtNomePenultimoChefe.Text;
                PProfissionais2.maskedtxtTelefonePenultimoEmprego = maskedtxtTelefonePenultimoEmprego.Text;
                PProfissionais2.txtMotivoSaidaPenultimoEmprego = txtMotivoSaidaPenultimoEmprego.Text;
                PProfissionais2.txtAntepenultimoEmprego = txtAntepenultimoEmprego.Text;
                PProfissionais2.txtAntepenultimoCargo = txtAntepenultimoCargo.Text;
                PProfissionais2.txtAntepenultimoSalario = txtAntepenultimoSalario.Text;
                PProfissionais2.dateTimePickerAntepenultimoEntrada = dateTimePickerAntepenultimoEntrada.Text;
                PProfissionais2.dateTimePickerAntepenultimoSaida = dateTimePickerAntepenultimoSaida.Text;
                PProfissionais2.txtNomeAntepenultimoChefe = txtNomeAntepenultimoChefe.Text;
                PProfissionais2.maskedtxtTelefoneAntepenultimoEmprego = maskedtxtTelefoneAntepenultimoEmprego.Text;
                PProfissionais2.txtMotivoSaidaAntepenultimoEmprego = txtMotivoSaidaAntepenultimoEmprego.Text;
                PProfissionais2.txtRecutamentoSelecao = txtRecutamentoSelecao.Text;
                //AVALIAÇÃO TÉCNICA
                if (radioButtonPAS.Checked == true) { PAvaliacao.radioButtonPASN = 1; }
                if (radioButtonPAN.Checked == true) { PAvaliacao.radioButtonPASN = 2; }
                PAvaliacao.txtEntrevistadoAprovado = txtEntrevistadoAprovado.Text;
                PAvaliacao.txtComentariosAprovado = txtComentariosAprovado.Text;
                if (radioButtonPFAS.Checked == true) { PAvaliacao.radioButtonPFASN = 1; }
                if (radioButtonPFAN.Checked == true) { PAvaliacao.radioButtonPFASN = 2; }
                PAvaliacao.txtEntrevistadoAproveitamento = txtEntrevistadoAproveitamento.Text;
                PAvaliacao.txtComentariosEntrevistado = txtComentariosEntrevistado.Text;
                PAvaliacao.dateTimePickerDataTreinamentoAvaliacao = dateTimePickerDataTreinamentoAvaliacao.Text;
                PAvaliacao.txtMSAvaliacao = txtMSAvaliacao.Text;
                // EX - EMPREGADO
                PExEmpregado.txtNomeEmpregado = txtNomeEmpregado.Text;
                if (radioButtonJTEMSS.Checked == true) { PExEmpregado.radioButtonJTEMSS = 1; }
                if (radioButtonJTEMSN.Checked == true) { PExEmpregado.radioButtonJTEMSS = 2; }
                PExEmpregado.txtQualPosto = txtQualPosto.Text;
                PExEmpregado.dateTimePickerAdmissaoEmpregado = dateTimePickerAdmissaoEmpregado.Text;
                PExEmpregado.dateTimePickerDemissaoEmpregado = dateTimePickerDemissaoEmpregado.Text;
                PExEmpregado.txtQuemSupervisor = txtQuemSupervisor.Text;
                PExEmpregado.txtMotivoSaida = txtMotivoSaida.Text;
                PExEmpregado.txtREEmpregado = txtREEmpregado.Text;
                PExEmpregado.txtTreinamentoInforme = txtTreinamentoInforme.Text;
                //REDACAO
                PExEmpregado.txtRedacao = txtRedacao.Text;
                //PASSAGEM CRIMINAL
                if (checkBoxPassagemCriminal.Checked == true) { PPassagemCriminal.checkboxPassagemCriminal = 1; } else { PPassagemCriminal.checkboxPassagemCriminal = 2; }
                PPassagemCriminal.txtComentarios = txtComentarios.Text;
                //ESTABILIDADE
                PPessoas.Id_Estabilidade = IdPEstabilidade;
                PPessoas.ComentarioEstabilidade = txtComentarioEstabilidade.Text;

                //VERIFICAR REGRAS

                if (dateTimePickerDataNascimento.ToString() == dateTimePickerDataDia.ToString()) { PPessoas.dateTimePickerDataNascimento = ""; }
                if (dateTimePickerNascimentoJunto.ToString() == dateTimePickerDataDia.ToString()) { PPessoas.dateTimePickerNascimentoJunto = ""; }
                if (dateTimePickerNascimentoPai.ToString() == dateTimePickerDataDia.ToString()) { PPessoas.dateTimePickerNascimentoPai = ""; }
                if (dateTimePickerNascimentoMae.ToString() == dateTimePickerDataDia.ToString()) { PPessoas.dateTimePickerNascimentoMae = ""; }
                if (dateTimePickerFormacaoVigilante.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais.dateTimePickerFormacaoVigilante = ""; }
                if (dateTimePickerReciclagem.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais.dateTimePickerReciclagem = ""; }
                if (dateTimePickerUltimaEntrada.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais2.dateTimePickerUltimaEntrada = ""; }
                if (dateTimePickerUltimaSaida.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais2.dateTimePickerUltimaSaida = ""; }
                if (dateTimePickerPenultimaEntrada.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais2.dateTimePickerPenultimaEntrada = ""; }
                if (dateTimePickerPenultimaSaida.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais2.dateTimePickerPenultimaSaida = ""; }
                if (dateTimePickerAntepenultimoEntrada.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais2.dateTimePickerAntepenultimoEntrada = ""; }
                if (dateTimePickerAntepenultimoSaida.ToString() == dateTimePickerDataDia.ToString()) { PProfissionais2.dateTimePickerAntepenultimoSaida = ""; }
                if (dateTimePickerDataTreinamentoAvaliacao.ToString() == dateTimePickerDataDia.ToString()) { PAvaliacao.dateTimePickerDataTreinamentoAvaliacao = ""; }
                if (dateTimePickerAdmissaoEmpregado.ToString() == dateTimePickerDataDia.ToString()) { PExEmpregado.dateTimePickerAdmissaoEmpregado = ""; }
                if (dateTimePickerDemissaoEmpregado.ToString() == dateTimePickerDataDia.ToString()) { PExEmpregado.dateTimePickerDemissaoEmpregado = ""; }
                //if (dateTimePickerAdmissaoEmpregado.ToString() == dateTimePickerDataDia.ToString()) { PPessoas.dateTimePickerDataNascimento = ""; }

                if (txtUltimoSalario.Text == "0,00")
                {
                    PProfissionais2.txtUltimoSalario = "";
                }
                if (txtPenultimoSalario.Text == "0,00")
                {
                    PProfissionais2.txtPenultimoSalario = "";
                }
                if (txtAntepenultimoSalario.Text == "0,00")
                {
                    PProfissionais2.txtAntepenultimoSalario = "";
                }

                if (Formatacao(maskedTextBoxCep, 8) == false) { MessageBox.Show("Cep imcompleto!"); contador++; }
                if (Formatacao(txtTelefonePessoa, 10) == false) { MessageBox.Show("Telefone de cadastro imcompleto"); contador++; }
                if (Formatacao(maskedtxtCelularPessoa, 11) == false) { MessageBox.Show("Celular de cadastro imcompleto!"); contador++; }
                if (Formatacao(maskedtxtTelefoneRecardo, 10) == false) { MessageBox.Show("Telefone de recardo imcompleto!"); contador++; }
                if (Formatacao(maskedtxtCelularRecardo, 11) == false) { MessageBox.Show("Celular de recardo imcompleto!"); contador++; }
                if (Formatacao(maskedtxtRgNome, 9) == false) { MessageBox.Show("RG de cadastro imcompleto!"); contador++; }
                if (Formatacao(maskedtxtCpf, 11) == false) { MessageBox.Show("CPF de imcompleto!"); contador++; }
                if (Formatacao(maskedtxtAltura, 3) == false) { MessageBox.Show("Altura de cadastro imcompleto!"); contador++; }
                if (Formatacao(maskedTxtHorarioCursando, 4) == false) { MessageBox.Show("Horário do cursando imcompleto!"); contador++; }
                if (Formatacao(maskedtxtTelefoneUltimoEmprego, 10) == false) { MessageBox.Show("Telefone do ultimo emprego imcompleto!"); contador++; }
                if (Formatacao(maskedtxtTelefonePenultimoEmprego, 10) == false) { MessageBox.Show("Telefone do penúltimo emprego imcompleto!"); contador++; }
                if (Formatacao(maskedtxtTelefoneAntepenultimoEmprego, 10) == false) { MessageBox.Show("Telefone do antepenúltimo imcompleto!"); contador++; }

                if (txtNomePessoa(txtNome, errorProviderEditarFichaEmprego) == true)
                {
                    if (contador == 0)
                    {
                        //DADOS PESSOAS
                        Conexao2 conexao2 = new Conexao2(this.connetionString);
                        DALDateSystemRH dal = new DALDateSystemRH(conexao2); //cadastra Pessoa
                        PPessoas.Id_DadosPessoas = IdPessoaP;
                        dal.UpdateDadosPessoas(PPessoas);

                        //PASSANDO ID PARA CADASTRO
                        PEscolaridade.Id_PessoasEscolaridade = IdPessoaP;
                        PInformacoes.Id_PessoasInformacoes = IdPessoaP;
                        PProfissionais.Id_PessoasProfissional = IdPessoaP;
                        PProfissionais2.Id_PessoaProfissional2 = IdPessoaP;
                        PAvaliacao.Id_PessoasAvaliacao = IdPessoaP;
                        PExEmpregado.Id_PessoasExEmpregado = IdPessoaP;
                        PPassagemCriminal.Id_PessoasPassagemCriminal = IdPessoaP;

                        //CEP
                        DALDateSystemRH da2 = new DALDateSystemRH(conexao2); da2.UpdateCepPessoa(PPessoas);

                        //ESCOLARIDADE
                        DALDateSystemRH da3 = new DALDateSystemRH(conexao2); da3.UpdateEscolaridade(PEscolaridade);

                        //INFORMACOES
                        DALDateSystemRH da4 = new DALDateSystemRH(conexao2); da4.UpdateInformacoes(PInformacoes);

                        //CONHECE EMPRESA
                        DALDateSystemRH da5 = new DALDateSystemRH(conexao2); da5.UpdateCConheceuEmpresa(PInformacoes);

                        //PROFISSIONAL 
                        DALDateSystemRH da6 = new DALDateSystemRH(conexao2); da6.UpdateProfissionais(PProfissionais);

                        //PROFISSIONAL 2
                        DALDateSystemRH da7 = new DALDateSystemRH(conexao2); da7.UpdateProfissionais2(PProfissionais2);

                        //RECRUTAMENTO
                        DALDateSystemRH da8 = new DALDateSystemRH(conexao2); da8.UpdateRecrutamentoSelecao(PProfissionais2);

                        //CARTEIRA DE MOTORISTA
                        DALDateSystemRH da9 = new DALDateSystemRH(conexao2); da9.UdpateCarteiraMotorista(PInformacoes);

                        //AVALIAÇÃO TECNICA
                        DALDateSystemRH da10 = new DALDateSystemRH(conexao2); da10.UpdateAvaliacaoTecnica(PAvaliacao);

                        //AVALIAÇÃO EX EMPREGADO
                        if ((radioButtonJTEMSS.Checked == true) && (this.IdExEmpregado == ""))
                        {
                            DALDateSystemRH da11 = new DALDateSystemRH(conexao2); da11.IncluirExEmpregado(PExEmpregado);
                        }

                        //AVALIAÇÃO EX EMPREGADO
                        if ((radioButtonJTEMSS.Checked == true) && (this.IdExEmpregado != ""))
                        {
                            DALDateSystemRH da12 = new DALDateSystemRH(conexao2); da12.UpdateExEmpregado(PExEmpregado);
                        }

                        //AVALIAÇÃO REDACAO
                        DALDateSystemRH da13 = new DALDateSystemRH(conexao2); da13.UpdateRedacao(PExEmpregado);

                        // AVALIAÇÃO CRIMINAL
                        if (checkBoxPassagemCriminal.Checked == true)
                        {
                            SqlConnection conn = new SqlConnection(this.connetionString);
                            string Query = "SELECT * FROM P_Passagem_Criminal WHERE ID_PASSAGEM_CRIMINAL = " + IdPessoaP + ";";
                            SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                            DataSet ds = new DataSet();
                            sa.Fill(ds);
                            //AVALIAÇÃO CRIMINAL INCLUIR

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                DALDateSystemRH da14 = new DALDateSystemRH(conexao2); da14.IncluirPassagemCriminal(PPassagemCriminal);
                            }
                            //AVALIAÇÃO CRIMINAL UPDATE
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DALDateSystemRH da15 = new DALDateSystemRH(conexao2); da15.UpdatePassagemCriminal(PPassagemCriminal);
                            }
                            conn.Close();
                        }

                        //AVALIAÇÃO ESTABILIDADE
                        DALDateSystemRH da16 = new DALDateSystemRH(conexao2);  da16.UpdateEstabilidade(PPessoas);

                        //ADICIONAR IMAGEM FICHA
                        FichaImagem Imagem = new FichaImagem();

                        Imagem.IdFicha = this.IdPessoaP;

                        if (bmp == null)
                        {

                        }
                        if (bmp != null)
                        {
                            MemoryStream memory = new MemoryStream();

                            bmp.Save(memory, ImageFormat.Bmp);

                            byte[] Foto = memory.ToArray();

                            Imagem.Imagem = Foto;

                            //Acessa Banco de Dados e Salvar Imagem 
                            if (this.ConstaImagem == true)
                            {
                                Imagem.IdLoginUsuario = 0;
                                DALDateSystemRH daUp = new DALDateSystemRH(conexao2);
                                daUp.AlterarFichaImagem(Imagem);
                            }
                            if (this.ConstaImagem == false)
                            {
                                Imagem.IdLoginUsuario = 0;
                                DALDateSystemRH daIn = new DALDateSystemRH(conexao2);
                                daIn.IncluirFichaImagem(Imagem);
                            }
                        }

                        FecharTodosFormulario();
                        MessageBox.Show("Ficha Alterado com Sucesso!");
                    }
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        public void FecharTodosFormulario()
        {
            FechaFormularios(typeof(FormFichaSolicitacaoEmpregoEditar));
        }
        public static void FechaFormularios(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.Close();

                    //MessageBox.Show("Formulario Já foi Fechado.");


                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }
        public Boolean Formatacao(MaskedTextBox texto, int Ma)
        {
            Boolean retorno = true;
            Label TextoRetorno = new Label();
            var conversao = "";

            texto.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            conversao = string.Format(texto.Text);
            conversao = conversao.TrimEnd();
            conversao = conversao.TrimStart();

            StringBuilder conversaoT = new StringBuilder(conversao);

            for (int i = 0; i < conversaoT.Length; i++)
            {
                if (conversaoT[i] == ' ')
                {
                    //conversaoT.Remove(1, i);
                    i = conversaoT.Length;
                    // MessageBox.Show(conversao + " Espaço " + retorno);
                    return false;

                }
            }
            if ((conversao.Length > 0) && (conversao.Length < Ma))
            {
                //MessageBox.Show(conversao + " Tamanho " + retorno);
                return false;
            }

            //MessageBox.Show(conversao + " Correto " + retorno);
            return retorno;
        }

        private void FormFichaSolicitacaoEmpregoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void checkBoxPassagemCriminal_CheckedChanged(object sender, EventArgs e)
        {
            if(AtivarCriminal == false)
            {
                if (checkBoxPassagemCriminal.Checked == true)
                {
                    txtComentarios.Enabled = true;
                    txtComentarios.Clear();
                }
                if (checkBoxPassagemCriminal.Checked == false)
                {
                    txtComentarios.Enabled = false;
                    txtComentarios.Clear();
                }
            }
            if(AtivarCriminal == true)
            {
                checkBoxPassagemCriminal.Checked = false;
            }
        }

        private void radioButtonJTEMSN_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonJTEMSN.Checked == true)
            {
                txtNomeEmpregado.Enabled = false;
                txtQualPosto.Enabled = false;
                dateTimePickerAdmissaoEmpregado.Enabled = false;
                dateTimePickerDemissaoEmpregado.Enabled = false;
                txtQuemSupervisor.Enabled = false;
                txtMotivoSaida.Enabled = false;
                txtREEmpregado.Enabled = false;
                txtTreinamentoInforme.Enabled = false;
            }
        }

        private void radioButtonJTEMSS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJTEMSS.Checked == true)
            {
                txtNomeEmpregado.Enabled = true;
                txtQualPosto.Enabled = true;
                dateTimePickerAdmissaoEmpregado.Enabled = true;
                dateTimePickerDemissaoEmpregado.Enabled = true;
                txtQuemSupervisor.Enabled = true;
                txtMotivoSaida.Enabled = true;
                txtREEmpregado.Enabled = true;
                txtTreinamentoInforme.Enabled = true;
            }
        }

        private void buttonLiberar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja libera ficha para novos processos seletivos " + " ? ", " Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.StatusMercado = 1;
                comboBoxStatusMercado.Items.Clear();
                comboBoxStatusMercado.Items.Insert(0, "Liberado");
                comboBoxStatusMercado.SelectedIndex = 0;
                buttonLiberar.Enabled = false;
                MessageBox.Show("Só salvar alteração!");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo não realizado!");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarFichaF();
        }
        public void EditarFichaF()
        {
            panelDados.Enabled = true;
            panelEscolaridade.Enabled = true;
            panelProfissional.Enabled = true;
            panelAvaliar.Enabled = true;
            panelEmprego.Enabled = true;
            panelHistoria.Enabled = true;
            panelFoto.Enabled = true;
            buttonSalvaCadastro.Enabled = true;
            buttonEditar.Enabled = false;
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void txtPisNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void buttonAnexo_Click(object sender, EventArgs e)
        {
            AnexoFotoFicha();
        }
        public void AnexoFotoFicha()
        {
            openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    openFileDialog.ShowDialog();

                    ImgLocation = openFileDialog.FileNames.ToString();

                    label147.Text = openFileDialog.FileName;

                    pictureBoxImagem.Image = Image.FromFile(openFileDialog.FileName);

                    bmp = new Bitmap(label147.Text);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelado o Anexo da Imagem!");
            }
        }
        public void FotoFicha()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);
            SqlCommand comand = new SqlCommand("RH_ConsultaFichaImagemSalva " + this.IdPessoaP + ";", conn);
            conn.Open();

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.Read())
            {
                byte[] Foto = (byte[])reader["IMAGEM"];
                MemoryStream ms = new MemoryStream(Foto);
                Imagem = Image.FromStream(ms);
            }
            if (Imagem == null)
            {
                //MessageBox.Show("Não existir Imagem!");
            }
            if (Imagem != null)
            {
                pictureBoxImagem.Image = Imagem;
                ConstaImagem = true;
            }
        }
    }
}
