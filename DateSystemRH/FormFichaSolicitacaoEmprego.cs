using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;

namespace DateSystemRH
{
    public partial class FormFichaSolicitacaoEmprego : Form
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
        private int ID_PPESSOA = 0;
        public int IdPPessoa
        {
            get
            {
                return this.ID_PPESSOA;

            }
            set
            {
                this.ID_PPESSOA = value;
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
        private string DATA_DO_DIA = "";
        public string DatadoDia
        {
            get
            {
                return this.DATA_DO_DIA;

            }
            set
            {
                this.DATA_DO_DIA = value;
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
        private int ID_USUARIO;
        public int IdUsuario
        {
            get
            {
                return this.ID_USUARIO;

            }
            set
            {
                this.ID_USUARIO = value;
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
        private Boolean txtNomePessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProviderFichaSolitacao.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFichaSolitacao.SetError(textBox, "Nome Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        public FormFichaSolicitacaoEmprego()
        { }
        public FormFichaSolicitacaoEmprego( int idUsuario,string RgCpf)
        {
            InitializeComponent();
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
            this.IdUsuario = idUsuario;
            TamanhoCaracteres();
            dateTimePicker();
                    
            Fill_listBoxEstadoCivil();
            Fill_listBoxTodasEstabilidade();
            Fill_listBoxProfissao();
            //Fill_listBoxTodasStatusMercado();
            this.StatusMercado = 1;
            comboBoxStatusMercado.Items.Insert(0, "Liberado");
            comboBoxStatusMercado.SelectedIndex = 0;
            if(RgCpf.Length == 9)
            {
                maskedtxtRgNome.Text = RgCpf;
            }
            if (RgCpf.Length == 11)
            {
                maskedtxtCpf.Text = RgCpf;
            }
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
            this.dateTimePickerDataDia.Value = DateTime.Now.Date;
            this.DatadoDia = DatadoDia.ToString();
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
        private void FormFichaSolicitacaoEmprego_Load(object sender, EventArgs e)
        {

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

        private void maskedtxtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void maskedtxtPeso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtREEmpregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
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

            for(int i = 0; i < conversaoT.Length; i++)
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
        private void buttonSalvaCadastro_Click(object sender, EventArgs e)
        {
            SalvarCadastro();
        }
        public void SalvarCadastro()
        {
            try
            {
                this.contador = 0;

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
                PPessoas.IdPessoaLogada = this.IdUsuario; 
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

                if (txtNomePessoa(txtNome, errorProviderFichaSolitacao) == true)
                {
                    
                    if (contador == 0)
                    {
                        //DADOS PESSOAS
                        Conexao2 conexao2 = new Conexao2(this.connetionString);
                        DALDateSystemRH dal = new DALDateSystemRH(conexao2); //cadastra Pessoa
                        dal.IncluirDadosPessoas(PPessoas);

                        //PASSANDO ID PARA CADASTRO
                        IdPPessoa = PPessoas.Id_DadosPessoas;
                        PEscolaridade.Id_PessoasEscolaridade = IdPPessoa;
                        PInformacoes.Id_PessoasInformacoes = IdPPessoa;
                        PProfissionais.Id_PessoasProfissional = IdPPessoa;
                        PProfissionais2.Id_PessoaProfissional2 = IdPPessoa;
                        PAvaliacao.Id_PessoasAvaliacao = IdPPessoa;
                        PExEmpregado.Id_PessoasExEmpregado = IdPPessoa;
                        PPassagemCriminal.Id_PessoasPassagemCriminal = IdPPessoa;
                        

                        //CEP
                        DALDateSystemRH da2 = new DALDateSystemRH(conexao2);
                        da2.IncluirCepPessoa(PPessoas);

                        //ESCOLARIDADE
                        DALDateSystemRH da3 = new DALDateSystemRH(conexao2);
                        da3.IncluirEscolaridade(PEscolaridade);

                        //INFORMACOES
                        DALDateSystemRH da4 = new DALDateSystemRH(conexao2);
                        da4.IncluirInformacoes(PInformacoes);

                        //CONHECE EMPRESA
                        DALDateSystemRH da5 = new DALDateSystemRH(conexao2);
                        da5.IncluirCConheceuEmpresa(PInformacoes);

                        //PROFISSIONAL 
                        DALDateSystemRH da14 = new DALDateSystemRH(conexao2);
                        da14.IncluirProfissionais(PProfissionais);

                        //PROFISSIONAL 2
                        DALDateSystemRH da6 = new DALDateSystemRH(conexao2);
                        da6.IncluirProfissionais2(PProfissionais2);

                        //RECRUTAMENTO
                        DALDateSystemRH da7 = new DALDateSystemRH(conexao2);
                        da7.IncluirRecrutamentoSelecao(PProfissionais2);

                        //CARTEIRA DE MOTORISTA
                        DALDateSystemRH da8 = new DALDateSystemRH(conexao2);
                        da8.IncluirCarteiraMotorista(PInformacoes);

                        //AVALIAÇÃO TECNICA
                        DALDateSystemRH da9 = new DALDateSystemRH(conexao2);
                        da9.IncluirAvaliacaoTecnica(PAvaliacao);

                        if (radioButtonJTEMSS.Checked == true)
                        {
                            //AVALIAÇÃO EX EMPREGADO
                            DALDateSystemRH da10 = new DALDateSystemRH(conexao2);
                            da10.IncluirExEmpregado(PExEmpregado);
                        }


                        //AVALIAÇÃO REDACAO
                        DALDateSystemRH da11 = new DALDateSystemRH(conexao2);
                        da11.IncluirRedacao(PExEmpregado);

                        if (checkBoxPassagemCriminal.Checked == true)
                        {

                            //AVALIAÇÃO CRIMINAL
                            DALDateSystemRH da12 = new DALDateSystemRH(conexao2);
                            da12.IncluirPassagemCriminal(PPassagemCriminal);
                        }

                        //AVALIAÇÃO ESTABILIDADE
                        DALDateSystemRH da13 = new DALDateSystemRH(conexao2);
                        da13.IncluirEstabilidade(PPessoas);

                        //ADICIONAR IMAGEM FICHA
                        FichaImagem Imagem = new FichaImagem();

                        Imagem.IdFicha = IdPPessoa;

                        if (bmp == null)
                        {
                            
                        }
                        if (bmp != null)
                        {
                            MemoryStream memory = new MemoryStream();

                            bmp.Save(memory, ImageFormat.Bmp);

                            byte[] Foto = memory.ToArray();

                            Imagem.Imagem = Foto;
                            Imagem.IdLoginUsuario = 0;

                            //Acessa Banco de Dados e Salvar Imagem 

                            DALDateSystemRH da1 = new DALDateSystemRH(conexao2);
                            da1.IncluirFichaImagem(Imagem);
                        }

                        DialogResult dialogResult = MessageBox.Show("Deseja Cadastra nova Ficha " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FecharTodosFormulario();

                            FormFichaSolicitacaoEmprego FormFichaSolicitacaoEmpregoE = new FormFichaSolicitacaoEmprego(this.IdUsuario, "");
                            FormFichaSolicitacaoEmpregoE.MdiParent = FormFichaSolicitacaoEmprego.ActiveForm;
                            FormFichaSolicitacaoEmpregoE.Show();
                            FormFichaSolicitacaoEmpregoE.Top = 0;
                            FormFichaSolicitacaoEmpregoE.Left = 0;

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            FecharTodosFormulario();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.ToString()); }
            
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            ADDInformacoes();

            int contador = 0;
            while (contador < 20)
            {
                AdicionarNome();
                GerarCpf();
                GerarRg();
                GerarProfissao();
                SalvarCadastro();
                this.StatusMercado = 1;
                contador++;
            }
            MessageBox.Show("Finalizado");
        }
        public void FecharTodosFormulario()
        {
            FechaFormularios(typeof(FormFichaSolicitacaoEmprego));
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
        public void ADDInformacoes()
        {
            try
            {
                txtCargo.Text = "Verificar";
                txtNome.Text = "Fernando de Souza de Luz";
                txtIdade.Text = "25";
                //cep
                txtEstado.Text = "SÃO PAULO";
                txtPontoReferencia.Text = "SESC Interlagos";
                txtResideQTLocal.Text = "1 ano e 6 meses";
                txtTelefonePessoa.Text = "1156689175";
                maskedtxtCelularPessoa.Text = "11986687748";
                maskedtxtTelefoneRecardo.Text = "1156689974";
                maskedtxtCelularRecardo.Text = "11988874525";
                txtNomeRecardo.Text = "Fernandinho";
                maskedtxtRgNome.Text = "322758089";
                txtDataOrgaoNome.Text = "05/2013 - SSP ";
                maskedtxtCpf.Text = "32319739885";
                txtCarteiraTrabalho.Text = "741852963";
                txtSerieNome.Text = "258963741";
                txtPisNome.Text = "789456123";
                txtTituloEleitor.Text = "321654987";
                txtNReservista.Text = "753951456";
                txtnaturalDe.Text = "PIRACICABA";
                txtEstadoNatural.Text = "SÃO PAULO";
                txtNacionalidade.Text = "Brasileiro";
                maskedtxtAltura.Text = "185";
                maskedtxtPeso.Text = "7500";
                txtEmailNome.Text = "informatica@cade.com";
                txtNomeJunto.Text = "Debora lima";
                txtNdependentes.Text = "1";
                txtNFilhos.Text = "2";
                txtIdadeFilhos.Text = "20/23/25";
                txtNomePai.Text = "Luiz fernando";
                txtNomeMae.Text = "Ana Fernanda";
                //CeP Pessoa
                maskedTextBoxCep.Text = "04776100";
                txtEndereco.Text = "Engenheiro José Salles";
                txtNumero.Text = "150";
                txtBairro.Text = "Socorro";
                txtComplemento.Text = "Vila Santos";
                txtLogradouroNome.Text = "Avenida";
                txtCidade.Text = "São Paulo";
                txtSigla.Text = "SP";
                txtEstado.Text = "São Paulo";
                //ESCOLARIDADE
                txtSuperiorCurso.Text = "Ciência de Vida";
                txtEstudaAtualmente.Text = "Sistemas RH";
                txtAnoEstaCursando.Text = "6 Semestre";
                txtBairroCursando.Text = "Perdizes";
                maskedTxtHorarioCursando.Text = "1930";
                //profissional
                txtNomeAcademiaVigilante.Text = "Carro Sisi";
                txtNomeAcademiaReciclagem.Text = "sextou";
                txtCursoPortaria.Text = "Master";
                txtEscolaPortaria.Text = "Vidao";
                txtQuaisCursos.Text = "vida, anos e foda-se";
                //informacoes
                txtNumeroCarteiraMotorista.Text = "123456789";
                txtDrogasIlicitas.Text = "Não";
                txtTratamentoMedico.Text = "Não";
                txtNomeConhecidoEmpresa.Text = "aaaa";
                txtCargoConhecidoEmpresa.Text = "sssss";
                txtTrabalhoConhecidoEmpresa.Text = "sdddd";
                //profissional 2
                txtUltimoEmprego.Text = "aaaaaaaaa";
                txtUltimoCargo.Text = "vvv";
                txtUltimoSalario.Text = "134888";
                txtNomeUltimoChefe.Text = "dddd";
                maskedtxtTelefoneUltimoEmprego.Text = "11986687748";
                txtMotivoSaidaUltimoEmprego.Text = "xxxxxx";
                txtPenultimoEmprego.Text = "qqq";
                txtPenultimoCargo.Text = "www";
                txtPenultimoSalario.Text = "254015";
                txtNomePenultimoChefe.Text = "rrr";
                maskedtxtTelefonePenultimoEmprego.Text = "11986437749";
                txtMotivoSaidaPenultimoEmprego.Text = "ttt";
                txtAntepenultimoEmprego.Text = "ff";
                txtAntepenultimoCargo.Text = "ggg";
                txtAntepenultimoSalario.Text = "378496";
                txtNomeAntepenultimoChefe.Text = "jj";
                maskedtxtTelefoneAntepenultimoEmprego.Text = "11986437549";
                txtMotivoSaidaAntepenultimoEmprego.Text = "kkk";
                txtRecutamentoSelecao.Text = " sdssssssssssss ddddddddd ddddddddddddddd sss";
                //AVALIACAO
                txtEntrevistadoAprovado.Text = "AAAAAAAAA";
                txtComentariosAprovado.Text = "XXXXXXXXXXXXXXXX";
                txtEntrevistadoAproveitamento.Text = "QQQQQ";
                txtComentariosEntrevistado.Text = "WWWWWWW";
                txtMSAvaliacao.Text = "14";
                //EX EMPREGADO
                txtNomeEmpregado.Text = "AAAAAAAAA";
                txtQualPosto.Text = "XXXXXXXXXXXXXXXX";
                txtQuemSupervisor.Text = "QQQQQ";
                txtMotivoSaida.Text = "WWWWWWW";
                txtREEmpregado.Text = "25";
                txtTreinamentoInforme.Text = "AAAAA";
                //REDACAO
                txtRedacao.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAA SDS SWW WFDDSAFASDSADS ADAS ASDADSSD AADSA ASDADSFDSADAS";
                //ESTABILIDADE
                txtComentarioEstabilidade.Text = "ESSSSSSSSSSSSSSSSSSSSS";
                //CRIMINAL
                txtComentarios.Text = "ESSSSSSSSSSSSSSSSSSSSS";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.ToString());
            }
        }

        public void AdicionarNome()
        {
            Random rnd =  new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido", "Vanya", "Samuel", "Koani", "Volodya", "Prince", "Yiska",
                                        "Decio", "Cassia", "Roberto", "Fernando", "Julia", "Giovana", "Leticia", "Roberta", "João", "André" };
            string[] femalePetNames = {"Maggie", "Penny", "Saya", "Princess","Abby", "Laila", "Sadie", "Olivia","Starlight", "Talla",
                                         "Alves", "Borba", "Leão", "Rico","Pinto", "Pepe", "Sálvio", "Othan","Byte", "Brandão" };

            // Generate random indexes for pet names.
            int mIndex = rnd.Next(0,malePetNames.Length);
            int fIndex = rnd.Next(0, femalePetNames.Length);

            txtNome.Text = malePetNames[mIndex] + " " + femalePetNames[fIndex];
            //// Display the result.
            //Console.WriteLine("Suggested pet name of the day: ");
            //Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
            //Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);
        }


        public void  GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;

            maskedtxtCpf.Text = semente;
            //return semente;
            
        }
        public void GerarRg()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 9;
            if (resto < 2)
                resto = 0;
            else
                resto = 9 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 8; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 9;

            if (resto < 2)
                resto = 0;
            else
                resto = 9 - resto;

            semente = semente + resto;

            maskedtxtRgNome.Text = semente;
            //return semente;

        }
        public void GerarProfissao()
        {
            Random rnd = new Random();
            int semente = rnd.Next(1, 3);
            this.IdProfissao = semente;
        }

        private void checkBoxPassagemCriminal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassagemCriminal.Checked == true)
            {
                txtComentarios.Clear();
                txtComentarios.Enabled = true;
            }
            if (checkBoxPassagemCriminal.Checked == false)
            {
                txtComentarios.Clear();
                txtComentarios.Enabled = false;
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

        private void txtMSAvaliacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormFichaSolicitacaoEmprego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void radioButtonJTEMSN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJTEMSN.Checked == true)
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

        private void label143_Click(object sender, EventArgs e)
        {

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

        private void txtTituloEleitor_KeyPress(object sender, KeyPressEventArgs e)
        {

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

                    label146.Text = openFileDialog.FileName;

                    pictureBoxImagem.Image = Image.FromFile(openFileDialog.FileName);

                    bmp = new Bitmap(label146.Text);
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

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            FechaFomulario();
        }
        public void FechaFomulario()
        {
            FecharTodosFormulario();
        }

    }
}
