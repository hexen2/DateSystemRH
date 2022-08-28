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
    public partial class FormPesquisaProcessoSelecao : Form
    {
        DataTable TableTodos;
        DataTable TableMs;
        DataTable TableNomeEmpresa;
        DataTable TableProcesso;
        DataTable TableProfissao;
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
        private int ID_PROFISSAO = 0;
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
        private int PROCESSOSELECAOEDITAR = 0;
        public int ProcessoSelecaoEditar
        {
            get
            {
                return this.PROCESSOSELECAOEDITAR;

            }
            set
            {
                this.PROCESSOSELECAOEDITAR = value;
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
        private int EDITAR_FICHA = 0;
        public int EditarFicha
        {
            get
            {
                return this.EDITAR_FICHA;

            }
            set
            {
                this.EDITAR_FICHA = value;
            }
        }
        public FormPesquisaProcessoSelecao(int IdLoginUsuario, int ProcessoSelecaoVisualizar, int ProcessoSelecaoEditar, int EditarFicha)
        {
            InitializeComponent();
            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";
            txtPesquisaMs.MaxLength = 10;
            txtPesquisaNomeEmpresa.MaxLength = 80;
            txtProcessoSeletivo.MaxLength = 10;

            this.IdLoginUsuario = IdLoginUsuario;
            this.ProcessoSelecaoVisualizar = ProcessoSelecaoVisualizar;
            this.ProcessoSelecaoEditar = ProcessoSelecaoEditar;
            this.EditarFicha = EditarFicha;

            Fill_listBoxProfissao();
        }
        public void AlteraBotoes(int botao)
        {
            if (botao == 1)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = false;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = false;

                txtProcessoSeletivo.Clear();
                txtProcessoSeletivo.Enabled = false;

            }
            if (botao == 2)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = true;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = false;

                txtProcessoSeletivo.Clear();
                txtProcessoSeletivo.Enabled = false;

            }
            if (botao == 3)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = false;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = true;

                txtProcessoSeletivo.Clear();
                txtProcessoSeletivo.Enabled = false;

            }
            if (botao == 4)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = false;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = false;

                txtProcessoSeletivo.Clear();
                txtProcessoSeletivo.Enabled = true;

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
        private void radioButtonProfissaoVaga_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonProfissaoVaga.Checked == true) { comboBoxProfissao.Enabled = true; }else { comboBoxProfissao.Enabled = false; }
            AlteraBotoes(1);
        }
        public void PesquisaProcessoSelecaoTodos()
        {
            int situacao = 0;
            int situacao2 = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            if (checkBoxFinalizado.Checked == true)
            {
                situacao2 = 1;
            }
            if (checkBoxFinalizado.Checked == false)
            {
                situacao2 = 2;
            }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaProcessoSeletivoTodosPSTxt " + situacao + "," + situacao2 + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaProcessoSeletivo.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void PesquisaProcessoSelecaoMs()
        {
            int situacao = 0;
            int situacao2 = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            if (checkBoxFinalizado.Checked == true)
            {
                situacao2 = 1;
            }
            if (checkBoxFinalizado.Checked == false)
            {
                situacao2 = 2;
            }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaProcessoSeletivoMsPSTxt '" + txtPesquisaMs.Text + "'," + situacao + "," + situacao2 + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableMs = new DataTable();
                adapter.Fill(TableMs);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableMs;
                dataGridViewPesquisaProcessoSeletivo.DataSource = Source;
                adapter.Update(TableMs);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void PesquisaProcessoSelecaoNome()
        {
            int situacao = 0;
            int situacao2 = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            if (checkBoxFinalizado.Checked == true)
            {
                situacao2 = 1;
            }
            if (checkBoxFinalizado.Checked == false)
            {
                situacao2 = 2;
            }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaProcessoSeletivoNomePSTxt '" + txtPesquisaNomeEmpresa.Text + "'," + situacao + "," + situacao2 + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomeEmpresa = new DataTable();
                adapter.Fill(TableNomeEmpresa);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomeEmpresa;
                dataGridViewPesquisaProcessoSeletivo.DataSource = Source;
                adapter.Update(TableNomeEmpresa);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void PesquisaProcessoSelecaoPS()
        {
            int situacao = 0;
            int situacao2 = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            if (checkBoxFinalizado.Checked == true)
            {
                situacao2 = 1;
            }
            if (checkBoxFinalizado.Checked == false)
            {
                situacao2 = 2;
            }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaProcessoSeletivoPSTxt " + txtProcessoSeletivo.Text + "," + situacao + "," + situacao2 + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableProcesso = new DataTable();
                adapter.Fill(TableProcesso);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableProcesso;
                dataGridViewPesquisaProcessoSeletivo.DataSource = Source;
                adapter.Update(TableProcesso);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void PesquisaProcessoSelecaoProfissao()
        {
            int situacao = 0;
            int situacao2 = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            if (checkBoxFinalizado.Checked == true)
            {
                situacao2 = 1;
            }
            if (checkBoxFinalizado.Checked == false)
            {
                situacao2 = 2;
            }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaProcessoSeletivoPofissaoTxt " + this.IdProfissao + "," + situacao + "," + situacao2 + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableProfissao = new DataTable();
                adapter.Fill(TableProfissao);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableProfissao;
                dataGridViewPesquisaProcessoSeletivo.DataSource = Source;
                adapter.Update(TableProfissao);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void LimpaFichasCadastradas(int entrada)
        {
            try
            {
                if (entrada == 0)
                {
                    if (this.dataGridViewPesquisaProcessoSeletivo.DataSource != null)
                    {
                        this.dataGridViewPesquisaProcessoSeletivo.DataSource = null;
                    }
                    else
                    {
                        this.dataGridViewPesquisaProcessoSeletivo.Rows.Clear();

                    }
                }
                if (entrada == 1)
                {
                    dataGridViewPesquisaProcessoSeletivo.ColumnCount = 7;
                    dataGridViewPesquisaProcessoSeletivo.Columns[0].Name = "ID_PROCESSO_SELETIVO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[0].DataPropertyName = "ID_PROCESSO_SELETIVO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[0].Width = 100;
                    dataGridViewPesquisaProcessoSeletivo.Columns[0].HeaderText = "PROCESSO SELETIVO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[1].Name = "MS";
                    dataGridViewPesquisaProcessoSeletivo.Columns[1].DataPropertyName = "MS";
                    dataGridViewPesquisaProcessoSeletivo.Columns[1].Width = 50;
                    dataGridViewPesquisaProcessoSeletivo.Columns[1].HeaderText = "MS";
                    dataGridViewPesquisaProcessoSeletivo.Columns[2].Name = "NOME_EMPRESA";
                    dataGridViewPesquisaProcessoSeletivo.Columns[2].DataPropertyName = "NOME_EMPRESA";
                    dataGridViewPesquisaProcessoSeletivo.Columns[2].Width = 250;
                    dataGridViewPesquisaProcessoSeletivo.Columns[2].HeaderText = "NOME EMPRESA";
                    dataGridViewPesquisaProcessoSeletivo.Columns[3].Name = "NOME_PROFISSAO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[3].DataPropertyName = "NOME_PROFISSAO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[3].Width = 100;
                    dataGridViewPesquisaProcessoSeletivo.Columns[3].HeaderText = "NOME PROFISSÃO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[4].Name = "DATA_CRIACAO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[4].DataPropertyName = "DATA_CRIACAO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[4].Width = 130;
                    dataGridViewPesquisaProcessoSeletivo.Columns[4].HeaderText = "DATA CRIACÃO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[5].Name = "DATA_FECHAMENTO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[5].DataPropertyName = "DATA_FECHAMENTO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[5].Width = 130;
                    dataGridViewPesquisaProcessoSeletivo.Columns[5].HeaderText = "DATA FECHAMENTO";
                    dataGridViewPesquisaProcessoSeletivo.Columns[6].Name = "QUANT_VAGAS";
                    dataGridViewPesquisaProcessoSeletivo.Columns[6].DataPropertyName = "QUANT_VAGAS";
                    dataGridViewPesquisaProcessoSeletivo.Columns[6].Width = 100;
                    dataGridViewPesquisaProcessoSeletivo.Columns[6].HeaderText = "QUANT VAGAS";
                    //dataGridViewPesquisaEmpresas.Columns[5].Visible = false;

                }
            }
            catch (Exception ex) { ex.ToString(); }

        }
        private void buttonPesquisaProcessoSeletivo_Click(object sender, EventArgs e)
        {
            ProcessoSeletivo();
        }
        public void ProcessoSeletivo()
        {
            try
            {
                int situacao = 0;
                int situacao2 = 0;

                if (checkBoxSituacao.Checked == true)
                {
                    situacao = 1;
                }
                if (checkBoxSituacao.Checked == false)
                {
                    situacao = 2;
                }
                if (checkBoxFinalizado.Checked == true)
                {
                    situacao2 = 1;
                }
                if (checkBoxFinalizado.Checked == false)
                {
                    situacao2 = 2;
                }
                LimpaFichasCadastradas(0);
                LimpaFichasCadastradas(1);
                SqlConnection conn = new SqlConnection(this.connetionString);
                if (!(radioButtonTodos.Checked == true) && !(radioButtonPesquisarNome.Checked == true) && !(radioButtonPesquisarMS.Checked == true)
                    && !(radioButtonProcesso.Checked == true) && !(radioButtonProfissaoVaga.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, Todos, MS, NOME, PROCESSO  OU PROFISSÃO! ");
                }
                if (radioButtonTodos.Checked == true)
                {
                    dataGridViewPesquisaProcessoSeletivo.Refresh();
                    label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaProcessoSeletivoTodosPSTxt " + situacao + "," + situacao2 + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaProcessoSeletivo.DataSource == null)
                        {
                            dataGridViewPesquisaProcessoSeletivo.Refresh();
                        }
                        if (!(dataGridViewPesquisaProcessoSeletivo.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaProcessoSeletivo.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                        MessageBox.Show("Nem uma Processo de seleção foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 1;
                        PesquisaProcessoSelecaoTodos();
                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                    }
                }
                if (radioButtonPesquisarMS.Checked == true)
                {
                    if (txtPesquisaMs.Text == "")
                    {
                        dataGridViewPesquisaProcessoSeletivo.Refresh();
                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString(); ;

                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                        MessageBox.Show("O MS não pode esta em Branco!");
                    }
                    if (!(txtPesquisaMs.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaProcessoSeletivoMsPSTxt '" + txtPesquisaMs.Text + "',"  + situacao + "," + situacao2 + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaProcessoSeletivo.DataSource == null)
                            {
                                dataGridViewPesquisaProcessoSeletivo.Refresh();
                            }
                            if (!(dataGridViewPesquisaProcessoSeletivo.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaProcessoSeletivo.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                            MessageBox.Show("Nem uma Processo de seleção foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 2;
                            PesquisaProcessoSelecaoMs();
                            label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                        }
                    }
                }
                if (radioButtonPesquisarNome.Checked == true)
                {
                    if (txtPesquisaNomeEmpresa.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaProcessoSeletivo.Refresh();

                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                        MessageBox.Show("O Nome não pode esta em Branco!");
                    }
                    if (!(txtPesquisaNomeEmpresa.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaProcessoSeletivoNomePSTxt '" + txtPesquisaNomeEmpresa.Text + "'," + situacao + "," + situacao2 + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaProcessoSeletivo.DataSource == null)
                            {
                                dataGridViewPesquisaProcessoSeletivo.Refresh();
                            }
                            if (!(dataGridViewPesquisaProcessoSeletivo.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaProcessoSeletivo.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                            MessageBox.Show("Nem uma Processo de seleção foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 3;
                            PesquisaProcessoSelecaoNome();
                            label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                        }
                    }
                }
                if (radioButtonProcesso.Checked == true)
                {
                    if (txtProcessoSeletivo.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaProcessoSeletivo.Refresh();

                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                        MessageBox.Show("Processo não pode esta em Branco!");
                    }
                    if (!(txtProcessoSeletivo.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaProcessoSeletivoPSTxt " + txtProcessoSeletivo.Text + "," + situacao + "," + situacao2 + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaProcessoSeletivo.DataSource == null)
                            {
                                dataGridViewPesquisaProcessoSeletivo.Refresh();
                            }
                            if (!(dataGridViewPesquisaProcessoSeletivo.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaProcessoSeletivo.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                            MessageBox.Show("Nem uma Processo de seleção foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 4;
                            PesquisaProcessoSelecaoPS();
                            label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                        }

                    }
                }
                if (radioButtonProfissaoVaga.Checked == true)
                {
                    // dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaProcessoSeletivo.Refresh();

                    label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();


                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaProcessoSeletivoPofissaoTxt " + this.IdProfissao + "," + situacao + "," + situacao2 + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaProcessoSeletivo.DataSource == null)
                        {
                            dataGridViewPesquisaProcessoSeletivo.Refresh();
                        }
                        if (!(dataGridViewPesquisaProcessoSeletivo.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaProcessoSeletivo.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();

                        MessageBox.Show("Nem uma Processo de seleção foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 5;
                        PesquisaProcessoSelecaoProfissao();
                        label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                    }
                }
            }
            catch (Exception e) { e.ToString(); }
        }

        private void FormPesquisaProcessoSelecao_Load(object sender, EventArgs e)
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
        private void txtPesquisaMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ProcessoSeletivo(); 
            }
        }

        private void txtProcessoSeletivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ProcessoSeletivo();
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(1);
        }

        private void radioButtonPesquisarMS_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(2);
        }

        private void radioButtonPesquisarNome_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(3);
        }

        private void radioButtonProcesso_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(4);
        }

        private void FormPesquisaProcessoSelecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void dataGridViewPesquisaProcessoSeletivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.ProcessoSelecaoVisualizar == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (this.ProcessoSelecaoVisualizar == 1)
                {
                    //FecharTodosFormulario();
                    int IdProcessoSeletivo = Convert.ToInt32(dataGridViewPesquisaProcessoSeletivo["ID_PROCESSO_SELETIVO", e.RowIndex].Value);
                    //this.IdPessoaP.ToString();
                    //MessageBox.Show(this.IdPessoaP.ToString());
                    FormProcessoSelecaoEditar FormProcessoSelecaoEditarP = new FormProcessoSelecaoEditar(IdProcessoSeletivo, this.ProcessoSelecaoEditar,this.IdLoginUsuario, this.EditarFicha);
                    FormProcessoSelecaoEditarP.ShowDialog();
                    FormProcessoSelecaoEditarP.Top = 200;
                    FormProcessoSelecaoEditarP.Left = 150;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtPesquisaMs_TextChanged(object sender, EventArgs e)
        {
            try
            {             
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableMs);
                    DV.RowFilter = string.Format("MS LIKE '%{0}%'", txtPesquisaMs.Text);
                    dataGridViewPesquisaProcessoSeletivo.DataSource = DV;
                    label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                }
            }
            catch
            {

            }
        }

        private void txtPesquisaNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableNomeEmpresa);
                    DV.RowFilter = string.Format("NOME_EMPRESA LIKE '%{0}%'", txtPesquisaNomeEmpresa.Text);
                    dataGridViewPesquisaProcessoSeletivo.DataSource = DV;
                    label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                }
            }
            catch
            {

            }
        }

        private void txtProcessoSeletivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableProcesso);
                    DV.RowFilter = string.Format("ID_PROCESSO_SELETIVO LIKE '%{0}%'", txtProcessoSeletivo.Text);
                    dataGridViewPesquisaProcessoSeletivo.DataSource = DV;
                    label8.Text = dataGridViewPesquisaProcessoSeletivo.RowCount.ToString();
                }
            }
            catch
            {

            }
        }

        private void txtPesquisaNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ProcessoSeletivo();
            }
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
    }
}
