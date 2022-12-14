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
    public partial class FormProcessoSelecao : Form
    {
        DataTable TableTodos;
        DataTable TableMs;
        DataTable TableNomeEmpresa;

        DataTable TableTodosFichas;
        DataTable TableRg;
        DataTable TableCpf;
        DataTable TableNomePessoa;

        private int ID_FICHA = 0;
        public int IdFicha
        {
            get
            {
                return this.ID_FICHA;

            }
            set
            {
                this.ID_FICHA = value;
            }
        }
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
        private int QUANT_PROCESSO_SELETIVO = 0;
        public int QuantProcessoSeletivo
        {
            get
            {
                return this.QUANT_PROCESSO_SELETIVO;

            }
            set
            {
                this.QUANT_PROCESSO_SELETIVO = value;
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
        private int ID_TEMP_PROFISSAO;
        public int IdTempProfissao
        {
            get
            {
                return this.ID_TEMP_PROFISSAO;

            }
            set
            {
                this.ID_TEMP_PROFISSAO = value;
            }
        }
        private string NOME_TEMP_PROFISSAO;
        public string NomeTempProfissao
        {
            get
            {
                return this.NOME_TEMP_PROFISSAO;

            }
            set
            {
                this.NOME_TEMP_PROFISSAO = value;
            }
        }
        private int ID_PROFISSAO_CONTADOR;
        public int IdTProfissaoContador
        {
            get
            {
                return this.ID_PROFISSAO_CONTADOR;

            }
            set
            {
                this.ID_PROFISSAO_CONTADOR = value;
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
        private int SELECIONAR = 0;
        public int Selecionar
        {
            get
            {
                return this.SELECIONAR;

            }
            set
            {
                this.SELECIONAR = value;
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
        private Boolean validaNomeEmpresa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeEmpresa.Text))
            {
                errorProviderPS.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderPS.SetError(textBox, "Nome Empresa em branco!");
                return false;
            }

        }
        private Boolean validaVagas(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtQuantVagas.Text))
            {
                errorProviderPS.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderPS.SetError(textBox, "QuantVagas em branco!");
                return false;
            }

        }
        //public FormProcessoSelecao()
        //{
        //    try
        //    {
        //        InitializeComponent();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        public FormProcessoSelecao(int IdLoginUsuario, int EditarFicha)
        {
            try
            {
                InitializeComponent();

                this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

                this.IdLoginUsuario = IdLoginUsuario;
                this.FichaEditar = EditarFicha;
                this.dateTimePickerCriacaoProcesso.Value = DateTime.Now.Date;
                this.dateTimePickerFechamentodoProcesso.Value = DateTime.Now.Date;
                SqlConnection conn = new SqlConnection(this.connetionString);

                txtPesquisaMs.MaxLength = 10;
                txtPesquisaNomeEmpresa.MaxLength = 80;

                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(ID_PROCESSO_SELETIVO) FROM P_ProcessoSeletivo ; ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Fill_listBoxTodasEstabilidade();
                Fill_listBoxProfissao();

                if (!(ds.Tables[0].Rows.Count > 0))
                {
                    QuantProcessoSeletivo = 1;
                    txtNumeroProcessoSeletivo.Text = " N° " + QuantProcessoSeletivo.ToString();
                    conn.Close();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int soma = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    QuantProcessoSeletivo = 1 + soma;
                    txtNumeroProcessoSeletivo.Text = " N° " + QuantProcessoSeletivo.ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FormProcessoSelecao_KeyPress(object sender, KeyPressEventArgs e)
        {      
            if (e.KeyChar == 27)
            {
                FecharTodosFormulario();
            }
        }
        public void PesquisaEmpresa()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC RH_ConsultaEmpresasClienteTodosPSTxt " + 1 + ";", connection);
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
               MessageBox.Show( ex.ToString());
            }
        }
        void dataGridViewPesquisaMs()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec RH_ConsultaEmpresasClienteMsPSTxt '" + txtPesquisaMs.Text + "'," + 1 + ";", connection);
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
              MessageBox.Show(  ex.ToString());
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaNome()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("Exec RH_ConsultaEmpresasClienteNomeEmpresaPSTxt '" + txtPesquisaNomeEmpresa.Text + "'," + 1 + ";", connection);
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
                MessageBox.Show(ex.ToString());
            }

            //DataTable dt = new DataTable();
        }

        private void txtPesquisaRG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableRg);
                    DV.RowFilter = string.Format("RG_P LIKE '%{0}%'", txtPesquisaRG.Text);
                    dataGridViewFichasCadastrada.DataSource = DV;
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 3)
                {
                    DataView DV = new DataView(TableCpf);
                    DV.RowFilter = string.Format("CPF_P LIKE '%{0}%'", txtCpf.Text);
                    dataGridViewFichasCadastrada.DataSource = DV;
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtPesquisaNomePessoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 4)
                {
                    DataView DV = new DataView(TableNomePessoa);
                    DV.RowFilter = string.Format("NOME_P LIKE '%{0}%'", txtPesquisaNomePessoa.Text);
                    dataGridViewFichasCadastrada.DataSource = DV;
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //FICHAS CADASTRADAS
        public void PesquisaTodosFichasPS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoTodosPSTxt " + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                            + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodosFichas = new DataTable();
                adapter.Fill(TableTodosFichas);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodosFichas;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableTodosFichas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void PesquisaRgPS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoRgPSTxt '" + txtPesquisaRG.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableRg = new DataTable();
                adapter.Fill(TableRg);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableRg;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableRg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void PesquisaCpfPS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoCpfPSTxt '" + txtCpf.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCpf = new DataTable();
                adapter.Fill(TableCpf);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCpf;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableCpf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void PesquisaNomePS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoNomePSTxt '" + txtPesquisaNomePessoa.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomePessoa = new DataTable();
                adapter.Fill(TableNomePessoa);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomePessoa;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableNomePessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonPesquisaEmpresa_Click(object sender, EventArgs e)
        {
            BuscaEmpresa();
        }
        public void BuscaEmpresa()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);
                if (!(radioButtonTodos.Checked == true) && !(radioButtonPesquisarNome.Checked == true) && !(radioButtonPesquisarMS.Checked == true)
                    && !(radioButtonPesquisarNome.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, Todos, MS e NOME EMPRESA! ");
                }
                if (radioButtonTodos.Checked == true)
                {

                    // dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaEmpresas.Refresh();

                    label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();


                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaEmpresasClienteTodosPSTxt " + 1 + ";", conn);
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
                        ValorPesquisa = 5;
                        MessageBox.Show("Nem uma empresa foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 5;
                        PesquisaEmpresa();
                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                    }
                }
                if (radioButtonPesquisarMS.Checked == true)
                {
                    if (txtPesquisaMs.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaEmpresas.Refresh();

                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();

                        MessageBox.Show("O MS não pode esta em Branco!");
                    }
                    if (!(txtPesquisaMs.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC RH_ConsultaEmpresasClienteMsPSTxt '" + txtPesquisaMs.Text + "'," + 1 + ";", conn);
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
                                //dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaEmpresas.Refresh();
                            }
                            label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                            MessageBox.Show("Nem uma Ms foi encontrado!");
                            ValorPesquisa = 6;
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            ValorPesquisa = 6;
                            dataGridViewPesquisaMs();
                            label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                        }
                    }
                }
                if (radioButtonPesquisarNome.Checked == true)
                {
                    if (txtPesquisaNomeEmpresa.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaEmpresas.Refresh();

                        label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                        MessageBox.Show("O Nome não pode esta em Branco!");
                        
                    }
                    if (!(txtPesquisaNomeEmpresa.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC  RH_ConsultaEmpresasClienteNomeEmpresaPSTxt '" + txtPesquisaNomeEmpresa.Text + "'," + 1 + ";", conn);
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
                            MessageBox.Show("Nem um Nome foi encontrado!!");
                            ValorPesquisa = 7;
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 7;
                            dataGridViewPesquisaNome();
                            label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void txtPesquisaMs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 6)
                {
                    DataView DV = new DataView(TableMs);
                    DV.RowFilter = string.Format("MS LIKE '%{0}%'", txtPesquisaMs.Text);
                    dataGridViewPesquisaEmpresas.DataSource = DV;
                    label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                }
            }
            catch (Exception)
            {

            }

        }

        private void txtPesquisaNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 7)
                {
                    DataView DV = new DataView(TableNomeEmpresa);
                    DV.RowFilter = string.Format("NOME_EMPRESA LIKE '%{0}%'", txtPesquisaNomeEmpresa.Text);
                    dataGridViewPesquisaEmpresas.DataSource = DV;
                    label8.Text = dataGridViewPesquisaEmpresas.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

                //ValorPesquisa = 1;
            }
            if (botao == 2)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = true;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = false;

               // ValorPesquisa = 2;

            }
            if (botao == 3)
            {
                txtPesquisaMs.Clear();
                txtPesquisaMs.Enabled = false;

                txtPesquisaNomeEmpresa.Clear();
                txtPesquisaNomeEmpresa.Enabled = true;

               // ValorPesquisa = 3;
            }
        }
        public void AlteraBotoes2(int botao)
        {
            if (botao == 1)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = false;

                txtCpf.Clear();
                txtCpf.Enabled = false;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = false;
              //  ValorPesquisa = 1;
            }
            if (botao == 2)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = true;

                txtCpf.Clear();
                txtCpf.Enabled = false;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = false;
               // ValorPesquisa = 2;
            }
            if (botao == 3)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = false;

                txtCpf.Clear();
                txtCpf.Enabled = true;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = false;
             //   ValorPesquisa = 3;
            }
            if (botao == 4)
            {
                txtPesquisaRG.Clear();
                txtPesquisaRG.Enabled = false;

                txtCpf.Clear();
                txtCpf.Enabled = false;

                txtPesquisaNomePessoa.Clear();
                txtPesquisaNomePessoa.Enabled = true;
              //  ValorPesquisa = 4;
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
        private void FormProcessoSelecao_Load(object sender, EventArgs e)
        {

        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormFotoFicha));
            FechatodosFormularios(typeof(FormProcessoSelecao));

        }
        public void FecharTodosFormulario2()
        {
            FechatodosFormularios(typeof(FormFotoFicha));
        }


        public static void FechatodosFormularios(Type frmType)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            try
            {
                   
                if (dataGridViewClassificados.RowCount == 0)
                {
                    LimpaFichasCadastradas(0);
                    LimpaFichasCadastradas(1);

                    SqlConnection connection = new SqlConnection(this.connetionString);
                    connection.Open();
                    string Query = " SELECT ID_PROFISSAO, NOME_PROFISSAO FROM P_Profissao WHERE NOME_PROFISSAO = '" + this.comboBoxProfissao.Text + "';";

                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        this.IdProfissao = dr.GetInt32(0);
                        comboBoxProfissao.Text = dr.GetString(1);
                        this.IdTempProfissao = this.IdProfissao;
                        this.NomeTempProfissao = dr.GetString(1);                      
                    }
                    connection.Close();                  
                }

                if(dataGridViewClassificados.RowCount != 0)
                {
                    SqlConnection connection = new SqlConnection(this.connetionString);
                    connection.Open();
                    string Query = " SELECT ID_PROFISSAO, NOME_PROFISSAO FROM P_Profissao WHERE NOME_PROFISSAO = '" + this.comboBoxProfissao.Text + "';";

                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        if ((this.IdTempProfissao != dr.GetInt32(0)) && (dataGridViewClassificados.RowCount != 0))
                        {

                            DialogResult dialogResult = MessageBox.Show("Deseja troca de profissão  " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                LimpaFichasCadastradas(0);
                                LimpaFichasCadastradas(1);
                                LimpaFichasCadastradas(2);
                                LimpaFichasCadastradas(3);

                                this.IdProfissao = dr.GetInt32(0);
                                comboBoxProfissao.Text = dr.GetString(1);
                                this.IdTempProfissao = dr.GetInt32(0);
                                this.NomeTempProfissao = dr.GetString(1);

                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.IdProfissao = IdTempProfissao;
                                comboBoxProfissao.Text = this.NomeTempProfissao;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TrocaFichasCadastradaEClassificados()
        {

        }
        private void dataGridViewPesquisaEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                this.IdEmpresaCliente = Convert.ToInt32(dataGridViewPesquisaEmpresas["ID_EMPRESA", e.RowIndex].Value);

                Console.WriteLine(this.IdEmpresaCliente);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Empresa WHERE ID_EMPRESA = " + IdEmpresaCliente + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    if (IdEmpresaCliente != 0)
                    {
                        txtNomeEmpresa.Text = ds1.Tables[0].Rows[0][1].ToString();
                        txtMsEmpresa.Text = ds1.Tables[0].Rows[0][3].ToString();
                        Console.WriteLine(this.IdEmpresaCliente);
                    }
                    if (IdEmpresaCliente == 0)
                    {

                    }
                }
                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    MessageBox.Show("A Empresa não consta no sistema!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        private void checkBoxAtivaVerifcacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAtivaVerifcacao.Checked == false)
            {
                checkBoxCMA.Checked = false;
                checkBoxCMB.Checked = false;
                checkBoxCMC.Checked = false;
                checkBoxCMD.Checked = false;
            }
        }

        private void checkBoxCMA_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxCMA.Checked == false) && (checkBoxCMB.Checked == false) && (checkBoxCMC.Checked == false) && (checkBoxCMD.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = false;
            }
            if ((checkBoxCMA.Checked == true) && (checkBoxAtivaVerifcacao.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = true;
            }
        }

        private void checkBoxCMB_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxCMA.Checked == false) && (checkBoxCMB.Checked == false) && (checkBoxCMC.Checked == false) && (checkBoxCMD.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = false;
            }
            if ((checkBoxCMB.Checked == true) && (checkBoxAtivaVerifcacao.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = true;
            }
        }

        private void checkBoxCMC_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxCMA.Checked == false) && (checkBoxCMB.Checked == false) && (checkBoxCMC.Checked == false) && (checkBoxCMD.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = false;
            }
            if ((checkBoxCMC.Checked == true) && (checkBoxAtivaVerifcacao.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = true;
            }
        }

        private void checkBoxCMD_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxCMA.Checked == false) && (checkBoxCMB.Checked == false) && (checkBoxCMC.Checked == false) && (checkBoxCMD.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = false;
            }
            if ((checkBoxCMD.Checked == true) && (checkBoxAtivaVerifcacao.Checked == false))
            {
                checkBoxAtivaVerifcacao.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes2(1);
        }

        private void radioButtonPesquisarRG_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes2(2);
        }

        private void radioButtonCpf_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes2(3);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes2(4);
        }
        public void LimpaFichasCadastradas(int entrada)
        {
            //string[] row = new string[] { "", "", " ", "", "","","","", "", "", "" };
            //dataGridViewFichasCadastrada.Rows.Add(row);
            //dataGridViewFichasCadastrada.Rows.Add();

            try
            {
                if (entrada == 0)
                {
                    if (this.dataGridViewFichasCadastrada.DataSource != null)
                    {
                        this.dataGridViewFichasCadastrada.DataSource = null;
                    }
                    else
                    {
                        this.dataGridViewFichasCadastrada.Rows.Clear();

                    }
                }
                if (entrada == 1)
                {
                    dataGridViewFichasCadastrada.ColumnCount = 11;
                    dataGridViewFichasCadastrada.Columns[0].Name = "REGISTRO";
                    dataGridViewFichasCadastrada.Columns[0].DataPropertyName = "ID_REGISTRO_P";
                    dataGridViewFichasCadastrada.Columns[0].Width = 100;
                    dataGridViewFichasCadastrada.Columns[1].Name = "NOME_PESSOA";
                    dataGridViewFichasCadastrada.Columns[1].DataPropertyName = "NOME_P";
                    dataGridViewFichasCadastrada.Columns[1].Width = 160;
                    dataGridViewFichasCadastrada.Columns[2].Name = "NOME PROFISSÃO";
                    dataGridViewFichasCadastrada.Columns[2].DataPropertyName = "NOME_PROFISSAO_P";
                    dataGridViewFichasCadastrada.Columns[2].Width = 100;
                    dataGridViewFichasCadastrada.Columns[3].Name = "NOME REGIÃO";
                    dataGridViewFichasCadastrada.Columns[3].DataPropertyName = "NOME_REGIAO_P";
                    dataGridViewFichasCadastrada.Columns[3].Width = 100;
                    dataGridViewFichasCadastrada.Columns[4].Name = "NOME ESTABILIDADE";
                    dataGridViewFichasCadastrada.Columns[4].DataPropertyName = "NOME_ESTABILIDADE_P";
                    dataGridViewFichasCadastrada.Columns[4].Width = 100;
                    dataGridViewFichasCadastrada.Columns[5].Name = "CARTEIRA A";
                    dataGridViewFichasCadastrada.Columns[5].DataPropertyName = "CARTEIRA_A_P";
                    dataGridViewFichasCadastrada.Columns[5].Visible = false;
                    dataGridViewFichasCadastrada.Columns[6].Name = "CARTEIRA B";
                    dataGridViewFichasCadastrada.Columns[6].DataPropertyName = "CARTEIRA_B_P";
                    dataGridViewFichasCadastrada.Columns[6].Visible = false;
                    dataGridViewFichasCadastrada.Columns[7].Name = "CARTEIRA C";
                    dataGridViewFichasCadastrada.Columns[7].DataPropertyName = "CARTEIRA_C_P";
                    dataGridViewFichasCadastrada.Columns[7].Visible = false;
                    dataGridViewFichasCadastrada.Columns[8].Name = "CARTEIRA D";
                    dataGridViewFichasCadastrada.Columns[8].DataPropertyName = "CARTEIRA_D_P";
                    dataGridViewFichasCadastrada.Columns[8].Visible = false;
                    dataGridViewFichasCadastrada.Columns[9].Name = "CPF";
                    dataGridViewFichasCadastrada.Columns[9].DataPropertyName = "CPF_P";
                    dataGridViewFichasCadastrada.Columns[9].Width = 100;
                    dataGridViewFichasCadastrada.Columns[10].Name = "RG";
                    dataGridViewFichasCadastrada.Columns[10].DataPropertyName = "RG_P";
                    dataGridViewFichasCadastrada.Columns[10].Width = 100;
                }
                if (entrada == 2)
                {
                    if (this.dataGridViewClassificados.DataSource != null)
                    {
                        this.dataGridViewClassificados.DataSource = null;
                    }
                    else
                    {
                        this.dataGridViewClassificados.Rows.Clear();

                    }
                }
                if (entrada == 3)
                {
                    dataGridViewClassificados.ColumnCount = 2;
                    dataGridViewClassificados.Columns[0].Name = "ID_CLASSIFICACAO";
                    dataGridViewClassificados.Columns[0].HeaderText = "REGISTRO";
                    dataGridViewClassificados.Columns[0].Width = 70;
                    dataGridViewClassificados.Columns[1].Name = "NOME_CLASSIFICACAO";
                    dataGridViewClassificados.Columns[1].HeaderText = "NOME";
                    dataGridViewClassificados.Columns[1].Width = 135;

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
           
        }
        private void buttonPesquisaFicha_Click(object sender, EventArgs e)
        {
            if(this.IdProfissao == 0)
            {
                MessageBox.Show("Selecione profissão para vaga!");
            }
            else
            {
                BuscaFichaEmprego();
            }
        }
        public void BuscaFichaEmprego()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection conn = new SqlConnection(this.connetionString);

                if (radioButtonFichasTodos.Checked == true)
                {
                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoTodosPSTxt " + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        ValorPesquisa = 1;
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 1;
                        PesquisaTodosFichasPS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if (radioButtonPesquisarRG.Checked == true)
                {

                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoRgPSTxt '" + txtPesquisaRG.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        ValorPesquisa = 2;
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 2;
                        PesquisaRgPS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if (radioButtonCpf.Checked == true)
                {

                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoRgPSTxt '" + txtCpf.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        ValorPesquisa = 3;
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 3;
                        PesquisaCpfPS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if (radioButtonNome.Checked == true)
                {

                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoNomePSTxt '" + txtPesquisaNomePessoa.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        ValorPesquisa = 4;
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 4;
                        PesquisaNomePS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if ((radioButtonFichasTodos.Checked == false) && (radioButtonPesquisarRG.Checked == false) && (radioButtonCpf.Checked == false) &&
                    (radioButtonNome.Checked == false))
                {
                    MessageBox.Show("Selecione Todos, Rg, Cpf ou nome!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());
            }
        }
        private void txtPesquisaMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaEmpresa();
            }
        }      

        private void txtPesquisaRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaFichaEmprego();
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaFichaEmprego();
            }
        }

        bool VerificarObjeto(object obj)
        {
            try
            {
                object objeto = obj;
                if (objeto == null)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return true;
            }

        }
        private void dataGridViewFichasCadastrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int NumeroRegistro = Convert.ToInt32(dataGridViewFichasCadastrada["REGISTRO", e.RowIndex].Value);
                string NomeRegistro = Convert.ToString(dataGridViewFichasCadastrada["NOME_PESSOA", e.RowIndex].Value);
                int Linha_Selecionada = int.Parse(dataGridViewFichasCadastrada.CurrentRow.Index.ToString());
                int contador = 0;

                if ((VerificarObjeto(dataGridViewFichasCadastrada.Rows[Linha_Selecionada].Cells[0].Value) == false))
                {
                    if (dataGridViewClassificados.RowCount > 1)
                    {
                        for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                        {
                            int ValorClassificados = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                            if (NumeroRegistro == ValorClassificados)
                            {
                                contador++;
                                inicio = dataGridViewClassificados.RowCount;
                            }
                        }
                        if (contador == 0)
                        {
                            string[] row = new string[] { Convert.ToString(NumeroRegistro), NomeRegistro };
                            dataGridViewClassificados.Rows.Add(row);
                            label4.Text = dataGridViewClassificados.RowCount.ToString();
                        }
                        else { MessageBox.Show("Já consta ficha em listagem!"); }
                    }
                    else
                    {
                        string[] row = new string[] { Convert.ToString(NumeroRegistro), NomeRegistro };
                        dataGridViewClassificados.Rows.Add(row);
                        label4.Text = dataGridViewClassificados.RowCount.ToString();
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

        private void buttonSalvarProcessoSelecao_Click(object sender, EventArgs e)
        {
            if ((checkBoxStatusAtivo.Checked == true) && (checkBoxStatusFinalizacao.Checked == true))
            {
                SalvaCadastroProcessoSeletivoSS();
            }
            if ((checkBoxStatusAtivo.Checked == true) && (checkBoxStatusFinalizacao.Checked == false))
            {
                SalvaCadastroProcessoSeletivoSN();
            }
            if ((checkBoxStatusAtivo.Checked == false) && (checkBoxStatusFinalizacao.Checked == false))
            {
                MessageBox.Show("Só Cadastra Processo com status de processo Ativado!");
            }
            if((checkBoxStatusAtivo.Checked == false) && (checkBoxStatusFinalizacao.Checked == true))
            {
                MessageBox.Show("Só finaliza com status de processo de seleção ativado!");
            }            
        }
        public void SalvaCadastroProcessoSeletivoSS()
        {
            try
            {
                ProcessoSeletivo ProcessoSeletivoP = new ProcessoSeletivo();
                DadosPessoas DadosPessoasP = new DadosPessoas();


                ProcessoSeletivoP.IdEmpresa = this.IdEmpresaCliente;
                ProcessoSeletivoP.IdProfissaoProcessoSeletivo = this.IdProfissao;
                ProcessoSeletivoP.checkBoxStatusAtivo = 1;
                ProcessoSeletivoP.checkBoxStatusFinalizacao = 1;
                ProcessoSeletivoP.dateTimePickerDataCriacao = dateTimePickerCriacaoProcesso.Text;
                ProcessoSeletivoP.dateTimePickerDataFechamento = dateTimePickerFechamentodoProcesso.Text;
                ProcessoSeletivoP.txtComentatario = txtComentarios.Text;
                ProcessoSeletivoP.txtQuantVagas = txtQuantVagas.Text;

                if (validaNomeEmpresa(txtNomeEmpresa, errorProviderPS) == true)
                {
                    if ((dateTimePickerFechamentodoProcesso.Text.Length == 10) && (dateTimePickerFechamentodoProcesso.Text.Length == 10))
                    {
                        //Data de criação não pode se maior que data de fechamento!
                        if ((Convert.ToDateTime(dateTimePickerFechamentodoProcesso.Text).Subtract(dateTimePickerCriacaoProcesso.Value).Days >= 0))
                        {
                            if (dataGridViewClassificados.RowCount != 0)
                            {
                                if (validaVagas(txtQuantVagas, errorProviderPS) == true)
                                {
                                    if (int.Parse(txtQuantVagas.Text) == dataGridViewClassificados.RowCount)
                                    {
                                        Conexao2 conexao2 = new Conexao2(this.connetionString);
                                        DALDateSystemRH dal = new DALDateSystemRH(conexao2);

                                        dal.IncluirCadastraProcessoSelecao(ProcessoSeletivoP);

                                        CandidatosPSeletivo CandidatosPSeletivoP = new CandidatosPSeletivo();
                                        CandidatosPSeletivoP.idProcessoSeletivo = ProcessoSeletivoP.IdProcessoSeletivo;

                                        DialogResult dialogResult = MessageBox.Show("Deseja Finalizar Processo de Seleção  " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                                            {
                                                int IdPessoaSelecionada = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                                                CandidatosPSeletivoP.IdPessoa = IdPessoaSelecionada;

                                                Conexao2 conexao3 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da3 = new DALDateSystemRH(conexao3);
                                                da3.IncluirCadastraCandidatosPSeletivo(CandidatosPSeletivoP);


                                                DadosPessoasP.Id_DadosPessoas = IdPessoaSelecionada;
                                                DadosPessoasP.StatusMercado = 3;

                                                Conexao2 conexao5 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da5 = new DALDateSystemRH(conexao5);
                                                da5.UpdateStatusPessoaFicha(DadosPessoasP);

                                            }
                                            MessageBox.Show(" Adicionado com exito e Finalizado!");
                                            FecharTodosFormulario();

                                        }
                                        else if (dialogResult == DialogResult.No)
                                        {

                                        }
                                    



                                    }
                                    else MessageBox.Show("Número de canditatos não compatível!");
                                }
                                else MessageBox.Show("Adicione Número de vagas!");
                            }
                            else MessageBox.Show("Sem adicionar canditados pela vaga em classificados!");
                        }
                        else MessageBox.Show("Atenção a data de fechamento não pode ser menor que a data de criação!");
                    }
                }
            }
            catch(Exception ex) { ex.ToString(); }          
        }
        public void SalvaCadastroProcessoSeletivoSN()
        {
            try
            {
                ProcessoSeletivo ProcessoSeletivoP = new ProcessoSeletivo();
                DadosPessoas DadosPessoasP = new DadosPessoas();

                ProcessoSeletivoP.IdEmpresa = this.IdEmpresaCliente;
                ProcessoSeletivoP.IdProfissaoProcessoSeletivo = this.IdProfissao;
                ProcessoSeletivoP.checkBoxStatusAtivo = 1;
                ProcessoSeletivoP.checkBoxStatusFinalizacao = 2;
                ProcessoSeletivoP.dateTimePickerDataCriacao = dateTimePickerCriacaoProcesso.Text;
                ProcessoSeletivoP.dateTimePickerDataFechamento = "";
                ProcessoSeletivoP.txtComentatario = txtComentarios.Text;
                ProcessoSeletivoP.txtQuantVagas = txtQuantVagas.Text;

                if (validaNomeEmpresa(txtNomeEmpresa, errorProviderPS) == true)
                {
                    if (dataGridViewClassificados.RowCount != 0)
                    {
                        if (validaVagas(txtQuantVagas, errorProviderPS) == true)
                        {
                            Conexao2 conexao2 = new Conexao2(this.connetionString);
                            DALDateSystemRH dal = new DALDateSystemRH(conexao2);

                            dal.IncluirCadastraProcessoSelecao(ProcessoSeletivoP);

                            CandidatosPSeletivo CandidatosPSeletivoP = new CandidatosPSeletivo();
                            CandidatosPSeletivoP.idProcessoSeletivo = ProcessoSeletivoP.IdProcessoSeletivo;

                            for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                            {
                                int IdPessoaSelecionada = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                                CandidatosPSeletivoP.IdPessoa = IdPessoaSelecionada;

                                Conexao2 conexao3 = new Conexao2(this.connetionString);
                                DALDateSystemRH da3 = new DALDateSystemRH(conexao3);
                                da3.IncluirCadastraCandidatosPSeletivo(CandidatosPSeletivoP);


                                DadosPessoasP.Id_DadosPessoas = IdPessoaSelecionada;
                                DadosPessoasP.StatusMercado = 3;

                                Conexao2 conexao5 = new Conexao2(this.connetionString);
                                DALDateSystemRH da5 = new DALDateSystemRH(conexao5);
                                da5.UpdateStatusPessoaFicha(DadosPessoasP);

                            }
                            FecharTodosFormulario();
                            MessageBox.Show(" Adicionado com exito!");

                            DialogResult dialogResult = MessageBox.Show("Deseja Criar novo Processo Seleção  " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                FormProcessoSelecao FormProcessoSelecaoP = new FormProcessoSelecao(this.IdLoginUsuario,this.FichaEditar);
                                FormProcessoSelecaoP.MdiParent = FormProcessoSelecao.ActiveForm;
                                FormProcessoSelecaoP.Show();
                                FormProcessoSelecaoP.Top = 200;
                                FormProcessoSelecaoP.Left = 150;

                            }
                            else if (dialogResult == DialogResult.No)
                            {

                            }
                        }
                        else MessageBox.Show("Adicione Número de vagas!");
                    }
                    else MessageBox.Show("Sem adicionar canditados pela vaga em classificados!");
                }
                else MessageBox.Show("Adicione empresa para processo seletivo!");
            }
            catch(Exception ex) { MessageBox.Show( ex.ToString()); }
            
        }
    
        private void dataGridViewClassificados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Linha_Selecionada = int.Parse(dataGridViewClassificados.CurrentRow.Index.ToString());

                if ((VerificarObjeto(dataGridViewClassificados.Rows[Linha_Selecionada].Cells[0].Value) == false))
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja Remover " + dataGridViewClassificados.Rows[Linha_Selecionada].Cells[1].Value.ToString() + " ? ", " Aviso", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridViewClassificados.Rows.RemoveAt(Linha_Selecionada);
                        label4.Text = dataGridViewClassificados.RowCount.ToString();
                        this.IdFicha = 0;
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Refresh();
            }
        }

        private void buttonLimpoEstabilidade_Click(object sender, EventArgs e)
        {
            LimpaEstabilidade();
        }
        public void LimpaEstabilidade()
        {
            this.IdPEstabilidade = 0;
            comboBoxEstabilidade.Items.Clear();
            Fill_listBoxTodasEstabilidade();
        }

        private void buttonFechaProcessoSeletivo_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void txtPesquisaNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscaEmpresa();
            }
        }

        private void txtPesquisaNomePessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscaFichaEmprego();
            }
        }

        private void buttonFotoCanditado_Click(object sender, EventArgs e)
        {
            FotoFicha();
        }
        public void FotoFicha()
        {
            if(IdFicha == 0)
            {
                MessageBox.Show("Clica em algum registro de processo seletivo");
            }
            else
            {
                FecharTodosFormulario2();
                FormFotoFicha FormFotoFichaF = new FormFotoFicha(this.IdFicha, this.FichaEditar, this.IdLoginUsuario);
                FormFotoFichaF.Show();
                FormFotoFichaF.Top = 200;
                FormFotoFichaF.Left = 150;
            }
        }

        private void dataGridViewClassificados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.IdFicha = Convert.ToInt32(dataGridViewClassificados["ID_CLASSIFICACAO", e.RowIndex].Value);

                //SqlConnection conn4 = new SqlConnection(this.connetionString);
                //string sql4 = "SELECT NOME,TELEFONE,CELULAR FROM P_Pessoa WHERE ID_PESSOA =  " + NumeroRegistro + ";";
                //SqlDataAdapter sda4 = new SqlDataAdapter(sql4, conn4);
                //DataSet ds4 = new DataSet();
                //sda4.Fill(ds4);
                //conn4.Open();

                //conn4.Close();
            }
            catch (Exception ex)
            {// MessageBox.Show("Error" + ex.ToString()); 
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtQuantVagas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Se a tecla digitada não for número
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
