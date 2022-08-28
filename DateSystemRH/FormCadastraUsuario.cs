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

namespace DateSystemRH
{
    public partial class FormCadastraUsuario : Form
    {
        private string UNomeUsuario = "";

        private string FucionarioRh = "";

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

        private int ACESSOCADASTROUSUARIO = 0;
        public int AcessoCadastroUsuario
        {
            get
            {
                return this.ACESSOCADASTROUSUARIO;

            }
            set
            {
                this.ACESSOCADASTROUSUARIO = value;
            }
        }
        private int CRIARCADASTROUSUARIO = 0;
        public int CriarCadastroUsuario
        {
            get
            {
                return this.CRIARCADASTROUSUARIO;

            }
            set
            {
                this.CRIARCADASTROUSUARIO = value;
            }
        }
        private int CRIARFUNCIONARIORH = 0;
        public int CriarFuncionarioRh
        {
            get
            {
                return this.CRIARFUNCIONARIORH;

            }
            set
            {
                this.CRIARFUNCIONARIORH = value;
            }
        }
        private int CRIARUSUARIOACESSO = 0;
        public int CriarUsuarioAcesso
        {
            get
            {
                return this.CRIARUSUARIOACESSO;

            }
            set
            {
                this.CRIARUSUARIOACESSO = value;
            }
        }
        private int CRIARUSUAROBASEDADOS = 0;
        public int CriarUsuarioBaseDados
        {
            get
            {
                return this.CRIARUSUAROBASEDADOS;

            }
            set
            {
                this.CRIARUSUAROBASEDADOS = value;
            }
        }
        private int CRIARNIVELACESSSO = 0;
        public int CriarNivelAcesso
        {
            get
            {
                return this.CRIARNIVELACESSSO;

            }
            set
            {
                this.CRIARNIVELACESSSO = value;
            }
        }
        private int CRIARPERMISSAOFUNCIONARIORH = 0;
        public int CriarPermissaoFuncionarioRH
        {
            get
            {
                return this.CRIARPERMISSAOFUNCIONARIORH;

            }
            set
            {
                this.CRIARPERMISSAOFUNCIONARIORH = value;
            }
        }
        private int CRIARPERMISSAOUSUARIOACESSO = 0;
        public int CriarPermissaoUsuarioAcesso
        {
            get
            {
                return this.CRIARPERMISSAOUSUARIOACESSO;

            }
            set
            {
                this.CRIARPERMISSAOUSUARIOACESSO = value;
            }
        }
        private int USUARIOACESSOADM = 0;
        public int UsuarioAcessoAdm
        {
            get
            {
                return this.USUARIOACESSOADM;

            }
            set
            {
                this.USUARIOACESSOADM = value;
            }
        }

        private string NOMEUSUARIO = "";
        public string NomeUsuario
        {
            get
            {
                return this.NOMEUSUARIO;

            }
            set
            {
                this.NOMEUSUARIO = value;
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

        private int IDACESSOBASEDADOS = 0;
        public int IdAcessoBaseDados
        {
            get
            {
                return this.IDACESSOBASEDADOS;

            }
            set
            {
                this.IDACESSOBASEDADOS = value;
            }
        }
        

        private int CONEXAOACEITA = 0;
        public int ConexaoAceita
        {
            get
            {
                return this.CONEXAOACEITA;

            }
            set
            {
                this.CONEXAOACEITA = value;
            }
        }
        private int NOVOREGISTRO = 0;
        public int NovoRegisto
        {
            get
            {
                return this.NOVOREGISTRO;

            }
            set
            {
                this.NOVOREGISTRO = value;
            }
        }
        private int CRIARPERMISSAOBASEDADOS = 0;
        public int CriarPermissaoBaseDados
        {
            get
            {
                return this.CRIARPERMISSAOBASEDADOS;

            }
            set
            {
                this.CRIARPERMISSAOBASEDADOS = value;
            }
        }
        private int CRIARPERMISSAOCADASTROUSUARIO = 0;
        public int CriarPermissaoCadastroUsuario
        {
            get
            {
                return this.CRIARPERMISSAOCADASTROUSUARIO;

            }
            set
            {
                this.CRIARPERMISSAOCADASTROUSUARIO = value;
            }
        }
        private Boolean NomeCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomePessoa.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Nome Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        private Boolean SobreNomeCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtSobrenomePessoa.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Sobrenome Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        private Boolean AbreviaçãoCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacao.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Abreviação Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        private Boolean ReCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtReFuncionarioRh.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "RE Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        private Boolean AbreviaçãoFunciCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtFuncionarioAbreviacaoRh.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Abreviação Não pode se em branco!");
                this.contador++;
                return false;
            }
        }

        private Boolean UsuarioAcessoCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtUsuarioLoginFuncionario.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Usuário Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        private Boolean SenhaAcessoCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtSenhaFuncionario.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Senha Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        private Boolean ConfirmaSenhaAcessoCriarPessoa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtConfirmacaoSenhaFuncionario.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Confirma Senha Não pode se em branco!");
                this.contador++;
                return false;
            }
        }
        public FormCadastraUsuario()
        {
            InitializeComponent();
        }
        public FormCadastraUsuario(int CriarNivelAcesso, int CriarCadastroUsuario, int CriarFuncionarioRh, int CriarUsuarioAcesso, int CriarUsuarioBaseDados, int Adm,
            int AcessoCadastroUsuario)
        {
            InitializeComponent();

            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

            //Nivel criar usuario
            if (CriarNivelAcesso == 1)
            {
                buttonAceitaNivelAcesso.Enabled = true;
                this.CriarNivelAcesso = CriarNivelAcesso;
            }
            //Cadastra pessoa
            if (CriarCadastroUsuario == 1)
            {
                buttonCadastraPessoa.Enabled = true;
                this.CriarCadastroUsuario = CriarCadastroUsuario;
            }
            //Criar funcionar rh
            if (CriarFuncionarioRh == 1)
            {
                buttonCadastraFuncionarioRh.Enabled = true;
                this.CriarFuncionarioRh = CriarFuncionarioRh;
            }
            //Criar usuario de acesso
            if (CriarUsuarioAcesso == 1)
            {
                buttonCadastraUsuarioAcesso.Enabled = true;
                this.CriarUsuarioAcesso = CriarUsuarioAcesso;
            }
            //Criar usuario base dados
            if (CriarUsuarioBaseDados == 1)
            {
                buttonCadastraBaseDados.Enabled = true;
                this.CriarUsuarioBaseDados = CriarUsuarioBaseDados;
            }
            //Criar acesso a cadastro do usuario
            if (AcessoCadastroUsuario == 1)
            {
                checkBoxaAcessoCadastroUsuario.Enabled = true;
                this.AcessoCadastroUsuario = AcessoCadastroUsuario;
            }
            //Permissao de Administrador
            if (Adm == 1)
            {
                checkBoxADM.Enabled = true;
                this.UsuarioAcessoAdm = Adm;
            }
        }
        public void AlterarBotoes(int Numero)
        {
            if (Numero == 1)//Base de dados Usuário novo
            {
                txtUsuario.Clear();
                txtSenha.Clear();

                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
            }
            if (Numero == 2)//Dados Pessoas
            {
                txtNomePessoa.Clear();
                txtSobrenomePessoa.Clear();
                txtAbreviacao.Clear();
                txtCepPessoa.Clear();
                txtLogradouroPessoa.Clear();
                txtEnderecoPessoa.Clear();
                txtNumeroPessoa.Clear();
                txtComplPessoa.Clear();
                txtBairroPessoa.Clear();
                txtCidadePessoa.Clear();
                txtSiglaCidadePessoa.Clear();
                txtTelefonePessoa.Clear();
                txtTelefone2Pessoa.Clear();
                txtCelularCelular.Clear();
                txtCelular2Pessoa.Clear();
                txtEmailEmail.Clear();
                txtCpfPessoa.Clear();
                txtRgPessoa.Clear();
                txtDataNascimentoPessoa.Value = DateTime.Now.Date;
            }
            if (Numero == 3)//FUNCIONARIO RH
            {
                txtReFuncionarioRh.Clear();
                txtFuncionarioAbreviacaoRh.Clear();
                txtFuncionarioEmaillRh.Clear();
                maskedTelefoneFuncionarioRh.Clear();
                maskedTelefone2FuncionarioRh.Clear();
                maskedCelularFuncionarioRh.Clear();
                maskedCelular2FuncionarioRh.Clear();

            }
            if (Numero == 5)//USUARIO DE ACESSO
            {
                txtUsuarioLoginFuncionario.Clear();
                txtSenhaFuncionario.Clear();
                txtConfirmacaoSenhaFuncionario.Clear();
                txtObservacaoFuncionario.Clear();

            }
            if (Numero == 6)//Funcionario RH
            {
                txtReFuncionarioRh.Clear();
                txtFuncionarioAbreviacaoRh.Clear();
                txtFuncionarioEmaillRh.Clear();
                maskedTelefoneFuncionarioRh.Clear();
                maskedTelefone2FuncionarioRh.Clear();
                maskedCelularFuncionarioRh.Clear();
                maskedCelular2FuncionarioRh.Clear();
            }
        }

        private void buttonCadastraBaseDados_Click(object sender, EventArgs e)
        {
            BotaoCadastraBaseDados();
        }
        private void BotaoCadastraBaseDados()
        {
            panelBasedados.Enabled = false;
            buttonCadastraBaseDados.Enabled = false;
            buttonCancelarBaseDados.Enabled = false;
            buttonTestaConexao.Enabled = false;
        }
        private void buttonCancelarBaseDados_Click(object sender, EventArgs e)
        {
            BotaoCancelarBaseDados();
        }
        public void BotaoCancelarBaseDados()
        {
            panelBasedados.Enabled = false;          
            buttonCadastraBaseDados.Enabled = false;
            buttonCancelarBaseDados.Enabled = false;
            buttonTestaConexao.Enabled = false;         
        }
        private void buttonBaseDadosSalvar_Click(object sender, EventArgs e)
        {
            SalvarBaseDados();
        }
        public void SalvarBaseDados()
        {
            //Cadastro usuário Base Dados Novo Acesso
            Conexao2 conexao7 = new Conexao2(this.connetionString);
            DALDateSystemRH da7 = new DALDateSystemRH(conexao7);

            AcessoBaseDados NovoAcesso = new AcessoBaseDados();

            //NovoAcesso.Servidor = this.NomeServidor;
            //NovoAcesso.BaseDados = this.NomeBaseDados;
            //NovoAcesso.Nome = this.UsuarioTempBancoDados;
            //NovoAcesso.Senha = this.SenhaTempBancoDados;

            //da7.IncluiAcessoBancoDados(NovoAcesso);

            buttonBaseDados.Enabled = false;
            buttonTestaConexao.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            buttonBaseDadosSalvar.Enabled = false;
            buttonCadastraBaseDados.Enabled = true;
            buttonCancelarBaseDados.Enabled = false;
            panelBasedados.Enabled = false;

            comboBoxUsuarioBaseDados.Enabled = true;
            comboBoxUsuarioBaseDados.Refresh();
        }

        private void buttonBaseDados_Click(object sender, EventArgs e)
        {
            NovoRegistro();
        }
        public void NovoRegistro()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            buttonTestaConexao.Enabled = true;
            buttonBaseDados.Enabled = false;
            //comboBoxUsuarioBaseDados.Items.Clear();
            this.NOVOREGISTRO = 1;
        }

        private void buttonTestaConexao_Click(object sender, EventArgs e)
        {
            TesteConexao();
        }
        public void TesteConexao()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            //Verifica Se a USUARIO CONSTA NO SISTEMA!    

            SqlDataAdapter da3 = new SqlDataAdapter("EXEC D_ConsultaNomeAcessoBaseDadosTXT '" + txtUsuario.Text + "';", conn);

            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            conn.Open();

            if (ds3.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("O Usuário já consta no sistema não pode ser Inserido!");

                conn.Close();
            }
            if (ds3.Tables[0].Rows.Count == 0)
            {
                //SqlConnection conn2 = new SqlConnection("Data Source=" + this.NomeServidor + ";Initial Catalog=MSOS;Persist Security Info=True;User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";");
                try
                {
                    //conn2.Open();

                    //this.UsuarioTempBancoDados = txtUsuario.Text;

                    //this.SenhaTempBancoDados = txtSenha.Text;

                    //buttonBaseDadosSalvar.Enabled = true;

                    MessageBox.Show("Usuário e senha estão corretos! ");

                }
                catch (SqlException)
                {
                    buttonBaseDadosSalvar.Enabled = false;
                    MessageBox.Show("Usuário ou senha estão incorretos. Digite informações corretas! ");

                    //conn2.Close();

                }
                finally
                {
                    //conn2.Close();
                }
            }
        }

        private void FormCadastraUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastraPessoa_Click(object sender, EventArgs e)
        {
            CadastraUsuario();
        }
        public void CadastraUsuario()
        {
            txtDataNascimentoPessoa.Value = DateTime.Now.Date;
            PainelPrincipal.Enabled = true;
            panelDadosPessoal.Enabled = true;
            buttonVerifica.Enabled = true;
            buttonCadastraBaseDados.Enabled = false;
            buttonCancelarBaseDados.Enabled = true;
            buttonCadastraPessoa.Enabled = false;
        }
        

        private void buttonCadastraPermissaoUsuarioRh_Click(object sender, EventArgs e)
        {
            if(this.UNomeUsuario == "Usuario Acesso")
            {
                PermissaoCadastroFuncionarioRh();
                AtivacaoPermissaoFicha();
                comboBoxUsuarioBaseDados.SelectedIndex = 0;
            }
            else { MessageBox.Show("Cadastra Usuário Acesso tem que está ativado!"); }


        }
        public void PermissaoCadastroFuncionarioRh()
        {        
            panelPermissaoFuncionario.Enabled = true;
            panelPermissaoFuncionario2.Enabled = true;
            panelPermissaoFuncionario3.Enabled = true;
            buttonCadastraPermissaoUsuarioRh.Enabled = false;
            buttonCancelarPermissaoUsuarioRh.Enabled = true;
        }
        public void CadastraPermisssaoRh()
        {
            panelPermissaoFuncionario.Enabled = true;
            panelPermissaoFuncionario2.Enabled = true;
            panelPermissaoFuncionario3.Enabled = true;
            panelPermissaoSistema.Enabled = true;
        }
        public void AtivacaoPermissaoFicha()
        {
            checkBoxCADASTRAEMPRESA.Checked = true;
            checkBoxPESQUISAEMPRESA.Checked = true;
            checkBoxVISUALIZAREMPRESA.Checked = true;
            checkBoxEDITAREMPRESA.Checked = true;
            checkBoxEXCLUIREMPRESA.Checked = true;
            checkBoxCADASTRAFICHA.Checked = true;
            checkBoxPESQUISAFICHA.Checked = true;
            checkBoxVISUALIZAFICHA.Checked = true;
            checkBoxEDITARFICHA.Checked = true;
            checkBoxEXCLUIRFICHA.Checked = true;
            checkBoxCADASTRAPROCESSOSELECAO.Checked = true;
            checkBoxPESQUISAPROCESSOSELECAO.Checked = true;
            checkBoxVISUALIZARPROCESSOSELECAO.Checked = true;
            checkBoxEDITARPROCESSOSELECAO.Checked = true;
            checkBoxEXCLUIRPROCESSOSELECAO.Checked = true;
    }
        public void DesativadasPermissaoFicha()
        {
            checkBoxCADASTRAEMPRESA.Checked = false;
            checkBoxPESQUISAEMPRESA.Checked = false;
            checkBoxVISUALIZAREMPRESA.Checked = false;
            checkBoxEDITAREMPRESA.Checked = false;
            checkBoxEXCLUIREMPRESA.Checked = false;
            checkBoxCADASTRAFICHA.Checked = false;
            checkBoxPESQUISAFICHA.Checked = false;
            checkBoxVISUALIZAFICHA.Checked = false;
            checkBoxEDITARFICHA.Checked = false;
            checkBoxEXCLUIRFICHA.Checked = false;
            checkBoxCADASTRAPROCESSOSELECAO.Checked = false;
            checkBoxPESQUISAPROCESSOSELECAO.Checked = false;
            checkBoxVISUALIZARPROCESSOSELECAO.Checked = false;
            checkBoxEDITARPROCESSOSELECAO.Checked = false;
            checkBoxEXCLUIRPROCESSOSELECAO.Checked = false;

        }
        private void buttonCancelarPermissaoUsuarioRh_Click(object sender, EventArgs e)
        {
            CancelarPermissaoRh();
            DesativadasPermissaoFicha();
        }
        public void CancelarPermissaoRh()
        {
            panelPermissaoFuncionario.Enabled = false;
            panelPermissaoFuncionario2.Enabled = false;
            panelPermissaoFuncionario3.Enabled = false;
            buttonCadastraPermissaoUsuarioRh.Enabled = true;
            buttonCancelarPermissaoUsuarioRh.Enabled = false;
        }
        private void BotaoCancelarAcao(int Entrada)
        {
            if (Entrada == 1)//USUARIO DE ACESSO
            {
                panelNivelAcesso.Enabled = false;
                buttonCadastraPermissaoUsuarioRh.Enabled = true;

            }
        }

        private void buttonCadastraUsuarioAcesso_Click(object sender, EventArgs e)
        {
            BotaoCadastraUsuarioAcesso();
        }
        private void BotaoCadastraUsuarioAcesso()
        {
            this.UNomeUsuario = "Usuario Acesso";

            panelCriarUsuarioAcesso.Enabled = true;
            buttonCadastraUsuarioAcesso.Enabled = false;
            buttonCancelarUsuarioAcesso.Enabled = true;
        }
        private void buttonCancelarUsuarioAcesso_Click(object sender, EventArgs e)
        {
            BotaoCancelarUsuarioAcesso();
        }
        private void BotaoCancelarUsuarioAcesso()
        {
            this.UNomeUsuario = "";

            panelCriarUsuarioAcesso.Enabled = false;
            buttonCadastraUsuarioAcesso.Enabled = true;
            buttonCancelarUsuarioAcesso.Enabled = false;
            AlterarBotoes(5);
            CancelarPermissaoRh();
            DesativadasPermissaoFicha();
            CancelarPermissaoUsuarioAcesso();
            DesativaPermissaoFuncionarioUsuarioAcesso();

            //cont--;
        }
        void Fill_listBoxAcessoBaseDados()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_ConsultaAcessoBaseDados;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(3);
                    comboBoxUsuarioBaseDados.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            CadastraUsuarioNovo();
        }
        public void CadastraUsuarioNovo()
        {
            try
            {
                this.contador = 0;

                CadastraUsuario CadastraUsuarioGeral = new CadastraUsuario(); //Dados Pessoas - Cadastra

                CadastraUsuarioGeral.Nome = txtNomePessoa.Text;
                CadastraUsuarioGeral.SobreNome = txtSobrenomePessoa.Text;
                CadastraUsuarioGeral.Abreviacao = txtAbreviacao.Text;
                CadastraUsuarioGeral.Telefone = txtTelefonePessoa.Text;
                CadastraUsuarioGeral.Telefone2 = txtTelefone2Pessoa.Text;
                CadastraUsuarioGeral.Celular = txtCelularCelular.Text;
                CadastraUsuarioGeral.Celular2 = txtCelular2Pessoa.Text;
                CadastraUsuarioGeral.Email = txtEmailEmail.Text;
                CadastraUsuarioGeral.Sexo = comboBoxSexoPessoa.Text;
                CadastraUsuarioGeral.Cpf = txtCpfPessoa.Text;
                CadastraUsuarioGeral.Rg = txtRgPessoa.Text;
                CadastraUsuarioGeral.Data_Nascimento = txtDataNascimentoPessoa.Text;
                CadastraUsuarioGeral.Observacao = txtObservacaoPessoa.Text;
                CadastraUsuarioGeral.IdSituacao = 1;

                CepCadastraUsuario CepCadastraUsuarioGeral = new CepCadastraUsuario(); //Cep Dados Pessoas - Cadastra

                if (txtCepPessoa.Text == "")
                {

                }
                if (!(txtCepPessoa.Text == ""))
                {
                    CepCadastraUsuarioGeral.Cepc = int.Parse(txtCepPessoa.Text);
                    CepCadastraUsuarioGeral.TipoLogradouro = txtLogradouroPessoa.Text;
                    CepCadastraUsuarioGeral.Endereco = txtEnderecoPessoa.Text;
                    CepCadastraUsuarioGeral.Numero = txtNumeroPessoa.Text;
                    CepCadastraUsuarioGeral.Complemento = txtComplPessoa.Text;
                    CepCadastraUsuarioGeral.Bairro = txtBairroPessoa.Text;
                    CepCadastraUsuarioGeral.Cidade = txtCidadePessoa.Text;
                    CepCadastraUsuarioGeral.SiglaCidade = txtSiglaCidadePessoa.Text;
                }
                FuncionarioRh FuncionarioRhS = new FuncionarioRh();//Funcionario Dados Pessoas - Cadastra FuncionarioOS

                if (txtReFuncionarioRh.Text == "")
                {

                }
                if (!(txtReFuncionarioRh.Text == ""))
                {
                    FuncionarioRhS.IdRe = txtReFuncionarioRh.Text;
                    FuncionarioRhS.Abreviacao = txtAbreviacao.Text;
                    FuncionarioRhS.Email = txtFuncionarioEmaillRh.Text;
                    FuncionarioRhS.Telefone = maskedTelefoneFuncionarioRh.Text;
                    FuncionarioRhS.Telefone2 = maskedTelefone2FuncionarioRh.Text;
                    FuncionarioRhS.Celular = maskedCelularFuncionarioRh.Text;
                    FuncionarioRhS.Celular2 = maskedCelular2FuncionarioRh.Text;
                }
                CadastroLoginNovo cadastrologin1 = new CadastroLoginNovo(); //Base de Dados Dados Pessoas - Cadastra

                cadastrologin1.Nome = txtNomePessoa.Text;
                cadastrologin1.Usuario = txtUsuarioLoginFuncionario.Text;
                cadastrologin1.Senha = txtSenhaFuncionario.Text;
                cadastrologin1.ConfirmaSenha = txtConfirmacaoSenhaFuncionario.Text;
                cadastrologin1.Observacao = txtObservacaoFuncionario.Text;
                cadastrologin1.Situacao = 1;
                cadastrologin1.IdAcessoBaseDados = this.IdAcessoBaseDados;

                if (checkBoxADM.Checked == false)
                {
                    cadastrologin1.UsuarioAcesso = 0;
                }
                if (checkBoxADM.Checked == true)
                {
                    cadastrologin1.UsuarioAcesso = 1;
                }

                //NIVEL DE ACESSO E PERMISSÃO DE NIVEL DE ACESSO - CRIAR-----------------------------------------------------------------------

                if (checkBoxaAcessoCadastroUsuario.Checked == true) { cadastrologin1.AcessoCadastroUsuario = 1; }
                if (checkBoxaAcessoCadastroUsuario.Checked == false) { cadastrologin1.AcessoCadastroUsuario = 0; }

                if (checkBoxCriarCadastroUsuario.Checked == true) { cadastrologin1.CriarCadastroUsuario = 1; }
                if (checkBoxCriarCadastroUsuario.Checked == false) { cadastrologin1.CriarCadastroUsuario = 0; }

                if (CheckBoxCriarFuncionarioRh.Checked == true) { cadastrologin1.CriarFuncionarioRh = 1; }
                if (CheckBoxCriarFuncionarioRh.Checked == false) { cadastrologin1.CriarFuncionarioRh = 0; }

                if (checkBoxCriarUsuarioAcesso.Checked == true) { cadastrologin1.CriarUsuarioAcesso = 1; }
                if (checkBoxCriarUsuarioAcesso.Checked == false) { cadastrologin1.CriarUsuarioAcesso = 0; }

                if (checkBoxBaseDados.Checked == true) { cadastrologin1.CriarUsuarioBaseDados = 1; cadastrologin1.PermissaoBasedados = 1; }
                if (checkBoxBaseDados.Checked == false) { cadastrologin1.CriarUsuarioBaseDados = 0; cadastrologin1.PermissaoBasedados = 0; }

                if (checkBoxNivelAcesso.Checked == true) { cadastrologin1.CriarNivelAcesso = 1; cadastrologin1.PermissaoNivelaAcesso = 1; }
                if (checkBoxNivelAcesso.Checked == false) { cadastrologin1.CriarNivelAcesso = 0; cadastrologin1.PermissaoNivelaAcesso = 0; }

                if (checkBoxFuncinarioRh.Checked == true) { cadastrologin1.PermissaoFuncionarioRh = 1; }
                if (checkBoxFuncinarioRh.Checked == false) { cadastrologin1.PermissaoFuncionarioRh = 0; }

                if (checkBoxUsuarioAcesso.Checked == true) { cadastrologin1.PermissaoUsuarioAcesso = 1; }
                if (checkBoxUsuarioAcesso.Checked == false) { cadastrologin1.PermissaoUsuarioAcesso = 0; }

                //PERMISSÃO DE USUARIO

                //PERMISSÃO DO SISTEMA USUARIO-----------------------------------------------------------

                if (checkBoxCRIARSistema.Checked == true) { cadastrologin1.UsuarioCriar = 1; }
                if (checkBoxCRIARSistema.Checked == false) { cadastrologin1.UsuarioCriar = 0; }

                if (checkBoxALTERARSistema.Checked == true) { cadastrologin1.UsuarioAlterar = 1; }
                if (checkBoxALTERARSistema.Checked == false) { cadastrologin1.UsuarioAlterar = 0; }

                if (checkBoxEXCLUIRSistema.Checked == true) { cadastrologin1.UsuarioExcluir = 1; }
                if (checkBoxEXCLUIRSistema.Checked == false) { cadastrologin1.UsuarioExcluir = 0; }

                if (checkBoxPESQUISASistema.Checked == true) { cadastrologin1.UsuarioPesquisa = 1; }
                if (checkBoxPESQUISASistema.Checked == false) { cadastrologin1.UsuarioPesquisa = 0; }

                if (checkBoxVISUALIZARSistema.Checked == true) { cadastrologin1.UsuarioVisualizar = 1; }
                if (checkBoxVISUALIZARSistema.Checked == false) { cadastrologin1.UsuarioVisualizar = 0; }


                //PERMISSÃO DO EMPPRESA----------------------------------------------------------------ed == true) { cadastrologin1.FuncionarioCadastra = 1; }//@@

                if (checkBoxCADASTRAEMPRESA.Checked == true) { cadastrologin1.CadastraEmpresa = 1; }
                if (checkBoxCADASTRAEMPRESA.Checked == false) { cadastrologin1.CadastraEmpresa = 0; }

                if (checkBoxPESQUISAEMPRESA.Checked == true) { cadastrologin1.PesquisaEmpresa = 1; }
                if (checkBoxPESQUISAEMPRESA.Checked == false) { cadastrologin1.PesquisaEmpresa = 0; }

                if (checkBoxVISUALIZAREMPRESA.Checked == true) { cadastrologin1.VisualizarEmpresa = 1; }
                if (checkBoxVISUALIZAREMPRESA.Checked == false) { cadastrologin1.VisualizarEmpresa = 0; }

                if (checkBoxEDITAREMPRESA.Checked == true) { cadastrologin1.EditarEmpresa = 1; }
                if (checkBoxEDITAREMPRESA.Checked == false) { cadastrologin1.EditarEmpresa = 0; }

                if (checkBoxEXCLUIREMPRESA.Checked == true) { cadastrologin1.ExcluirEmpresa = 1; }
                if (checkBoxEXCLUIREMPRESA.Checked == false) { cadastrologin1.ExcluirEmpresa = 0; }


                //PERMISSÃO FICHA
                if (checkBoxCADASTRAFICHA.Checked == true) { cadastrologin1.CadastraFicha = 1; }
                if (checkBoxCADASTRAFICHA.Checked == false) { cadastrologin1.CadastraFicha = 0; }

                if (checkBoxPESQUISAFICHA.Checked == true) { cadastrologin1.PesquisaFicha = 1; }
                if (checkBoxPESQUISAFICHA.Checked == false) { cadastrologin1.PesquisaFicha = 0; }

                if (checkBoxVISUALIZAFICHA.Checked == true) { cadastrologin1.VisualizarFicha = 1; }
                if (checkBoxVISUALIZAFICHA.Checked == false) { cadastrologin1.VisualizarFicha = 0; }

                if (checkBoxEDITARFICHA.Checked == true) { cadastrologin1.EditarFicha = 1; }
                if (checkBoxEDITARFICHA.Checked == false) { cadastrologin1.EditarFicha = 0; }

                if (checkBoxEXCLUIRFICHA.Checked == true) { cadastrologin1.ExcluirFicha = 1; }
                if (checkBoxEXCLUIRFICHA.Checked == false) { cadastrologin1.ExcluirFicha = 0; }

                //PERMISSÃO DO PROCESSO SELEÇÃO ----------------------------------------------------------

                if (checkBoxCADASTRAPROCESSOSELECAO.Checked == true) { cadastrologin1.CadastraProcessoSelecao = 1; }
                if (checkBoxCADASTRAPROCESSOSELECAO.Checked == false) { cadastrologin1.CadastraProcessoSelecao = 0; }

                if (checkBoxPESQUISAPROCESSOSELECAO.Checked == true) { cadastrologin1.PesquisaProcessoSelecao = 1; }
                if (checkBoxPESQUISAPROCESSOSELECAO.Checked == false) { cadastrologin1.PesquisaProcessoSelecao = 0; }

                if (checkBoxVISUALIZARPROCESSOSELECAO.Checked == true) { cadastrologin1.VisualizarProcessoSelecao = 1; }
                if (checkBoxVISUALIZARPROCESSOSELECAO.Checked == false) { cadastrologin1.VisualizarProcessoSelecao = 0; }

                if (checkBoxEDITARPROCESSOSELECAO.Checked == true) { cadastrologin1.EditarProcessoSelecao = 1; }
                if (checkBoxEDITARPROCESSOSELECAO.Checked == false) { cadastrologin1.EditarProcessoSelecao = 0; }

                if (checkBoxEXCLUIRPROCESSOSELECAO.Checked == true) { cadastrologin1.ExcluirProcessoSelecao = 1; }
                if (checkBoxEXCLUIRPROCESSOSELECAO.Checked == false) { cadastrologin1.ExcluirProcessoSelecao = 0; }

                //ID DE ACESSO AO BANCO
                cadastrologin1.IdAcessoBaseDados = 1;
                //ATUALIZACAO DE TELA PRINCIPAL
                cadastrologin1.AtualicazaoTelaPrincipal = 1;

                if (NomeCriarPessoa(txtNomePessoa, errorProviderCadastraUsuario) == true)
                {
                    if (SobreNomeCriarPessoa(txtSobrenomePessoa, errorProviderCadastraUsuario) == true)
                    {
                        if (AbreviaçãoCriarPessoa(txtAbreviacao, errorProviderCadastraUsuario) == true)
                        {
                            if (this.FucionarioRh == "FuncionarioRh")
                            {
                                if (ReCriarPessoa(txtReFuncionarioRh, errorProviderCadastraUsuario) == true)
                                {
                                    if (AbreviaçãoFunciCriarPessoa(txtFuncionarioAbreviacaoRh, errorProviderCadastraUsuario) == true)
                                    {
                                        if (txtReFuncionarioRh.Text != "")
                                        {
                                            SqlConnection conn = new SqlConnection(this.connetionString);

                                            SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM U_FuncionarioRh WHERE ID_RE = " + txtReFuncionarioRh.Text + ";", conn);

                                            DataSet ds3 = new DataSet();
                                            da3.Fill(ds3);

                                            conn.Open();

                                            if (ds3.Tables[0].Rows.Count > 0)

                                            {
                                                this.contador++;
                                                MessageBox.Show("O Re consta no sistema não pode ser Inserido!");
                                            }
                                            if (!(ds3.Tables[0].Rows.Count > 0))
                                            {

                                            }
                                            conn.Close();
                                        }
                                        else MessageBox.Show("Re não pode está em branco");
                                    }

                                }
                            }
                            if (this.UNomeUsuario == "Usuario Acesso")
                            {
                                if (UsuarioAcessoCriarPessoa(txtUsuarioLoginFuncionario, errorProviderCadastraUsuario) == true)
                                {
                                    if (SenhaAcessoCriarPessoa(txtSenhaFuncionario, errorProviderCadastraUsuario) == true)
                                    {
                                        if (ConfirmaSenhaAcessoCriarPessoa(txtConfirmacaoSenhaFuncionario, errorProviderCadastraUsuario) == true)
                                        {
                                            if (txtUsuarioLoginFuncionario.Text != "")
                                            {
                                                SqlConnection conn2 = new SqlConnection(this.connetionString);

                                                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM U_LoginUsuario WHERE USUARIO = '" + txtUsuarioLoginFuncionario.Text + "';", conn2);

                                                DataSet ds2 = new DataSet();
                                                da2.Fill(ds2);

                                                conn2.Open();

                                                if (ds2.Tables[0].Rows.Count > 0)

                                                {
                                                    this.contador++;
                                                    MessageBox.Show("O Nome de Login já consta no sistema não pode ser Inserido!");
                                                }
                                                if (!(ds2.Tables[0].Rows.Count > 0))
                                                {
                                                    if (txtSenhaFuncionario.Text == txtConfirmacaoSenhaFuncionario.Text)
                                                    {

                                                    }
                                                    else { MessageBox.Show("Senha e confirmação de senha estão diferentes!"); this.contador++; }
                                                }
                                                conn2.Close();
                                            }
                                        }

                                    }

                                }
                            }
                            if (this.contador == 0)
                            {
                                Conexao2 conexao = new Conexao2(this.connetionString);
                                DALDateSystemRH dal = new DALDateSystemRH(conexao); //cadastra Pessoa
                                dal.IncluirUsuarioGeral(CadastraUsuarioGeral);

                                CepCadastraUsuarioGeral.idCep = CadastraUsuarioGeral.IdUsuario;
                                txtCepPessoa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                                String retString = txtCepPessoa.Text;

                                if (int.Parse(retString.Length.ToString()) > 0)
                                {
                                    Conexao2 conexao2 = new Conexao2(this.connetionString);
                                    DALDateSystemRH dal2 = new DALDateSystemRH(conexao2); //cadastra CEP
                                    dal2.UsuarioGeralCepInserir(CepCadastraUsuarioGeral);
                                }
                                if (this.FucionarioRh == "FuncionarioRh")
                                {
                                    FuncionarioRhS.IdFuncionario = CadastraUsuarioGeral.IdUsuario;
                                    Conexao2 conexao3 = new Conexao2(this.connetionString);
                                    DALDateSystemRH dal3 = new DALDateSystemRH(conexao3); //cadastra Funcionario
                                    dal3.IncluirFuncionarioRh(FuncionarioRhS);
                                }
                                if (this.UNomeUsuario == "Usuario Acesso")
                                {
                                    cadastrologin1.IdCadastroLoginNovo = CadastraUsuarioGeral.IdUsuario;
                                    Conexao2 conexao4 = new Conexao2(this.connetionString);
                                    DALDateSystemRH dal4 = new DALDateSystemRH(conexao4); //cadastra Funcionario
                                    dal4.IncluirLoginUsuario(cadastrologin1);
                                }
                                FecharTodosFormulario();
                                MessageBox.Show(" Usuário Cadastrado com sucesso!");
                                DialogResult dialogResult = MessageBox.Show("Deseja Cadastra Novo Usuário  " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (AcessoCadastroUsuario == 1)
                                    {
                                        FormCadastraUsuario FormCadastraUsuarioC = new FormCadastraUsuario(this.CriarNivelAcesso, this.CriarCadastroUsuario, this.CriarFuncionarioRh,
                                            this.CriarUsuarioAcesso, this.CriarUsuarioBaseDados, this.UsuarioAcessoAdm, this.AcessoCadastroUsuario);
                                        FormCadastraUsuarioC.MdiParent = this;
                                        FormCadastraUsuarioC.Show();
                                        FormCadastraUsuarioC.Top = 0;
                                        FormCadastraUsuarioC.Left = 0;

                                    }

                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                            }
                        }
                    }
                }             
            }
            catch(Exception ex)
            {
               MessageBox.Show( ex.ToString());
            }
        }
        private void checkBoxCriarUsuarioAcesso_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonCadastraFuncionarioRh_Click(object sender, EventArgs e)
        {
            cadastraFuncionarioRr();
        }
        public void cadastraFuncionarioRr()
        {
            this.FucionarioRh = "FuncionarioRh";
            panelCriarfuncionarioRH.Enabled = true;
            AlterarBotoes(3);
            buttonCadastraFuncionarioRh.Enabled = false;
            buttonCancelarFuncionarioRh.Enabled = true;
            buttonCadastraPermissaoUsuarioRh.Enabled = true;
        }


        private void buttonCancelarFuncionarioRh_Click(object sender, EventArgs e)
        {
            this.FucionarioRh = "";
            panelCriarfuncionarioRH.Enabled = false;
            AlterarBotoes(3);
            buttonCadastraFuncionarioRh.Enabled = true;
            buttonCancelarFuncionarioRh.Enabled = false;
            buttonCadastraPermissaoUsuarioRh.Enabled = false;
        }

        private void buttonAceitaNivelAcesso_Click(object sender, EventArgs e)
        {
            AcessaNivelPermissa();
            panelNivelAcesso.Enabled = true;
            buttonAceitaNivelAcesso.Enabled = false;
            buttonDesativaPermissaoNivel.Enabled = true;
        }
        public void AcessaNivelPermissa()
        {

            if (this.CriarUsuarioBaseDados == 1)
            {
                checkBoxBaseDados.Enabled = true;
                checkBoxBaseDados.Checked = true;
            }
            if (this.CriarNivelAcesso == 1)
            {
                checkBoxNivelAcesso.Enabled = true;
                checkBoxNivelAcesso.Checked = true;
            }
            if (this.CriarCadastroUsuario == 1)
            {
                checkBoxCriarCadastroUsuario.Enabled = true;
                checkBoxCriarCadastroUsuario.Checked = true;
            }
            if (this.CriarFuncionarioRh == 1)
            {
                CheckBoxCriarFuncionarioRh.Enabled = true;
                checkBoxFuncinarioRh.Enabled = true;
                CheckBoxCriarFuncionarioRh.Checked = true;
                checkBoxFuncinarioRh.Checked = true;
            }
            if (this.CriarUsuarioAcesso == 1)
            {
                checkBoxCriarUsuarioAcesso.Enabled = true;
                checkBoxUsuarioAcesso.Enabled = true;
                checkBoxCriarUsuarioAcesso.Checked = true;
                checkBoxUsuarioAcesso.Checked = true;
            }
            if (this.AcessoCadastroUsuario == 1)
            {
                checkBoxaAcessoCadastroUsuario.Enabled = true;
                checkBoxaAcessoCadastroUsuario.Checked = true;
            }
        }
        public void DesativaAcessaNivelPermissa()
        {
            checkBoxBaseDados.Enabled = true;
            checkBoxNivelAcesso.Enabled = true;
            checkBoxCriarCadastroUsuario.Enabled = true;
            CheckBoxCriarFuncionarioRh.Enabled = true;
            checkBoxFuncinarioRh.Enabled = true;
            checkBoxCriarUsuarioAcesso.Enabled = true;
            checkBoxUsuarioAcesso.Enabled = true;
            checkBoxaAcessoCadastroUsuario.Enabled = true;

            checkBoxBaseDados.Checked = false;
            checkBoxNivelAcesso.Checked = false;
            checkBoxCriarCadastroUsuario.Checked = false;
            CheckBoxCriarFuncionarioRh.Checked = false;
            checkBoxFuncinarioRh.Checked = false;
            checkBoxCriarUsuarioAcesso.Checked = false;
            checkBoxUsuarioAcesso.Checked = false;
            checkBoxaAcessoCadastroUsuario.Checked = false;

        }

        private void buttonDesativaPermissaoNivel_Click(object sender, EventArgs e)
        {
            DesativaAcessaNivelPermissa();
            UNomeUsuario = "";
            panelNivelAcesso.Enabled = false;
            buttonAceitaNivelAcesso.Enabled = true;
            buttonDesativaPermissaoNivel.Enabled = false;
        }
        public void DesativaCheckNivelAcesso()
        {
            checkBoxBaseDados.Checked = false;
            checkBoxNivelAcesso.Checked = false;
            checkBoxCriarCadastroUsuario.Checked = false;
            CheckBoxCriarFuncionarioRh.Checked = false;
            checkBoxFuncinarioRh.Checked = false;
            checkBoxCriarUsuarioAcesso.Checked = false;
            checkBoxUsuarioAcesso.Checked = false;
            checkBoxaAcessoCadastroUsuario.Checked = false;

        }

        private void buttonPermissaoUsuarioAcesso_Click(object sender, EventArgs e)
        {
            if (this.UNomeUsuario == "Usuario Acesso")
            {
                CadastraPermissaoUsuarioAcesso();
                AtivaPermissaoFuncionarioUsuarioAcesso();
            }
            else { MessageBox.Show("Cadastra Usuário Acesso tem que está ativado!"); }
        }
        public void CadastraPermissaoUsuarioAcesso()
        {
            panelPermissaoSistema.Enabled = true;
            buttonPermissaoUsuarioAcesso.Enabled = false;
            buttonNPermissaoUsuarioAcesso.Enabled = true;
        }
        public void AtivaPermissaoFuncionarioUsuarioAcesso()
        {
            checkBoxCRIARSistema.Checked = true;
            checkBoxALTERARSistema.Checked = true;
            checkBoxEXCLUIRSistema.Checked = true;
            checkBoxPESQUISASistema.Checked = true;
            checkBoxVISUALIZARSistema.Checked = true;
        }

        private void buttonNPermissaoUsuarioAcesso_Click(object sender, EventArgs e)
        {
            CancelarPermissaoUsuarioAcesso();
            DesativaPermissaoFuncionarioUsuarioAcesso();
        }
        public void CancelarPermissaoUsuarioAcesso()
        {
            panelPermissaoSistema.Enabled = false;
            buttonPermissaoUsuarioAcesso.Enabled = true;
            buttonNPermissaoUsuarioAcesso.Enabled = false;
        }
        public void DesativaPermissaoFuncionarioUsuarioAcesso()
        {
            checkBoxCRIARSistema.Checked = false;
            checkBoxALTERARSistema.Checked = false;
            checkBoxEXCLUIRSistema.Checked = false;
            checkBoxPESQUISASistema.Checked = false;
            checkBoxVISUALIZARSistema.Checked = false;
        }

        private void buttonBuscaCepFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", txtCepPessoa.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                labelConfirmacao.Text = ds.Tables[0].Rows[0][1].ToString();
                txtLogradouroPessoa.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEnderecoPessoa.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBairroPessoa.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCidadePessoa.Text = ds.Tables[0].Rows[0][3].ToString();
              
            }

            catch (Exception)
            {
                MessageBox.Show("Site com erro!");
            }
        }

        private void buttonCancelarcadastrousuario_Click(object sender, EventArgs e)
        {

        }

        private void txtReFuncionarioRh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void buttonFecharFuncionario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormCadastraUsuario));
        }
        public static void FechatodosFormularios(Type frmType)
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

        private void FormCadastraUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
