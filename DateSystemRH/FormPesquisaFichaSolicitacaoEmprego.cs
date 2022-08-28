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
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace DateSystemRH
{
    public partial class FormPesquisaFichaSolicitacaoEmprego : Form
    {
        DataTable TableTodos;
        DataTable TableRg;
        DataTable TableCpf;
        DataTable NomePessoa;

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

        private int VALORPESQUISA = 0;
        public int ValorPesquisa
        {
            get
            {
                return this.VALORPESQUISA;

            }
            set
            {
                this.VALORPESQUISA = value;
            }
        }
        private int ID_PESSOA = 0;
        public int IdPessoa
        {
            get
            {
                return this.ID_PESSOA;

            }
            set
            {
                this.ID_PESSOA = value;
            }
        }
        private int ID_PESSOA_TIPO = 0;
        public int IdPessoaTipo
        {
            get
            {
                return this.ID_PESSOA_TIPO;

            }
            set
            {
                this.ID_PESSOA_TIPO = value;
            }
        }       
        private string NOMESERVIDOR = "";
        public string NomeServidor
        {
            get
            {
                return this.NOMESERVIDOR;

            }
            set
            {
                this.NOMESERVIDOR = value;
            }
        }
        private string BASE_DADOS = "";
        public string BaseDados
        {
            get
            {
                return this.BASE_DADOS;

            }
            set
            {
                this.BASE_DADOS = value;
            }
        }
        private string NOMEBASEDADOS = "";
        public string NomeBaseDados
        {
            get
            {
                return this.NOMEBASEDADOS;

            }
            set
            {
                this.NOMEBASEDADOS = value;
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
        private string SENHABASEDADOS = "";
        public string SenhaBaseDados
        {
            get
            {
                return this.SENHABASEDADOS;

            }
            set
            {
                this.SENHABASEDADOS = value;
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
        private int IDLOGINUSUARIO = 0;
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
        private int FICHAVISUALIZAR =0;
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
        public FormPesquisaFichaSolicitacaoEmprego(int IdLoginUsuario, int FichaVisualizar, int FichaEditar)
        {
            InitializeComponent();
            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

            this.IdLoginUsuario = IdLoginUsuario;
            this.FichaVisualizar = FichaVisualizar;
            this.FichaEditar = FichaEditar;
            txtPesquisaRG.MaxLength = 9;
            txtCpf.MaxLength = 11;
            txtPesquisaNomePessoa.MaxLength = 20;

        }

        private void FormPesquisaFichaSolicitacaoEmprego_Load(object sender, EventArgs e)
        {

        }
        void dataGridViewPesquisaTodos()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true) { situacao = 1; }
            if (checkBoxSituacao.Checked == false) { situacao = 2; }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoTodosTxt " + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaFichas.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
            }
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
        void dataGridViewPesquisaRg()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec RH_ConsultaFichaEmpregoRgTxt '" + txtPesquisaRG.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableRg = new DataTable();
                adapter.Fill(TableRg);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableRg;
                dataGridViewPesquisaFichas.DataSource = Source;
                adapter.Update(TableRg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaCpf()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec RH_ConsultaFichaEmpregoCfpTxt '" + txtCpf.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCpf = new DataTable();
                adapter.Fill(TableCpf);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCpf;
                dataGridViewPesquisaFichas.DataSource = Source;
                adapter.Update(TableCpf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaNome()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec RH_ConsultaFichaEmpregoNomeTxt '" + txtPesquisaNomePessoa.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                NomePessoa = new DataTable();
                adapter.Fill(NomePessoa);
                BindingSource Source = new BindingSource();
                Source.DataSource = NomePessoa;
                dataGridViewPesquisaFichas.DataSource = Source;
                adapter.Update(NomePessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //DataTable dt = new DataTable();
        }
        public void LimpaFichasCadastradas(int entrada)
        {
            try
            {
                if (entrada == 0)
                {
                    if (this.dataGridViewPesquisaFichas.DataSource != null)
                    {
                        this.dataGridViewPesquisaFichas.DataSource = null;
                    }
                    else
                    {
                        this.dataGridViewPesquisaFichas.Rows.Clear();

                    }
                }
                if (entrada == 1)
                {
                    dataGridViewPesquisaFichas.ColumnCount = 10;
                    dataGridViewPesquisaFichas.Columns[0].Name = "PESSOA1";
                    dataGridViewPesquisaFichas.Columns[0].DataPropertyName = "PESSOA1";
                    dataGridViewPesquisaFichas.Columns[0].Width = 100;
                    dataGridViewPesquisaFichas.Columns[0].HeaderText = "REGISTRO";
                    dataGridViewPesquisaFichas.Columns[1].Name = "NOME";
                    dataGridViewPesquisaFichas.Columns[1].DataPropertyName = "NOME";
                    dataGridViewPesquisaFichas.Columns[1].Width = 100;
                    dataGridViewPesquisaFichas.Columns[1].HeaderText = "NOME";
                    dataGridViewPesquisaFichas.Columns[2].Name = "TELEFONE";
                    dataGridViewPesquisaFichas.Columns[2].DataPropertyName = "TELEFONE";
                    dataGridViewPesquisaFichas.Columns[2].Width = 100;
                    dataGridViewPesquisaFichas.Columns[2].HeaderText = "TELEFONE";
                    dataGridViewPesquisaFichas.Columns[3].Name = "CELULAR";
                    dataGridViewPesquisaFichas.Columns[3].DataPropertyName = "CELULAR";
                    dataGridViewPesquisaFichas.Columns[3].Width = 100;
                    dataGridViewPesquisaFichas.Columns[3].HeaderText = "CELULAR";
                    dataGridViewPesquisaFichas.Columns[4].Name = "TELEFONE_RECADO";
                    dataGridViewPesquisaFichas.Columns[4].DataPropertyName = "TELEFONE_RECADO";
                    dataGridViewPesquisaFichas.Columns[4].Width = 100;
                    dataGridViewPesquisaFichas.Columns[4].HeaderText = "TELEFONE RECADO";
                    dataGridViewPesquisaFichas.Columns[5].Name = "CELULAR_RECADO";
                    dataGridViewPesquisaFichas.Columns[5].DataPropertyName = "CELULAR_RECADO";
                    dataGridViewPesquisaFichas.Columns[5].Width = 100;
                    dataGridViewPesquisaFichas.Columns[5].HeaderText = "CELULAR RECADO";
                    dataGridViewPesquisaFichas.Columns[6].Name = "NOME_RECARDO2";
                    dataGridViewPesquisaFichas.Columns[6].DataPropertyName = "NOME_RECARDO2";
                    dataGridViewPesquisaFichas.Columns[6].Width = 100;
                    dataGridViewPesquisaFichas.Columns[6].HeaderText = "NOME RECARDO2";
                    dataGridViewPesquisaFichas.Columns[7].Name = "NOME_REGIAO";
                    dataGridViewPesquisaFichas.Columns[7].DataPropertyName = "NOME_REGIAO";
                    dataGridViewPesquisaFichas.Columns[7].Width = 100;
                    dataGridViewPesquisaFichas.Columns[7].HeaderText = "NOME REGIÃO";
                    dataGridViewPesquisaFichas.Columns[8].Name = "CPF";
                    dataGridViewPesquisaFichas.Columns[8].DataPropertyName = "CPF";
                    dataGridViewPesquisaFichas.Columns[8].Width = 100;
                    dataGridViewPesquisaFichas.Columns[8].HeaderText = "CPF";
                    dataGridViewPesquisaFichas.Columns[9].Name = "RG";
                    dataGridViewPesquisaFichas.Columns[9].DataPropertyName = "RG";
                    dataGridViewPesquisaFichas.Columns[9].Width = 100;
                    dataGridViewPesquisaFichas.Columns[9].HeaderText = "RG";
                }
            }
            catch (Exception ex) { ex.ToString(); }

        }

        private void buttonPesquisaFicha_Click(object sender, EventArgs e)
        {
            Busca();

        }
        public void Busca()
        {
            try
            {
                int situacao = 0;

                if (checkBoxSituacao.Checked == true)
                {
                    situacao = 1;
                }
                if (checkBoxSituacao.Checked == false)
                {
                    situacao = 2;
                }
                LimpaFichasCadastradas(0);
                LimpaFichasCadastradas(1);
                SqlConnection conn = new SqlConnection(this.connetionString);
                if (!(radioButtonTodos.Checked == true) && !(radioButtonPesquisarRG.Checked == true) && !(radioButtonCpf.Checked == true)
                    && !(radioButtonPesquisarNome.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, Todos, RG, CPF ou NOME! ");
                }
                if (radioButtonTodos.Checked == true)
                {
                    dataGridViewPesquisaFichas.Refresh();
                    label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaFichaEmpregoTodosTxt " + situacao + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaFichas.DataSource == null)
                        {
                            dataGridViewPesquisaFichas.Refresh();
                        }
                        if (!(dataGridViewPesquisaFichas.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaFichas.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                        MessageBox.Show("Nem uma Ficha de solicitação de emprego foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 1;
                        dataGridViewPesquisaTodos();
                        label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                    }
                }
                if (radioButtonPesquisarRG.Checked == true)
                {
                    if (txtPesquisaRG.Text == "")
                    {
                        dataGridViewPesquisaFichas.Refresh();
                        label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                        MessageBox.Show("O RG não pode esta em Branco!");
                    }
                    if (!(txtPesquisaRG.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaFichaEmpregoRgTxt '" + txtPesquisaRG.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaFichas.DataSource == null)
                            {
                                dataGridViewPesquisaFichas.Refresh();
                            }
                            if (!(dataGridViewPesquisaFichas.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaFichas.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                            MessageBox.Show("Nem uma Ficha de solicitação de emprego foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 2;
                            dataGridViewPesquisaRg();
                            label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                        }
                    }
                }
                if (radioButtonCpf.Checked == true)
                {
                    if (txtCpf.Text == "")
                    {
                        dataGridViewPesquisaFichas.Refresh();
                        label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                        MessageBox.Show("O Cpf não pode esta em Branco!");
                    }
                    if (!(txtCpf.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC  RH_ConsultaFichaEmpregoCfpTxt '" + txtCpf.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaFichas.DataSource == null)
                            {
                                dataGridViewPesquisaFichas.Refresh();
                            }
                            if (!(dataGridViewPesquisaFichas.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaFichas.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                            MessageBox.Show("Nem uma Ficha de solicitação de emprego foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 3;
                            dataGridViewPesquisaCpf();
                            label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                        }
                    }
                }
                if (radioButtonPesquisarNome.Checked == true)
                {
                    if (txtPesquisaNomePessoa.Text == "")
                    {
                        dataGridViewPesquisaFichas.Refresh();
                        label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                        MessageBox.Show("O Nome não pode esta em Branco!");
                    }
                    if (!(txtPesquisaNomePessoa.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC  RH_ConsultaFichaEmpregoNomeTxt '" + txtPesquisaNomePessoa.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaFichas.DataSource == null)
                            {
                                dataGridViewPesquisaFichas.Refresh();
                            }
                            if (!(dataGridViewPesquisaFichas.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaFichas.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();

                            MessageBox.Show("Nem uma Ficha de solicitação de emprego foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 4;
                            dataGridViewPesquisaNome();
                            label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void txtPesquisaRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    Busca();
                }
                //Se a tecla digitada não for número
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    Busca();
                }
                //Se a tecla digitada não for número
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void txtPesquisaNomePessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    Busca();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(1);
        }
        private void radioButtonPesquisarRG_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(2);
        }
        private void radioButtonCpf_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(3);
        }

        private void radioButtonPesquisarNome_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(4);
        }
        private void txtPesquisaRG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableRg);
                    DV.RowFilter = string.Format("RG LIKE '%{0}%'", txtPesquisaRG.Text);
                    dataGridViewPesquisaFichas.DataSource = DV;
                    label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                }
            }
            catch
            {

            }
        }
        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 3)
                {
                    DataView DV = new DataView(TableCpf);
                    DV.RowFilter = string.Format("CPF LIKE '%{0}%'", txtCpf.Text);
                    dataGridViewPesquisaFichas.DataSource = DV;
                    label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                }
            }
            catch
            {

            }
        }

        private void txtPesquisaNomePessoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 4)
                {
                    DataView DV = new DataView(NomePessoa);
                    DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtPesquisaNomePessoa.Text);
                    dataGridViewPesquisaFichas.DataSource = DV;
                    label8.Text = dataGridViewPesquisaFichas.RowCount.ToString();
                }
            }
            catch
            {

            }
        }


        public void AlteraBotoes(int botao)
        {
            if(botao == 1)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = false;

                txtCpf.Clear();
                txtCpf.Enabled = false;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = false;
                ValorPesquisa = 1;
            }
            if (botao == 2)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = true;

                txtCpf.Clear();
                txtCpf.Enabled = false;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = false;
                ValorPesquisa = 2;
            }
            if (botao == 3)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = false;

                txtCpf.Clear();
                txtCpf.Enabled = true;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = false;
                ValorPesquisa = 3;
            }
            if (botao == 4)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = false;

                txtCpf.Clear();
                txtCpf.Enabled = false;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = true;
                ValorPesquisa = 4;
            }
        }

        private void dataGridViewPesquisaFichas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (this.FichaVisualizar == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (this.FichaVisualizar == 1)
                {
                    ////FecharTodosFormulario();

                    //FormFichaSolicitacaoEmpregoEditar FormFichaSolicitacaoEmpregoEditarE = new FormFichaSolicitacaoEmpregoEditar(IdPessoaP);
                    //FormFichaSolicitacaoEmpregoEditarE.MdiParent = FormFichaSolicitacaoEmpregoEditar.ActiveForm;
                    //FormFichaSolicitacaoEmpregoEditarE.Show();
                    //FormFichaSolicitacaoEmpregoEditarE.Top = 0;
                    //FormFichaSolicitacaoEmpregoEditarE.Left = 0;
                    IdPessoaP = Convert.ToInt32(dataGridViewPesquisaFichas["PESSOA1", e.RowIndex].Value);

                    FormFichaSolicitacaoEmpregoEditar FormFichaSolicitacaoEmpregoEditarF = new FormFichaSolicitacaoEmpregoEditar(IdPessoaP, this.FichaEditar, this.IdLoginUsuario);
                    //CadastraRegistro.MdiParent = this;
                    FormFichaSolicitacaoEmpregoEditarF.ShowDialog();
                    FormFichaSolicitacaoEmpregoEditarF.Top = 200;
                    FormFichaSolicitacaoEmpregoEditarF.Left = 150;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FormPesquisaFichaSolicitacaoEmprego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormPesquisaFichaSolicitacaoEmprego));
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
    }
}
