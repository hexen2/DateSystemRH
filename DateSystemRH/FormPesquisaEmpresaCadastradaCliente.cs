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
    public partial class FormPesquisaEmpresaCadastradaCliente : Form
    {
        DataTable TableTodos;
        DataTable TableMs;
        DataTable TableNomeEmpresa;

        private int ID_EMPRESA_CLIENTE = 0;
        public int IdEmpresaCliente
        {
            get
            {
                return this.ID_EMPRESA_CLIENTE;

            }
            set
            {
                this.ID_EMPRESA_CLIENTE = value;
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
        private int EMPRESAVISUALIZAR = 0;
        public int EmpresaVializar
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
        private int EMPRESAEDITAR= 0;
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
        public FormPesquisaEmpresaCadastradaCliente(int EmpresaVisualizar, int EmpresaEditar)
        {
            InitializeComponent();
            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

            //this.IdLoginUsuario = IdLoginUsuario;
            this.EmpresaVializar = EmpresaVisualizar;
            this.EmpresaEditar = EmpresaEditar;
        }

        private void txtPesquisaRG_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormPesquisaEmpresaCadastradaCliente_Load(object sender, EventArgs e)
        {

        }

        public void PesquisaEmpresa()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true) { situacao = 1; }
            if (checkBoxSituacao.Checked == false) { situacao = 2; }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaEmpresasClienteTodosTxt " + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaEmpresas.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
        }
        void dataGridViewPesquisaMs()
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
            SqlCommand command = new SqlCommand("Exec RH_ConsultaEmpresasClienteMsTxt '" + txtPesquisaMs.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableMs = new DataTable();
                adapter.Fill(TableMs);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableMs;
                dataGridViewPesquisaEmpresas.DataSource = Source;
                adapter.Update(TableMs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
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
            SqlCommand command = new SqlCommand("Exec RH_ConsultaEmpresasClienteNomeEmpresaTxt '" + txtPesquisaNomeEmpresa.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomeEmpresa = new DataTable();
                adapter.Fill(TableNomeEmpresa);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomeEmpresa;
                dataGridViewPesquisaEmpresas.DataSource = Source;
                adapter.Update(TableNomeEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }

            //DataTable dt = new DataTable();
        }
        private void buttonPesquisaEmpresa_Click(object sender, EventArgs e)
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
                if (!(radioButtonTodos.Checked == true) && !(radioButtonPesquisarNome.Checked == true) && !(radioButtonPesquisarMS.Checked == true)
                    && !(radioButtonPesquisarNome.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, Todos, MS e NOME EMPRESA! ");
                }
                if (radioButtonTodos.Checked == true)
                {                 
                    dataGridViewPesquisaEmpresas.Refresh();
                    label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString(); ;

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaEmpresasClienteTodosTxt " + situacao + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaEmpresas.DataSource == null)
                        {
                            dataGridViewPesquisaEmpresas.Refresh();
                        }
                        if (!(dataGridViewPesquisaEmpresas.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaEmpresas.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();

                        MessageBox.Show("Nem uma empresa foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 1;
                        PesquisaEmpresa();
                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                    }
                }
                if (radioButtonPesquisarMS.Checked == true)
                {
                    if (txtPesquisaMs.Text == "")
                    {
                        dataGridViewPesquisaEmpresas.Refresh();
                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString(); ;

                        MessageBox.Show("O MS não pode esta em Branco!");
                    }
                    if (!(txtPesquisaMs.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaEmpresasClienteMsTxt '" + txtPesquisaMs.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaEmpresas.DataSource == null)
                            {
                                dataGridViewPesquisaEmpresas.Refresh();
                            }
                            if (!(dataGridViewPesquisaEmpresas.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaEmpresas.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();

                            MessageBox.Show("Nem uma MS foi encontrado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 2;
                            dataGridViewPesquisaMs();
                            label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                        }
                    }
                }
                if (radioButtonPesquisarNome.Checked == true)
                {
                    if (txtPesquisaNomeEmpresa.Text == "")
                    {
                        dataGridViewPesquisaEmpresas.Refresh();
                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString(); ;

                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();

                        MessageBox.Show("O Nome não pode esta em Branco!");
                    }
                    if (!(txtPesquisaNomeEmpresa.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC  RH_ConsultaEmpresasClienteNomeEmpresaTxt '" + txtPesquisaNomeEmpresa.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                            if (!(ds1.Tables[0].Rows.Count > 0))
                            {
                                if (dataGridViewPesquisaEmpresas.DataSource == null)
                                {
                                    dataGridViewPesquisaEmpresas.Refresh();
                                }
                                if (!(dataGridViewPesquisaEmpresas.DataSource == null))
                                {
                                    // dataGridViewPesquisaCliente.Columns.Clear();
                                    dataGridViewPesquisaEmpresas.Refresh();
                                }
                                label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();

                                MessageBox.Show("Nem uma empresa foi encontrado!");
                                conn.Close();
                            }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 3;
                            dataGridViewPesquisaNome();
                            label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                        }
                    }
                }
            }
            catch (Exception e) { MessageBox.Show("Error:" + e.ToString()); }
        }

        public void LimpaFichasCadastradas(int entrada)
        {
            try
            {
                if (entrada == 0)
                {
                    if (this.dataGridViewPesquisaEmpresas.DataSource != null)
                    {
                        this.dataGridViewPesquisaEmpresas.DataSource = null;
                    }
                    else
                    {
                        this.dataGridViewPesquisaEmpresas.Rows.Clear();

                    }
                }
                if (entrada == 1)
                {
                    dataGridViewPesquisaEmpresas.ColumnCount = 6;
                    dataGridViewPesquisaEmpresas.Columns[0].Name = "ID_EMPRESA";
                    dataGridViewPesquisaEmpresas.Columns[0].DataPropertyName = "REGISTRO";
                    dataGridViewPesquisaEmpresas.Columns[0].Width = 100;
                    dataGridViewPesquisaEmpresas.Columns[0].HeaderText = "REGISTRO";
                    dataGridViewPesquisaEmpresas.Columns[1].Name = "NOME_EMPRESA";
                    dataGridViewPesquisaEmpresas.Columns[1].DataPropertyName = "NOME_EMPRESA";
                    dataGridViewPesquisaEmpresas.Columns[1].Width = 250;
                    dataGridViewPesquisaEmpresas.Columns[1].HeaderText = "NOME EMPRESA";
                    dataGridViewPesquisaEmpresas.Columns[2].Name = "ENDERECO";
                    dataGridViewPesquisaEmpresas.Columns[2].DataPropertyName = "ENDERECO";
                    dataGridViewPesquisaEmpresas.Columns[2].Width = 130;
                    dataGridViewPesquisaEmpresas.Columns[2].HeaderText = "ENDERECO";
                    dataGridViewPesquisaEmpresas.Columns[3].Name = "MS";
                    dataGridViewPesquisaEmpresas.Columns[3].DataPropertyName = "MS";
                    dataGridViewPesquisaEmpresas.Columns[3].Width = 100;
                    dataGridViewPesquisaEmpresas.Columns[3].HeaderText = "MS";
                    dataGridViewPesquisaEmpresas.Columns[4].Name = "STATUS_ATIVO";
                    dataGridViewPesquisaEmpresas.Columns[4].DataPropertyName = "STATUS_ATIVO";
                    dataGridViewPesquisaEmpresas.Columns[4].Width = 100;
                    dataGridViewPesquisaEmpresas.Columns[4].HeaderText = "STATUS ATIVO";
                    dataGridViewPesquisaEmpresas.Columns[5].Name = "COMENTARIO";
                    dataGridViewPesquisaEmpresas.Columns[5].DataPropertyName = "COMENTARIO";
                    dataGridViewPesquisaEmpresas.Columns[5].Width = 150;
                    dataGridViewPesquisaEmpresas.Columns[5].HeaderText = "COMETARIO";
                    //dataGridViewPesquisaEmpresas.Columns[5].Visible = false;

                }
            }
            catch (Exception ex) { ex.ToString(); }

        }
        private void FormPesquisaEmpresaCadastradaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtPesquisaMs_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 2)
            {
                DataView DV = new DataView(TableMs);
                DV.RowFilter = string.Format("MS LIKE '%{0}%'", txtPesquisaMs.Text);
                dataGridViewPesquisaEmpresas.DataSource = DV;
                label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
            }

        }
        private void txtPesquisaNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 3)
            {
                DataView DV = new DataView(TableNomeEmpresa);
                DV.RowFilter = string.Format("NOME_EMPRESA LIKE '%{0}%'", txtPesquisaNomeEmpresa.Text);
                dataGridViewPesquisaEmpresas.DataSource = DV;
                label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
            }
        }
        public void AlteraBotoes(int botao)
        {
            if (botao == 1)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = false;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = false;

            }
            if (botao == 2)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = true;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = false;
              
            }
            if (botao == 3)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = false;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = true;
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

        private void dataGridViewPesquisaEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (EmpresaVializar == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (EmpresaVializar == 1)
                {
                    IdEmpresaCliente = Convert.ToInt32(dataGridViewPesquisaEmpresas["ID_EMPRESA", e.RowIndex].Value);

                    FormEmpresaClienteEditar FormEmpresaClienteEditarE = new FormEmpresaClienteEditar(this.EmpresaEditar, this.IdEmpresaCliente);
                    //FormEmpresaClienteEditarE.MdiParent = FormEmpresaClienteEditar.ActiveForm;
                    FormEmpresaClienteEditarE.ShowDialog();
                    FormEmpresaClienteEditarE.Top = 200;
                    FormEmpresaClienteEditarE.Left = 150;
                }
            }
            catch(Exception ex) { MessageBox.Show("Error:" + ex.ToString()); }
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormPesquisaEmpresaCadastradaCliente));
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

        private void txtPesquisaNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Busca();
            }
        }
    }
}
