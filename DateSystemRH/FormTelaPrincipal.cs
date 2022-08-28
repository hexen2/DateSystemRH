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
using Microsoft.Win32;


namespace DateSystemRH
{
    public partial class FormTelaPrincipal : Form
    {
        private int CONTADOR = 0;
        public int Contador
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

        private string CONNECTIONSTRING = "";
        public string connectionString
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
        private int ID_LOGIN_USUARIO = 0;
        public int IdLoginUsuario
        {
            get
            {
                return this.ID_LOGIN_USUARIO;

            }
            set
            {
                this.ID_LOGIN_USUARIO = value;
            }
        }  
        private string USUARIO = "";
        public string Usuario
        {
            get
            {
                return this.USUARIO;

            }
            set
            {
                this.USUARIO = value;
            }
        }
        private int USUARIOACESSO = 0;
        public int UsuarioAcesso
        {
            get
            {
                return this.USUARIOACESSO;

            }
            set
            {
                this.USUARIOACESSO = value;
            }
        }

        private int ID_ACESSO_BASE_DADOS = 0;
        public int IdAcessoBaseDados
        {
            get
            {
                return this.ID_ACESSO_BASE_DADOS;

            }
            set
            {
                this.ID_ACESSO_BASE_DADOS = value;
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
        public int CriarPermissaoFuncionarioRh
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
        private int USUARIOCRIAR = 0;
        public int UsuarioCriar
        {
            get
            {
                return this.USUARIOCRIAR;

            }
            set
            {
                this.USUARIOCRIAR = value;
            }
        }
        private int USUARIOALTERAR = 0;
        public int UsuarioAlterar
        {
            get
            {
                return this.USUARIOALTERAR;

            }
            set
            {
                this.USUARIOALTERAR = value;
            }
        }
        private int USUARIEXCLUIR = 0;
        public int UsuarioExcluir
        {
            get
            {
                return this.USUARIEXCLUIR;

            }
            set
            {
                this.USUARIEXCLUIR = value;
            }
        }
        private int USUARIOPESQUISA = 0;
        public int UsuarioPesquisa
        {
            get
            {
                return this.USUARIOPESQUISA;

            }
            set
            {
                this.USUARIOPESQUISA = value;
            }
        }
        private int USUARIOVISUALIZAR = 0;
        public int UsuarioVisualizar
        {
            get
            {
                return this.USUARIOVISUALIZAR;

            }
            set
            {
                this.USUARIOVISUALIZAR = value;
            }
        }
        private int EMPRESACADASTRA = 0;

        public int EmpresaCadastra
        {
            get
            {
                return this.EMPRESACADASTRA;

            }
            set
            {
                this.EMPRESACADASTRA = value;
            }
        }
        private int EMPRESAPESQUISA = 0;
        public int EmpresaPesquisa
        {
            get
            {
                return this.EMPRESAPESQUISA;

            }
            set
            {
                this.EMPRESAPESQUISA = value;
            }
        }
        private int EMPRESAVISUALIZAR = 0;
        public int EmpresaVisualizar
        {
            get
            {
                return this.EMPRESAVISUALIZAR;

            }
            set
            {
                this.EMPRESAVISUALIZAR = value;
            }
        }
        private int EMPRESAEDITAR = 0;
        public int EmpresaEditar
        {
            get
            {
                return this.EMPRESAEDITAR;

            }
            set
            {
                this.EMPRESAEDITAR = value;
            }
        }
        private int FICHACADASTRA = 0;
        public int FichaCadastra
        {
            get
            {
                return this.FICHACADASTRA;

            }
            set
            {
                this.FICHACADASTRA = value;
            }
        }
        private int FICHAPESQUISA = 0;
        public int FichaPesquisa
        {
            get
            {
                return this.FICHAPESQUISA;

            }
            set
            {
                this.FICHAPESQUISA = value;
            }
        }
        private int FICHAVISUALIZAR = 0;
        public int FichaVisualizar
        {
            get
            {
                return this.FICHAVISUALIZAR;

            }
            set
            {
                this.FICHAVISUALIZAR = value;
            }
        }
        private int FICHAEDITAR = 0;
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
        private int PROCESSOSELECAOCADASTRA = 0;
        public int ProcessoSelecaoCadastra
        {
            get
            {
                return this.PROCESSOSELECAOCADASTRA;

            }
            set
            {
                this.PROCESSOSELECAOCADASTRA = value;
            }
        }
        private int PROCESSOSELECAOPESQUISA = 0;
        public int ProcessoSelecaoPesquisa
        {
            get
            {
                return this.PROCESSOSELECAOPESQUISA;

            }
            set
            {
                this.PROCESSOSELECAOPESQUISA = value;
            }
        }

        private int PROCESSOSELECAOVISUALIZAR = 0;
        public int ProcessoSelecaoVisualizar
        {
            get
            {
                return this.PROCESSOSELECAOVISUALIZAR;

            }
            set
            {
                this.PROCESSOSELECAOVISUALIZAR = value;
            }
        }
        private int PROCESSOSELECAOREDITAR = 0;
        public int ProcessoSelecaoEditar
        {
            get
            {
                return this.PROCESSOSELECAOREDITAR;

            }
            set
            {
                this.PROCESSOSELECAOREDITAR = value;
            }
        }
        private int ATUALIZACAOTELAPRINCIPAL = 0;
        public int AtualizarTelaPrincipal
        {
            get
            {
                return this.ATUALIZACAOTELAPRINCIPAL;

            }
            set
            {
                this.ATUALIZACAOTELAPRINCIPAL = value;
            }
        }

        public FormTelaPrincipal()
        {
            InitializeComponent();
        }
        public FormTelaPrincipal(string nome, string connectionString)
        {
            try
            {
                InitializeComponent();

                this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

                SqlConnection conn = new SqlConnection(this.connectionString);
                string sql1 = "exec U_ConsultaNomeUsuarioAcesso '" + nome + "';";
                SqlDataAdapter sda = new SqlDataAdapter(sql1, conn);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1);

                conn.Open();

                //PERMISSÃO DO SISTEMA

                this.IdLoginUsuario = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                this.Usuario = ds1.Tables[0].Rows[0][16].ToString();
                this.UsuarioAcessoAdm = int.Parse(ds1.Tables[0].Rows[0][19].ToString());
                this.IdAcessoBaseDados = int.Parse(ds1.Tables[0].Rows[0][20].ToString());
                this.AcessoCadastroUsuario = int.Parse(ds1.Tables[0].Rows[0][21].ToString());
                this.CriarCadastroUsuario = int.Parse(ds1.Tables[0].Rows[0][22].ToString());
                this.CriarFuncionarioRh = int.Parse(ds1.Tables[0].Rows[0][23].ToString());
                this.CriarUsuarioAcesso = int.Parse(ds1.Tables[0].Rows[0][24].ToString());
                this.CriarUsuarioBaseDados = int.Parse(ds1.Tables[0].Rows[0][25].ToString());
                this.CriarNivelAcesso = int.Parse(ds1.Tables[0].Rows[0][26].ToString());
                this.CriarPermissaoFuncionarioRh = int.Parse(ds1.Tables[0].Rows[0][27].ToString());
                this.CriarPermissaoUsuarioAcesso = int.Parse(ds1.Tables[0].Rows[0][28].ToString());
                //USUARIO
                this.UsuarioCriar = int.Parse(ds1.Tables[0].Rows[0][29].ToString());
                this.UsuarioAlterar = int.Parse(ds1.Tables[0].Rows[0][30].ToString());
                this.UsuarioExcluir = int.Parse(ds1.Tables[0].Rows[0][31].ToString());
                this.UsuarioPesquisa = int.Parse(ds1.Tables[0].Rows[0][32].ToString());
                this.UsuarioVisualizar = int.Parse(ds1.Tables[0].Rows[0][33].ToString());
                //EMPRESA
                this.EmpresaCadastra = int.Parse(ds1.Tables[0].Rows[0][34].ToString());
                this.EmpresaPesquisa = int.Parse(ds1.Tables[0].Rows[0][35].ToString());
                this.EmpresaVisualizar = int.Parse(ds1.Tables[0].Rows[0][36].ToString());
                this.EmpresaEditar = int.Parse(ds1.Tables[0].Rows[0][37].ToString());
                //FICHA
                this.FichaCadastra = int.Parse(ds1.Tables[0].Rows[0][39].ToString());
                this.FichaPesquisa = int.Parse(ds1.Tables[0].Rows[0][40].ToString());
                this.FichaVisualizar = int.Parse(ds1.Tables[0].Rows[0][41].ToString());
                this.FichaEditar = int.Parse(ds1.Tables[0].Rows[0][42].ToString());
                //PROCESSO SELECAO
                this.ProcessoSelecaoCadastra = int.Parse(ds1.Tables[0].Rows[0][44].ToString());
                this.ProcessoSelecaoPesquisa = int.Parse(ds1.Tables[0].Rows[0][45].ToString());
                this.ProcessoSelecaoVisualizar = int.Parse(ds1.Tables[0].Rows[0][46].ToString());
                this.ProcessoSelecaoEditar = int.Parse(ds1.Tables[0].Rows[0][47].ToString());
                // ATUALIZAR TELA PRINCIPAL
                this.AtualizarTelaPrincipal = int.Parse(ds1.Tables[0].Rows[0][49].ToString());

                conn.Close();
                label1.Text = "Usuário logado: " + this.Usuario + ".";

                this.Text = "Tela principal DateSystemRH - Base de dados: MSRH - Brasil é um país de todos!";

                //timerTela.Start();
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void Atualizacao()
        {
            if (this.AtualizarTelaPrincipal == 1)
            {
                FecharTodosFormulario();
                FormNovasAtualizacoesTelaPrincipal FormNovasAtualizacoesTelaPrincipalF = new FormNovasAtualizacoesTelaPrincipal(this.IdLoginUsuario);
                //FormNovasAtualizacoesTelaPrincipalF.MdiParent = this;
                //FormNovasAtualizacoesTelaPrincipalF.MdiParent = FormNovasAtualizacoesTelaPrincipal.ActiveForm;
                FormNovasAtualizacoesTelaPrincipalF.ShowDialog();
                FormNovasAtualizacoesTelaPrincipalF.Top = 200;
                FormNovasAtualizacoesTelaPrincipalF.Left = 150;
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Sair do Sistema!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void FormPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                try
                {
                    if (FichaCadastra == 0)
                    {
                        MessageBox.Show("Acesso não Permitido!");
                    }
                    if (FichaCadastra == 1)
                    {
                        FecharTodosFormulario();
                        FormFichaSolicitacaoEmprego FormFichaSolicitacaoEmpregoE = new FormFichaSolicitacaoEmprego(this.IdLoginUsuario, "");
                        /*FormFichaSolicitacaoEmpregoE.MdiParent = this;*/
                        FormFichaSolicitacaoEmpregoE.ShowDialog();
                        FormFichaSolicitacaoEmpregoE.Top = 200;
                        FormFichaSolicitacaoEmpregoE.Left = 150;
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    if (this.FichaCadastra == 0)
                    {
                        MessageBox.Show("Acesso não Permitido!");
                    }
                    if (this.FichaCadastra == 1)
                    {
                        FecharTodosFormulario();
                        FormVerificadoCpfRg FormVerificadoCpfRgF = new FormVerificadoCpfRg(this.IdLoginUsuario);
                        //FormVerificadoCpfRgF.MdiParent = this;
                        FormVerificadoCpfRgF.ShowDialog();
                        FormVerificadoCpfRgF.Top = 200;
                        FormVerificadoCpfRgF.Left = 150;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    if (FichaPesquisa == 0)
                    {
                        MessageBox.Show("Acesso não Permitido!");
                    }
                    if (FichaPesquisa == 1)
                    {
                        FecharTodosFormulario();
                        FormPesquisaFichaSolicitacaoEmprego FormPesquisaFichaSolicitacaoEmpregoC = new FormPesquisaFichaSolicitacaoEmprego(this.IdLoginUsuario, this.FichaVisualizar, this.FichaEditar);
                        //CadastraRegistro.MdiParent = this;
                        FormPesquisaFichaSolicitacaoEmpregoC.ShowDialog();
                        FormPesquisaFichaSolicitacaoEmpregoC.Top = 200;
                        FormPesquisaFichaSolicitacaoEmpregoC.Left = 150;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                try
                {
                    if (ProcessoSelecaoPesquisa == 0)
                    {
                        MessageBox.Show("Acesso não Permitido!");
                    }
                    if (ProcessoSelecaoPesquisa == 1)
                    {
                        FecharTodosFormulario();
                        FormPesquisaProcessoSelecao FormPesquisaProcessoSelecaoP = new FormPesquisaProcessoSelecao(this.IdLoginUsuario, this.ProcessoSelecaoVisualizar, this.ProcessoSelecaoEditar, this.FichaEditar);
                        FormPesquisaProcessoSelecaoP.ShowDialog();
                        FormPesquisaProcessoSelecaoP.Top = 200;
                        FormPesquisaProcessoSelecaoP.Left = 150;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    if (ProcessoSelecaoCadastra == 0)
                    {
                        MessageBox.Show("Acesso não Permitido!");
                    }
                    if (ProcessoSelecaoCadastra == 1)
                    {
                        FecharTodosFormulario();
                        FormProcessoSelecao FormProcessoSelecaoP = new FormProcessoSelecao(this.IdLoginUsuario, this.FichaEditar);
                        //FormProcessoSelecaoP.MdiParent = this;
                        FormProcessoSelecaoP.ShowDialog();
                        FormProcessoSelecaoP.Top = 200;
                        FormProcessoSelecaoP.Left = 150;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Sair do Sistema!", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
        private void fichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FichaCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FichaCadastra == 1)
            {
                FecharTodosFormulario();
                FormFichaSolicitacaoEmprego FormFichaSolicitacaoEmpregoE = new FormFichaSolicitacaoEmprego(this.IdLoginUsuario,"");
                //FormFichaSolicitacaoEmpregoE.MdiParent = this;
                FormFichaSolicitacaoEmpregoE.ShowDialog();
                FormFichaSolicitacaoEmpregoE.Top = 200;
                FormFichaSolicitacaoEmpregoE.Left = 150;
            }
        }
        private void empresaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EmpresaCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (EmpresaCadastra == 1)
            {
                FecharTodosFormulario();
                FormEmpresaCliente FormEmpresaClienteE = new FormEmpresaCliente();
                //FormEmpresaClienteE.MdiParent = this;
                FormEmpresaClienteE.ShowDialog();
                FormEmpresaClienteE.Top = 200;
                FormEmpresaClienteE.Left = 150;
            }
        }

        private void empresaClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (EmpresaPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (EmpresaPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaEmpresaCadastradaCliente FormPesquisaEmpresaCadastradaClienteC = new FormPesquisaEmpresaCadastradaCliente( this.EmpresaVisualizar, this.EmpresaEditar);
                //CadastraRegistro.MdiParent = this;
                FormPesquisaEmpresaCadastradaClienteC.ShowDialog();
                FormPesquisaEmpresaCadastradaClienteC.Top = 200;
                FormPesquisaEmpresaCadastradaClienteC.Left = 150;
            }   
        }

        private void empregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FichaPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FichaPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaFichaSolicitacaoEmprego FormPesquisaFichaSolicitacaoEmpregoC = new FormPesquisaFichaSolicitacaoEmprego(this.IdLoginUsuario, this.FichaVisualizar, this.FichaEditar);
                //CadastraRegistro.MdiParent = this;
                FormPesquisaFichaSolicitacaoEmpregoC.ShowDialog();
                FormPesquisaFichaSolicitacaoEmpregoC.Top = 200;
                FormPesquisaFichaSolicitacaoEmpregoC.Left = 150;
            }
        }

        private void gerarF3PSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProcessoSelecaoCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ProcessoSelecaoCadastra == 1)
            {               
                FecharTodosFormulario();
                FormProcessoSelecao FormProcessoSelecaoP = new FormProcessoSelecao(this.IdLoginUsuario,this.FichaEditar);

                FormProcessoSelecaoP.ShowDialog();
                FormProcessoSelecaoP.Top = 200;
                FormProcessoSelecaoP.Left = 150;
            }
        }

        private void processoSeletivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProcessoSelecaoPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ProcessoSelecaoPesquisa == 1)
            {

                FecharTodosFormulario();
                FormPesquisaProcessoSelecao FormPesquisaProcessoSelecaoP = new FormPesquisaProcessoSelecao(this.IdLoginUsuario, this.ProcessoSelecaoVisualizar, this.ProcessoSelecaoEditar,this.FichaEditar);
                FormPesquisaProcessoSelecaoP.ShowDialog();
                FormPesquisaProcessoSelecaoP.Top = 200;
                FormPesquisaProcessoSelecaoP.Left = 150;
            }
        }
        private void verificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void usuárioFuncionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AcessoCadastroUsuario == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (AcessoCadastroUsuario == 1)
            {
                FecharTodosFormulario();

                FormCadastraUsuario FormCadastraUsuarioC = new FormCadastraUsuario(this.CriarNivelAcesso, this.CriarCadastroUsuario, this.CriarFuncionarioRh,
                    this.CriarUsuarioAcesso, this.CriarUsuarioBaseDados, this.UsuarioAcessoAdm, this.AcessoCadastroUsuario);
                //FormCadastraUsuarioC.MdiParent = this;
                FormCadastraUsuarioC.ShowDialog();
                FormCadastraUsuarioC.Top = 0;
                FormCadastraUsuarioC.Left = 0;

            }
        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormCadastraUsuario));
            FechatodosFormularios(typeof(FormEmpresaCliente));
            FechatodosFormularios(typeof(FormEmpresaClienteEditar));
            FechatodosFormularios(typeof(FormFichaSolicitacaoEmprego));
            FechatodosFormularios(typeof(FormFichaSolicitacaoEmpregoEditar));
            FechatodosFormularios(typeof(FormFotoFicha));
            FechatodosFormularios(typeof(FormNovasAtualizacoesTelaPrincipal));
            FechatodosFormularios(typeof(FormPesquisaEmpresaCadastradaCliente));
            FechatodosFormularios(typeof(FormPesquisaFichaSolicitacaoEmprego));
            FechatodosFormularios(typeof(FormPesquisaProcessoSelecao));
            FechatodosFormularios(typeof(FormProcessoSelecao));
            FechatodosFormularios(typeof(FormProcessoSelecaoEditar));
            FechatodosFormularios(typeof(FormVerificadoCpfRg));
            
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

        private void rgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verificarRgCpfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.FichaCadastra == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (this.FichaCadastra == 1)
                {
                    FecharTodosFormulario();
                    FormVerificadoCpfRg FormVerificadoCpfRgF = new FormVerificadoCpfRg(this.IdLoginUsuario);
                    //FormVerificadoCpfRgF.MdiParent = this;
                    FormVerificadoCpfRgF.ShowDialog();
                    FormVerificadoCpfRgF.Top = 200;
                    FormVerificadoCpfRgF.Left = 150;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void desenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String S = "Desenvolvido por Hexen Alvares! \n " + "Ano de 2019 \n" + " Versão inicial 1.0 :)";
            MessageBox.Show(S, "Agradeço a Todos pelo o Apoio!");
        }

        private void atualizaçõesDoMSRHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormNovasAtualizacoesTelaPrincipal FormNovasAtualizacoesTelaPrincipalF = new FormNovasAtualizacoesTelaPrincipal(this.IdLoginUsuario);
            FormNovasAtualizacoesTelaPrincipalF.ShowDialog();
            FormNovasAtualizacoesTelaPrincipalF.Top = 200;
            FormNovasAtualizacoesTelaPrincipalF.Left = 150;
        }

        private void timerTela_Tick(object sender, EventArgs e)
        {
            timerTela.Enabled = true;
            timerTela.Stop();
            timerTela.Interval = 500;

            for (int  i = 0; i <= 100; i++)
            {
                if( i == 100)
                {            
                    Atualizacao();

                }
            }
            
            timerTela.Enabled = false;
            
        }
    }
}

